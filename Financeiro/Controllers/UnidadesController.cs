using Entidades;
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
    public class UnidadesController
    {
        static string controllerName = "UnidadesController";

        public static List<Unidades> Listar(string busca = "")
        {
            Session session = null;

            try
            {
                Unidades unidades = new Unidades();
                session = new ConfigureSession().GetSession();

                if (!string.IsNullOrEmpty(busca))
                    session.CreateCriteria(unidades, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.MULTIPLE)
                        .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "sigla", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE))
                        .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.OR, "descricao", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE))
                        .Execute();
                else
                    session.ReadAll(unidades);

                session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, unidades.ResultList.Count + " carregados.");

                return session.GetList(unidades);
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write(controllerName, "Listar", ex.Message);

                return new List<Unidades>();
            }
        }

        public static int ProdutosRelacionados(int unidade_id)
        {
            Session session = null;
            try
            {
                Produtos produtos = new Produtos();

                session = new ConfigureSession().GetSession();
                int retorno = session.Count(produtos, "unidade = " + unidade_id + " OR segunda_unidade = " + unidade_id);
                session.Close();

                return retorno;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write(controllerName, "ProdutosRelacionados", ex.Message);

                return 0;
            }
        }

        public static Unidades Carregar(int unidade_id)
        {
            Session session = null;
            try
            {
                Unidades unidade = new Unidades();

                session = new ConfigureSession().GetSession();
                session.OnID(unidade, unidade_id);
                session.Close();

                return unidade;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Carregar", ex.Message);

                return null;
            }
        }

        public static bool Salvar(Unidades unidade)
        {
            Session session = null;

            try
            {
                if (!Validar(unidade)) return false;

                session = new ConfigureSession().GetSession();

                if (EntidadeController.Existe(unidade, "id", unidade.Id.ToString()))
                {
                    session.Update(unidade);
                    Notificacao.Sucesso("Unidade salva.");
                }
                else
                {
                    if(EntidadeController.Existe(unidade, "sigla", unidade.Sigla))
                    {
                        Notificacao.Alerta("Já existe uma unidade com essa sigla. Escolha outra e tente novamente.");
                        session.Close();
                        return false;
                    }

                    session.Save(unidade);
                    Notificacao.Sucesso("Unidade atualizada.");
                }

                session.Close();
                return true;
            }
            catch (Exception ex)
            {
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Salvar", ex.Message);

                return false;
            }
        }

        public static bool Excluir(int unidade_id)
        {
            Session session = null;
            try
            {
                Unidades unidade = new Unidades();

                session = new ConfigureSession().GetSession();
                session.OnID(unidade, unidade_id);

                if(PodeExcluir(unidade))
                {
                    session.Delete(unidade);
                }

                session.Close();
                return true;
            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Excluir", ex.Message);

                return false;
            }
        }

        private static bool Validar(Unidades unidade)
        {
            if (string.IsNullOrWhiteSpace(unidade.Descricao))
            {
                Notificacao.Alerta("A descrição da unidade não pode estar vazia.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(unidade.Sigla))
            {
                Notificacao.Alerta("A sigla da unidade não pode estar vazia.");
                return false;
            }

            return true;
        }

        private static bool PodeExcluir(Unidades unidade)
        {
            Produtos produtos = new Produtos();

            if (EntidadeController.Existe(produtos, "unidade", unidade.Id.ToString()))
            {
                Notificacao.Alerta("Esta unidade não pode ser excluída. Existe um ou mais produtos relacionados a ela.");
                return false;
            }

            if (EntidadeController.Existe(produtos, "segunda_unidade", unidade.Id.ToString()))
            {
                Notificacao.Alerta("Esta unidade não pode ser excluída. Existe um ou mais produtos relacionados a ela.");
                return false;
            }

            return true;
        }
    }
}