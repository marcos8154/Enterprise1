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
    public class CaracteristicasController
    {
        static string controllerName = "CaracteristicasController";

        public static int ProdutosRelacionados(int id_caract)
        {
            Session session = null;

            try
            {
                Produtos produtos = new Produtos();
                session = new ConfigureSession().GetSession();

                int retorno = session.Count(produtos, "caracteristica_1 = " + id_caract + " OR caracteristica_2 = " + id_caract);

                session.Close();

                return retorno;

            }
            catch(Exception ex)
            {

                return 0;
            }
        }

        public static Caracteristicas Carregar(int id_caract)
        {
            Session session = null;

            try
            {
                Caracteristicas caract = new Caracteristicas();

                session = new ConfigureSession().GetSession();
                session.OnID(caract, id_caract);
                session.Close();

                return caract;
            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write(controllerName, "Carregar", ex.Message);

                return null;
            }
        }

        public static List<Caracteristicas> Listar(string busca = "")
        {
            Session session = null;

            try
            {
                Caracteristicas caracteristicas = new Caracteristicas();

                session = new ConfigureSession().GetSession();

                session.CreateCriteria(caracteristicas, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.MULTIPLE)
                    .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "atributo", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE))
                    .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.OR, "valor", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE))
                    .Execute();

                session.Close();

                return session.GetList(caracteristicas);
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write(controllerName, "Listar", ex.Message);

                return new List<Caracteristicas>();
            }
        }

        public static bool Salvar(Caracteristicas caracteristica)
        {
            Session session = null;

            try
            {
                if (!Validar(caracteristica)) return false;

                session = new ConfigureSession().GetSession();

                if (EntidadeController.Existe(caracteristica, "id", caracteristica.Id.ToString()))
                {
                    session.Update(caracteristica);
                }
                else
                {
                    session.Save(caracteristica);
                }

                session.Close();
                return true;

            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write(controllerName, "Salvar", ex.Message);

                return false;
            }
        }

        public static bool Excluir(int id_carac)
        {
            Session session = null;

            try
            {
                Caracteristicas caracteristica = Carregar(id_carac);

                if (!PodeExcluir(caracteristica)) return false;

                session = new ConfigureSession().GetSession();
                session.Delete(caracteristica);
                session.Close();

                return true;

            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write(controllerName, "Excluir", ex.Message);

                return false;
            }
        }

        private static bool PodeExcluir(Caracteristicas caracteristica)
        {
            Produtos produtos = new Produtos();

            if (EntidadeController.Existe(produtos, "caracteristica_1", caracteristica.Id.ToString()))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "Não é possível excluír esta característica. Ela está relacionada á um ou mais produtos.");
                return false;
            }

            if (EntidadeController.Existe(produtos, "caracteristica_2", caracteristica.Id.ToString()))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "Não é possível excluír esta característica. Ela está relacionada á um ou mais produtos.");
                return false;
            }

            return true;
        }

        private static bool Validar(Caracteristicas caract)
        {
            if (string.IsNullOrEmpty(caract.Valor))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O valor da característica não pode estar vazio.");
                return false;
            }

            return true;
        }
    }
}