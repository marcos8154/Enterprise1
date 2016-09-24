using Financeiro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro.UserControls
{
    public static class Defaults
    {
        public static void OnRestore(this UserControl userC, BarraTarefas barra, int id)
        {
            userC.Enabled = false;
            barra.Bt_Excel(false);
            if (id == 0)
            {
                barra.Bt_Excluir(false);
                barra.Bt_Editar(false);
                barra.Bt_Salvar(false);
                barra.Bt_Novo(true);
                return;
            }
            
            barra.Bt_Excluir(true);
            barra.Bt_Editar(true);
            barra.Bt_Salvar(false);
            barra.Bt_Novo(true);
        }
    }
}
