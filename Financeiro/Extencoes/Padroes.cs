using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Financeiro.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Extencoes
{
    public static class Padroes
    {
        public static void AplicarPadroes(this DataGridViewX dataGrid)
        {
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.RowHeadersVisible = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.Cursor = Cursors.Hand;
            dataGrid.MultiSelect = false;
            dataGrid.ReadOnly = true;
        }
    }
}
