using Entidades;
using Financeiro.Enums;
using Financeiro.SessionProvider;
using Persistor.EntityManager;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Financeiro.Controllers
{
    public class EmpresaController
    {
        public static int GetID(ORDEM ordem)
        {
            Empresa e = new Empresa();
            if (ordem == ORDEM.PRIMEIRO) EntidadeController.Primeiro_id(e);
            if (ordem == ORDEM.ULTIMO) EntidadeController.Ultimo_id(e);

            return e.Id;
        }

        public static List<Empresa> Listar(string busca = "")
        {
            Session session = null;
            try
            {
                session = new ConfigureSession().GetSession();

                Empresa empresa = new Empresa();
                Enderecos endereco = new Enderecos();

                if(!string.IsNullOrEmpty(busca))
                {
                    Join join = new Join(empresa);
                    join.AddJoin(Persistor_GA.GeneralClasses.Enums.JOIN_TYPE.INNER, endereco, "empresa.enderecos_id = enderecos.id");

                    string criterio = " WHERE ";
                    criterio += " nome_fantasia like '%{busca}%' OR";
                    criterio += " razao_social like '%{buca}%' OR";
                    criterio += " CNPJ like '%{busca}%' OR";
                    criterio += " telefone1 like '%{busca}%' OR";
                    criterio += " telefone2 like '%{busca}%' OR";
                    criterio += " celular like '%{busca}%' OR";
                    criterio += " email like '%{busca}%' OR";
                    criterio += " municipio like '%{busca}%'";

                    busca = busca.Replace("'", "");
                    criterio = criterio.Replace("{busca}", busca);
                    join.AddFinalCondition(criterio);
                    join.Execute(session);
                    session.Close();
                    return join.GetList(empresa);
                }
                else
                {
                    session.ReadAll(empresa);
                }

                session.Close();
                return session.GetList(empresa);

            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write("EmpresaController", "listar", ex.Message);

                return new List<Empresa>();
            }

        }

        public static Empresa Carregar(int id_empr)
        {
            Session session = null;

            try
            {
                Empresa empresa = new Empresa();

                session = new ConfigureSession().GetSession();
                session.OnID(empresa, id_empr);
                session.Close();

                return empresa;

            }
            catch (Exception ex)
            {
                Log.Write("EmpresaController", "Carregar", ex.Message);
                if (session != null) session.Close();
                return null;
            }
        }

        public static bool Excluir(int id_empr)
        {
            Session session = null;
            Transaction transaction = null;
            try
            {
                Empresa empresa = Carregar(id_empr);
                if (!PodeExcluir(empresa)) return false;

                session = new ConfigureSession().GetSession();
                transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                Enderecos endereco = EnderecosController.Carregar(empresa.Enderecos_id);

                session.Delete(empresa, id_empr, transaction);
                session.Delete(endereco, endereco.Id, transaction);

                transaction.Commit();
                session.Close();
                Notificacao.Sucesso("Empresa excluída");
                return true;
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.RollBack();
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write("EmpresaController", "Excluir", ex.Message);

                return false;
            }
        }

        private static bool PodeExcluir(Empresa empresa)
        {
            Pessoas p = new Pessoas();
            Produtos prod = new Produtos();
            Contas_pagar cp = new Contas_pagar();
            Contas_receber cr = new Contas_receber();
            Movimentos mov = new Movimentos();

            if (EntidadeController.Existe(p, "loja", empresa.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluir esta empresa. Existem uma ou mais pessoas relacionadas a ela.");
                return false;
            }

            if(EntidadeController.Existe(prod, "loja", empresa.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluir esta empresa. Existem um ou mais produtos relacionados a ela.");
                return false;
            }

            if(EntidadeController.Existe(cp, "loja", empresa.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluir esta empresa. Existem uma ou mais contas a pagar/pagas relacionados a ela.");
                return false;
            }

            if(EntidadeController.Existe(cr, "loja", empresa.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluir esta empresa. Existem uma ou mais contas a receber/recebidas relacionados a ela.");
                return false;
            }

            if(EntidadeController.Existe(mov, "loja", empresa.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluir esta empresa. Existem um ou mais movimentos relacionados a ela.");
                return false;
            }

            return true;
        }

        public static bool Salvar(Empresa empresa, Enderecos endereco)
        {
            Session session = null;

            try
            {
                if (!ValidaEmpresa(empresa)) return false;
                if (!ValidaEndereco(endereco)) return false;

                bool result = false;
                empresa.Enderecos_id = endereco.Id;

                session = new ConfigureSession().GetSession();
                Transaction transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);

                if (EntidadeController.Existe(empresa, "id", empresa.Id.ToString()))
                {
                    session.Update(endereco, null, transaction);
                    session.Update(empresa, null, transaction);

                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Empresa alterada.");
                }
                else
                {
                    session.Save(endereco, transaction);
                    empresa.Enderecos_id = endereco.Id;
                    session.Save(empresa, transaction);

                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Empresa salva.");
                }

                if (transaction.Commit()) result = true;

                session.Close();

                return result;
            }
            catch (Exception ex)
            {
                Log.Write("EmpresaController", "Salvar", ex.Message);
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema interno ao realizar a operação: " + ex.Message);
                return false;
            }
        }

        private static bool ValidaEmpresa(Empresa empresa)
        {
            if (string.IsNullOrWhiteSpace(empresa.Nome_fantasia))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O nome fantasia não pode estar vazio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(empresa.Razao_social))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "A razão social não pode estar vazia.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(empresa.CNPJ))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O CNPJ não pode estar vazio.");
                return false;
            }

            return true;
        }

        private static bool ValidaEndereco(Enderecos endereco)
        {
            if (endereco.CEP.StartsWith("_"))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "CEP inválido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco.Logradouro))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O logradouro é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(endereco.Municipio))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O município é obrigatório.");
                return false;
            }

            if (endereco.Numero == 0)
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O número é obrigatório.");
                return false;
            }

            return true;
        }

    }
}
