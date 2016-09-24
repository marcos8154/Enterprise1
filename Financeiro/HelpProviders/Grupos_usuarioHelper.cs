using Financeiro.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Financeiro.HelpProviders
{
    public class Grupos_usuarioHelper
    {
        public Grupos_usuarioHelper()
        {
            string file = Directory.GetCurrentDirectory() + @"\Help\4745475.hlp";

            byte[] b = File.ReadAllBytes(file);
            string text = Encoding.Default.GetString(b);

            DataTable dt = DefaultDtHlp.GetDefaultDataTable();
            dt.Rows.Add("Nome", "Texto", 100, "Sim", "Denominação do grupo de usuários");

            new Help(text, dt);            
        }
    }
}
