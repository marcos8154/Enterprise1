using Entidades;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using Persistor_GA.GeneralClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class Formas_pagamentoController
    {
        public static Formas_pagamento Carregar(int id_fpg)
        {
            Session session = null;

            try
            {
                Formas_pagamento fpg = new Formas_pagamento();

                session = new ConfigureSession().GetSession();
                session.OnID(fpg, id_fpg);
                session.Close();

                return fpg;
            }
            catch (Exception ex)
            {
                Log.Write("Formas_pagamentoController", "Carregar", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                if (session != null) session.Close();

                return new Formas_pagamento();
            }
        }

        public static List<Formas_pagamento> Listar(string busca = "", bool somenteAtivos = false)
        {
            Session session = null;

            try
            {
                Formas_pagamento fpg = new Formas_pagamento();

                session = new ConfigureSession().GetSession();

                if (!string.IsNullOrEmpty(busca))
                    session.CreateCriteria(fpg, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.MULTIPLE)
                        .Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "descricao", busca))
                        .Execute();

                else
                    session.ReadAll(fpg);

                session.Close();

                return session.GetList(fpg);
            }
            catch (Exception ex)
            {
                Log.Write("Formas_pagamentoController", "Listar", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                if (session != null) session.Close();
                return new List<Formas_pagamento>();
            }
        } 

        public static bool Salvar(Formas_pagamento fpg)
        {
            if (!Validar(fpg)) return false;

            Session session = null;

            try
            {
                session = new ConfigureSession().GetSession();

                if(EntidadeController.Existe(fpg, "id", fpg.Id.ToString()))
                {
                   session.Update(fpg);
                   Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Forma de pagamento atualizada.");
                }
                else
                {
                    session.Save(fpg);
                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Forma de pagamento salva.");
                }

                session.Close();

                return true;

            }
            catch(Exception ex)
            {
                Log.Write("Formas_pagamentoController", "Salvar", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                if (session != null) session.Close();

                return false;
            }
        }

        private static bool Validar(Formas_pagamento fpg)
        {
            if(string.IsNullOrWhiteSpace(fpg.Descricao))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "A descrição da forma de pagamento não pode estar vazia.");
                return false;
            }

            if(fpg.Parcelado)
            {
                if(fpg.Maximo_parcelas == 0 && !fpg.Utiliza_operadora)
                {
                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O numero de parcelas deve ser igual ou maior que 1");
                    return false;
                }

                if(fpg.Prazo_pagamento == 0 & !fpg.Utiliza_operadora)
                {
                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O prazo para pagamento deve ser igual ou maior que 1");
                    return false;
                }
            }

            return true;
        }
    }
}
