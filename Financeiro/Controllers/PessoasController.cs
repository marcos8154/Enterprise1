using Entidades;
using Financeiro.Enums;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using Persistor_GA.GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class PessoasController
    {
        public static int Count(int tipo_pessoa)
        {
            Session session = null;
            try
            {
                Pessoas pessoas = new Pessoas();

                session = new ConfigureSession().GetSession();
                int retorno = session.Count(pessoas, "TIPO_PESSOA = " + tipo_pessoa);
                session.Close();

                return retorno;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write("PessoasController", "Count", ex.Message);

                return 0;
            }
        }

        public static List<Pessoas> Listar(int tipo_pessoa, string busca = "", bool exibirInativos = false)
        {
            Session session = null;

            try
            {
                busca = busca.Replace("'", string.Empty);
                string criterio = " ON documentos.id = pessoas.documentos_id ";
                criterio += " AND TIPO_PESSOA = " + tipo_pessoa;

                if (!string.IsNullOrWhiteSpace(busca))
                {
                    criterio += @" AND (razao_social LIKE '%" + busca + "%'";
                    criterio += "  OR CPF LIKE '%" + busca + "%'";
                    criterio += "  OR RG LIKE '%" + busca + "%'";
                    criterio += "  OR telefone1 LIKE '%" + busca + "%'";
                    criterio += "  OR telefone2 LIKE '%" + busca + "%'";
                    criterio += "  OR celular LIKE '%" + busca + "%'";
                    criterio += "  OR cargo LIKE '%" + busca + "$'";
                    criterio += "  OR email LIKE '%" + busca + "%')";
                }

                criterio += " AND inativo = " + (exibirInativos ? 1 : 0);

                Pessoas pessoas = new Pessoas();
                Documentos documentos = new Documentos();

                session = new ConfigureSession().GetSession();

                Join join = new Join(pessoas);

                join.AddJoin(Persistor_GA.GeneralClasses.Enums.JOIN_TYPE.INNER, documentos);
                join.AddFinalCondition(criterio);
                join.Execute(session);

                List<Pessoas> retorno = join.GetList(pessoas);
                session.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema o processar solicitação: " + ex.Message);
                Log.Write("PessoasController", "Listar", ex.Message);
                return new List<Pessoas>();
            }
        }

        public static Pessoas Carregar(int id_pessoa)
        {
            Session session = null;

            try
            {
                Pessoas pessoa = new Pessoas();

                session = new ConfigureSession().GetSession();
                session.OnID(pessoa, id_pessoa);
                session.Close();

                return pessoa;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write("ClientesController", "Carregar", ex.Message);
                return new Pessoas();
            }
        }

        private static bool ValidaDocumento(Documentos documento)
        {

            if (!documento.CNPJ.StartsWith(" "))
                if (EntidadeController.Existe(documento, "CNPJ", documento.CNPJ))
                {
                    Notificacao.Publicar(TIPO_NOTIFICACAO.ALERTA, "Já existe uma pessoa com o CNPJ informado. Verifique o CNPJ e tente novamente");
                    return false;
                }

            if (!documento.CPF.StartsWith(" "))
                if (EntidadeController.Existe(documento, "CPF", documento.CPF))
                {
                    Notificacao.Publicar(TIPO_NOTIFICACAO.ALERTA, "Já existe uma pessoa com o CPF informado. Verifique o CPF e tente novamente");
                    return false;
                }

            if (!string.IsNullOrWhiteSpace(documento.RG))
                if (EntidadeController.Existe(documento, "RG", documento.RG))
                {
                    Notificacao.Publicar(TIPO_NOTIFICACAO.ALERTA, "Já existe uma pessoa com o RG informado. Verifique o RG e tente novamente");
                    return false;
                }

            return true;
        }

        public static bool Excluir(int id_pessoa)
        {
            Session session = null;
            Transaction transaction = null;
            try
            {
                Movimentos movimentos = new Movimentos();

                if (EntidadeController.Existe(movimentos, "id_cliente", id_pessoa.ToString()))
                {
                    Notificacao.Publicar(TIPO_NOTIFICACAO.ALERTA, "Não é possível excluir esta pessoa. Ela está relacionada em um ou mais movimentos.");
                    return false;
                }

                session = new ConfigureSession().GetSession();
                transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);

                Pessoas cliente = new Pessoas();
                Financeiro_pessoa financeiro = new Financeiro_pessoa();
                Documentos documento = new Documentos();
                Enderecos endereco = new Enderecos();

                session.OnID(cliente, id_pessoa);
                session.Delete(cliente, cliente.Id, transaction);
                session.Delete(financeiro, cliente.Financeiro_pessoa_id, transaction);
                session.Delete(documento, cliente.Documentos_id, transaction);
                session.Delete(endereco, cliente.Enderecos_id, transaction);

                bool result = false;
                if (transaction.Commit()) result = true;
                session.Close();

                Notificacao.Publicar(TIPO_NOTIFICACAO.SUCESSO, "Pessoa excluída.");
                return result;
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.RollBack();
                if (session != null) session.Close();

                Log.Write("PessoasController", "Excluir", ex.Message);
                Notificacao.Publicar(TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);

                return false;
            }
        }

        public static bool Salvar(Pessoas cliente, Documentos documento, Financeiro_pessoa financeiro, Enderecos endereco)
        {
            Session session = null;
            Transaction transaction = null;

            try
            {
                if (!Validar(cliente)) return false;
                session = new ConfigureSession().GetSession();
        
                if (EntidadeController.Existe(cliente, "id", cliente.Id.ToString()))
                {
                    transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    session.Update(documento, null, transaction);
                    session.Update(financeiro, null, transaction);
                    session.Update(endereco, null, transaction);
                    session.Update(cliente, null, transaction);

                    Notificacao.Publicar(TIPO_NOTIFICACAO.SUCESSO, "Pessoa atualizada.");
                }
                else
                {
                    if (!ValidaDocumento(documento))
                    {
                        return false;
                    }

                    transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    session.Save(documento, transaction);
                    session.Save(financeiro, transaction);
                    session.Save(endereco, transaction);

                    cliente.Documentos_id = documento.Id;
                    cliente.Financeiro_pessoa_id = financeiro.Id;
                    cliente.Enderecos_id = endereco.Id;

                    session.Save(cliente, transaction);

                    Notificacao.Publicar(TIPO_NOTIFICACAO.SUCESSO, "Pessoa salva.");
                }

                bool result = false;
                if (transaction.Commit()) result = true;

                session.Close();
                return result;
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.RollBack();
                if (session != null) session.Close();
                Notificacao.Publicar(TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write("PessoasController", "Salvar", ex.Message);
                return false;
            }
        }

        private static bool Validar(Pessoas pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Razao_social))
            {
                Notificacao.Publicar(TIPO_NOTIFICACAO.ALERTA, "O nome não pode estar vazio.");
                return false;
            }

            return true;
        }
    }
}
