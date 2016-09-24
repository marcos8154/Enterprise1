using Entidades;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro.Controllers
{
    public class RotinasController
    {
        static string controllerName = "RotinasController";

        public static List<Rotinas> Listar()
        {
            Session session = null;
            try
            {
                Rotinas rotinas = new Rotinas();
                session = new ConfigureSession().GetSession();
                session.ReadAll(rotinas);
                session.Close();
                return session.GetList(rotinas);
            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Alerta(ex.Message);
                Log.Write(controllerName, "Listar", ex.Message);

                return new List<Rotinas>();
            }
        }
    }
}
