using Financeiro.Controllers;
using Persistor.Persistence;
using Persistor_GA.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.SessionProvider
{
    public class ConfigureSession
    {
        public Session GetSession()
        {
             Session session = new Session(EnvironmentController.Config);
            return session;
        }
    }
}
