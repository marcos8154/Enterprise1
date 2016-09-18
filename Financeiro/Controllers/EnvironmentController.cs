using Persistor_GA.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class EnvironmentController
    {
        public static DBConfig Config { get; set; }
    }
}
