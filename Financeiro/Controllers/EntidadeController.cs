using Financeiro.SessionProvider;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class EntidadeController
    {
        public static Object Ultimo_id(Object entidade)
        {
            Session session = null;

            try
            {
                
                session = new ConfigureSession().GetSession();
                session.LastRecord(entidade);
                session.Close();

                return entidade;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                return entidade;
            }
        }

        public static Object Primeiro_id(Object entidade)
        {
            Session session = null;

            try
            {
                session = new ConfigureSession().GetSession();
                session.FirstRecord(entidade);
                session.Close();

                return entidade;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                return entidade;
            }
        }

        public static bool Existe(Object entidade, string campo, string valor)
        {
            Session session = new ConfigureSession().GetSession();
            bool result = false;
            if(session.Contains(entidade, campo, valor)) result = true;
            session.Close();
            return result;
        }
    }
}
