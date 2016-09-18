using DBX.Entities;
using DBX_VisualClient.SERVICE;
using DBXConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class Log
    {
        public static void Configurar()
        {
            try
            {
                DBXConnection conn = new DBXConnection();
                conn.Configure("localhost", "PF", "LOG");
            }
            catch (Exception ex)
            {

            }
        }

        public static void Write(string controller, string metodo, string mensagem)
        {
            try
            {
                string commandText = "insert into eventos(data, controller, metodo, descricao) values ('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + controller + "', '" + metodo + "', '" + mensagem + "')";
                DBXCommand cmd = new DBXCommand();
                cmd.Execute(commandText);
                ResponseObject ro = ClientService.ReceiveResponse();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
