//using Entidades;
//using Financeiro.SessionProvider;
//using Persistor.Persistence;
//using Persistor_GA.GeneralClasses;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Financeiro.Controllers
//{
//    public class LocaisEstoqueController
//    {
//        static string controllerName = "LocaisEstoqueController";

//        public static List<Locais_estoque> Lista(string busca = "")
//        {
//            Session session = null;

//            try
//            {
//                Locais_estoque le = new Locais_estoque();

//                session = new ConfigureSession().GetSession();

//                if (!string.IsNullOrWhiteSpace(busca))
//                    session.CreateCriteria(le, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.MULTIPLE)
//                        .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "descricao", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE))
//                        .Execute();

//                else
//                    session.ReadAll(le);

//                Notificacao.Sucesso(le.ResultList.Count + " items carregados.");
//                session.Close();

//                return session.GetList(le);
//            }
//            catch (Exception ex)
//            {
//                if (session != null) session.Close();
//                Notificacao.Erro(ex.Message);
//                Log.Write(controllerName, "Listar", ex.Message);

//                return new List<Locais_estoque>();
//            }
//        }

//        public static Locais_estoque Carregar(int le_id)
//        {
//            Session session = null;
//            try
//            {
//                Locais_estoque le = new Locais_estoque();

//                session = new ConfigureSession().GetSession();
//                session.OnID(le, le_id);
//                session.Close();

//                return le;
//            }
//            catch (Exception ex)
//            {
//                if (session != null) session.Close();
//                Notificacao.Erro(ex.Message);
//                Log.Write(controllerName, "Listar", ex.Message);

//                return null;
//            }
//        }

//        public static bool Salvar(Locais_estoque le)
//        {
//            if (!Validar(le)) return false;

//            Session session = null;
//            try
//            {
//                session = new ConfigureSession().GetSession();

//                if (EntidadeController.Existe(le, "id", le.Id.ToString()))
//                {
//                    session.Update(le);
//                    Notificacao.Sucesso("Local de estoque alterado.");
//                }
//                else
//                {
//                    session.Save(le);
//                    Notificacao.Sucesso("Local de estoque salvo.");
//                }

//                session.Close();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                if (session != null) session.Close();
//                Notificacao.Erro(ex.Message);
//                Log.Write(controllerName, "Salvar", ex.Message);

//                return false;
//            }
//        }

//        public static bool Excluir(int id_le)
//        {

//            Session session = null;
//            try
//            {
//                Locais_estoque le = new Locais_estoque();

//                session = new ConfigureSession().GetSession();
//                session.OnID(le, id_le);

//                if (PodeExcluir(le))
//                {
//                    session.Delete(le);
//                    Notificacao.Sucesso("Local de estoque excluído.");
//                }

//                session.Close();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                if (session != null) session.Close();
//                Notificacao.Erro(ex.Message);
//                Log.Write(controllerName, "Excluir", ex.Message);

//                return false;
//            }
//        }

//        public static int ProdutosRelacionados(int id_le)
//        {
//            Session session = null;
//            try
//            {
//                Produtos produtos = new Produtos();

//                session = new ConfigureSession().GetSession();
//                int result = session.Count(produtos, "locais_estoque_id = " + id_le);
//                session.Close();

//                return result;
//            }
//            catch (Exception ex)
//            {
//                if (session != null) session.Close();
//                Notificacao.Erro(ex.Message);
//                Log.Write(controllerName, "ProdutosRelacionados", ex.Message);

//                return 0;
//            }
//        }

//        private static bool PodeExcluir(Locais_estoque le)
//        {
//            Produtos produtos = new Produtos();
//            if (EntidadeController.Existe(produtos, "locais_estoque_id", le.Id.ToString()))
//            {
//                Notificacao.Alerta("Não é possível excluir este local de estoque. Existem produtos relacionados a ele.");
//                return false;
//            }

//            return true;
//        }

//        private static bool Validar(Locais_estoque le)
//        {
//            if (string.IsNullOrWhiteSpace(le.Descricao))
//            {
//                Notificacao.Alerta("A descrição da localização não pode estar vazia.");
//                return false;
//            }

//            return true;
//        }
//    }
//}
