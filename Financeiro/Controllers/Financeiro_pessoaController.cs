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
    public class Financeiro_pessoaController
    {
        static string controllerName = "Financeiro_pessoaController";

        public static Financeiro_pessoa Carregar(int fp_id)
        {
            Session session = null;
            try
            {
                Financeiro_pessoa fp = new Financeiro_pessoa();

                session = new ConfigureSession().GetSession();
                session.OnID(fp, fp_id);
                session.Close();

                return fp;

            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Carregar", ex.Message);
                return null;
            }
        }
    }
}
