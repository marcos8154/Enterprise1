using DevComponents.DotNetBar;
using Financeiro.Extencoes;
using System.Windows.Forms;
using System;
using Financeiro.UserControls;
using Financeiro.Controllers;
using Financeiro.Enums;
using Financeiro.Interfaces;
using Entidades;
using Financeiro.UserControls.MdlAdministracao.Consultas;
using Financeiro.UserControls.MdlFinanceiro.Consultas;
using Financeiro.Forms;

namespace Financeiro
{
    public partial class Home : Form
    {
        string desc = string.Empty;
        int count_desc = 0;

        WindowManager windowManager = new WindowManager();

        public Home()
        {
            InitializeComponent();

            windowManager.menuJanela = menuJanela;
            Notificacao.Inicializar(imgIconeNotificacao, lbNotificacao);
        }

        private void mdlAdministracao_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            if (mdlAdministracao.Expanded)
            {
                mdlFinanceiro.Visible = false;
                mdlVendas.Visible = false;
            }
            else
            {
                mdlFinanceiro.Visible = true;
                mdlVendas.Visible = true;
            }
        }

        private void mdlFinanceiro_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            if (mdlFinanceiro.Expanded)
            {
                mdlVendas.Visible = false;
                mdlCompras.Visible = false;
                mdlEstoque.Visible = false;
                mdlPessoas.Visible = false;
            }
            else
            {
                mdlVendas.Visible = true;
                mdlCompras.Visible = true;
                mdlEstoque.Visible = true;
                mdlPessoas.Visible = true;
            }
        }

        private void mdlVendas_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            if (mdlVendas.Expanded)
            {
                mdlCompras.Visible = false;
                mdlEstoque.Visible = false;
                mdlPessoas.Visible = false;
            }
            else
            {
                mdlCompras.Visible = true;
                mdlEstoque.Visible = true;
                mdlPessoas.Visible = true;
            }
        }

        private void mdlCompras_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            if (mdlCompras.Expanded)
            {
                mdlEstoque.Visible = false;
                mdlPessoas.Visible = false;
            }
            else
            {
                mdlEstoque.Visible = true;
                mdlPessoas.Visible = true;
            }
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            IManagedUserControl muc = new UC_Usuarios();
            windowManager.AddOrShow(muc, "Usuários", "UC_USR-4575", false);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            windowManager.SaveState();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowManager.Cascade();
        }

        private void fecharTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowManager.CloseAll();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            windowManager.RestoreState();
        }

        private void btTiposMov_Click(object sender, EventArgs e)
        {
            IManagedUserControl muc = new UC_TiposMovimento();
            windowManager.AddOrShow(muc, "Tipos de movimento", "UC_TMV-45754", false);
        }

        private void minimizarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowManager.MinimizeAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preparando p = new Preparando();
            p.TopMost = true;
            p.Show();
            p.pregresso.Maximum = 100;
            p.pregresso.Value = 50;
        }
    }
}
