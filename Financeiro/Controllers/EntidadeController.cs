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
