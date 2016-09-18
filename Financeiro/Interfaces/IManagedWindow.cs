using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Interfaces
{
    public interface IManagedWindow
    {
        string WindowID { get; set; }

        Form CURRENT_FORM { get; }

        IManagedUserControl ManagedUserControl { get; }

        bool Sizable { get; set; }

        string Title { get; set; }
    }
}
