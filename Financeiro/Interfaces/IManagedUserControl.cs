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

        void Find();

        void New();

        void Save();

        void Delete();

        void Edit();

        void First();

        void Previous();

        void Next();

        void Last();

        void Help();

        void OnRestore();

        void OnLoad();

        void OnReload();

        BarraTarefas BarraTarefas { get; set; }
    }
}
