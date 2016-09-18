using Entidades;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class DocumentosController
    {
        private static string controllerName = "DocumentosController";

        public static Documentos Carregar(int id_doc)
        {
            Session session = null;
            try
            {
                Documentos documento = new Documentos();

                session = new ConfigureSession().GetSession();
                session.OnID(documento, id_doc);
                session.Close();

                return documento;

            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Carregar", ex.Message);
                return null;
            }
        }
    }
}
