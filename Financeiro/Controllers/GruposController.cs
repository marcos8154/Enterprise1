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
    public class GruposController
    {
        static string controllerName = "GruposController";

        public static List<Grupos> Listar(string busca = "")
        {
            Session session = null;

            try
            {
                Grupos grupos = new Grupos();

                session = new ConfigureSession().GetSession();

                if (!string.IsNullOrWhiteSpace(busca))
                    session.CreateCriteria(grupos, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.MULTIPLE)
                        .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "sigla", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE))
                        .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.OR, "descricao", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE))
                        .Execute();
                else
                    session.ReadAll(grupos);

                session.Close();
                Notificacao.Sucesso(grupos.ResultList.Count + " grupos carregados.");
                return session.GetList(grupos);
            }
            catch (Exception ex)
            {
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Listar", ex.Message);

                return new List<Grupos>();
            }
        }

        public static Grupos Carregar(int grupo_id)
        {
            Session session = null;

            try
            {
                Grupos grupo = new Grupos();

                session = new ConfigureSession().GetSession();
                session.OnID(grupo, grupo_id);
                session.Close();

                return grupo;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Carregar", ex.Message);

                return null;
            }
        }

        public static bool Salvar(Grupos grupo)
        {
            Session session = null;

            try
            {
                if (!Validar(grupo)) return false;
                session = new ConfigureSession().GetSession();

                if (EntidadeController.Existe(grupo, "id", grupo.Id.ToString()))
                {
                    session.Update(grupo);
                    Notificacao.Sucesso("Grupo atualizado.");
                }
                else
                {
                    if(EntidadeController.Existe(grupo, "sigla", grupo.Sigla))
                    {
                        Notificacao.Alerta("Já existe um grupo com esta sigla. Escolha outra e tente novamente.");
                        session.Close();
                        return false;
                    }

                    session.Save(grupo);
                    Notificacao.Sucesso("Grupo salvo.");
                }
                session.Close();
                return true;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Salvar", ex.Message);

                return false;
            }
        }

        public static bool Excluir(int grupo_id)
        {
            Session session = null;

            try
            {
                Grupos grupo = new Grupos();

                session = new ConfigureSession().GetSession();
                session.OnID(grupo, grupo_id);

                if(PodeExcluir(grupo))
                {
                    session.Delete(grupo);
                    Notificacao.Sucesso("Grupo de produtos excluído.");
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

        private static bool Validar(Grupos grupo)
        {
            if (string.IsNullOrWhiteSpace(grupo.Descricao))
            {
                Notificacao.Alerta("A descrição do grupo não pode estar vazia.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(grupo.Sigla))
            {
                Notificacao.Alerta("A sigla do grupo não pode estar vazia.");
                return false;
            }

            return true;
        }

        private static bool PodeExcluir(Grupos grupo)
        {
            Produtos produtos = new Produtos();

            if (EntidadeController.Existe(produtos, "grupos_id", grupo.Id.ToString()))
            {
                Notificacao.Alerta("Este grupo não pode ser excluído. Existe um ou mais produtos relacionados a ele.");
                return false;
            }

            return true;
        }

        public static int ProdutosRelacionados(int id_grupo)
        {
            Session session = null;

            try
            {
                Produtos produtos = new Produtos();

                session = new ConfigureSession().GetSession();
                int retorno = session.Count(produtos, "grupos_id = " + id_grupo);
                session.Close();

                return retorno;
            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "ProdutosRelacionados", ex.Message);

                return 0;
            }
        }
    }
}
