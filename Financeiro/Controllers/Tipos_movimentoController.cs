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
    public class Tipos_movimentoController
    {
        public static Tipos_movimento Carregar(int tmv_id)
        {
            Session session = null;

            try
            {
                Tipos_movimento tmv = new Tipos_movimento();

                session = new ConfigureSession().GetSession();
                session.OnID(tmv, tmv_id);
                session.Close();

                return tmv;
            }
            catch (Exception ex)
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao executar rotina: " + ex.Message);
                if (session != null) session.Close();
                Log.Write("Tipos_movimentoController", "Carregar", ex.Message);

                return null;
            }
        }

        public static List<Tipos_movimento> Listar(string busca, bool inativos = false)
        {
            Session session = null;

            try
            {
                Tipos_movimento tmv = new Tipos_movimento();

                session = new ConfigureSession().GetSession();

                if (!string.IsNullOrEmpty(busca))
                    session.CreateCriteria(tmv, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.MULTIPLE)
                        .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "descricao", busca))
                        .Execute();

                else
                    session.ReadAll(tmv);

                session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, tmv.ResultList.Count + " Tipos de movimento carregado(s).");
                return session.GetList(tmv);
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Log.Write("Tipos_movimentoController", "Listar", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar a solicitação: " + ex.Message);
                return new List<Tipos_movimento>();
            }
        }

        public static bool Salvar(Tipos_movimento tmv)
        {
            if (!Validar(tmv)) return false;

            Session session = null;

            try
            {
                session = new ConfigureSession().GetSession();

                if(EntidadeController.Existe(tmv, "id", tmv.Id.ToString()))
                {
                    session.Update(tmv);
                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Tipo de movimento atualizado.");
                }
                else
                {
                    session.Save(tmv);
                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Tipo de movimento salvo.");
                }

                session.Close();
               
                return true;
            }
            catch(Exception ex)
            {
                Log.Write("Tipos_movimentoController", "Salvar", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao salvar o tipo de movimento: " + ex.Message);
                if (session != null) session.Close();
                return false;
            }
        }

        private static bool Validar(Tipos_movimento tmv)
        {
            if(string.IsNullOrWhiteSpace(tmv.Descricao))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "A descrição do tipo de movimento não pode estar vazia.");
                return false;
            }

            return true;
        }
    }
}
