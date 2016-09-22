using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Financeiro.Controllers;
using Entidades;
using Financeiro.Extencoes;

namespace Financeiro.UserControls.MdlAdministracao.Consultas
{
    public partial class BuscarEmpresa : UserControl
    {
        public BuscarEmpresa()
        {
            InitializeComponent();
            dataGridEmpr.AplicarPadroes();
            Carregar();
        }
        
        public void Carregar(string busca = "")
        {
            dataGridEmpr.Rows.Clear();
            List<Empresa> lista = EmpresaController.Listar(busca);

            foreach(Empresa e in lista)
            {
                Enderecos endereco = EnderecosController.Carregar(e.Enderecos_id);
                dataGridEmpr.Rows.Add(e.Id, e.Nome_fantasia, e.Razao_social, e.CNPJ, e.Telefone1, e.Telefone2, e.Celular, e.Email, endereco.Municipio);
            }
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Carregar(txPesquisa.Text);
            }
        }

        public int Id_selecionado { get; set; }

        private void dataGridEmpr_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridEmpr.CurrentRow == null || dataGridEmpr.Rows.Count == 0) return;

            int id = int.Parse(dataGridEmpr.CurrentRow.Cells[0].Value.ToString());
            Id_selecionado = id;
            (Parent as Form).Close();
        }

        private void yellowButton1_Yb_Click()
        {
            (Parent as Form).Close();
        }
    }
}
