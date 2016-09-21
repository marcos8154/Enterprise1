using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro.Interfaces
{
    public class BarraTarefas
    {
        private ToolStrip barraTarefas;

        public BarraTarefas(ToolStrip barraTarefas)
        {
            this.barraTarefas = barraTarefas;
        }


        public void Bt_Excel(bool habilitado)
        {
            SetEnabled("btExportarExcel", habilitado);
        }

        public void Bt_Buscar(bool habilitado)
        {
            SetEnabled("btAbrirBusca", habilitado);
        }

        public void Bt_Novo(bool habilitado)
        {
            SetEnabled("btNovo", habilitado);
        }

        public void Bt_Editar(bool habilitado)
        {
            SetEnabled("btEditar", habilitado);
        }

        public void Bt_Salvar(bool habilitado)
        {
            SetEnabled("btSalvar", habilitado);
        }

        public void Bt_Primeiro(bool habilitado)
        {
            SetEnabled("btPrimeiroRegistro", habilitado);
        }

        public void Bt_Anterior(bool habilitado)
        {
            SetEnabled("btRegistroAnterior", habilitado);
        }

        public void Bt_Proximo(bool habilitado)
        {
            SetEnabled("btProximoRegistro", habilitado);
        }

        public void Bt_Ultimo(bool habilitado)
        {
            SetEnabled("btUltimoRegistro", habilitado);
        }

        public void Bt_Excluir(bool habilitado)
        {
            SetEnabled("btExcluir", habilitado);
        }

        private void SetEnabled(string itemName, bool enabled)
        {
            foreach (ToolStripButton item in barraTarefas.Items)
            {
                if (item.Name == itemName) item.Enabled = enabled;
            }
        }
    }
}
