using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Financeiro.HelpProviders
{
    public class DefaultDtHlp
    {
        public static DataTable GetDefaultDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Campo");
            dt.Columns.Add("Tipo de dado");
            dt.Columns.Add("Tamanho máximo");
            dt.Columns.Add("Obrigatório");
            dt.Columns.Add("Descrição");
            return dt;
        }
    }
}
