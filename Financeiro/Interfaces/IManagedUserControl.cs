using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Interfaces
{
    public interface IManagedUserControl
    {
        DataGridView DataGridView { get; }

        UserControl CURRENT { get; }

        string WindowID { get; set; }

        bool IsValid();
    }
}
