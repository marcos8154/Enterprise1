using DevComponents.DotNetBar;
using Financeiro.Extencoes;
using System.Windows.Forms;
using System;
using Financeiro.UserControls;
using Financeiro.Controllers;
using Financeiro.Enums;
using Financeiro.Interfaces;
using Entidades;
using Financeiro.Forms;
using Financeiro.UserControls.MdlAdministracao.Cadastros;

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
            IManagedUserControl muc = new CadastroUsuarios();
            windowManager.AddOrShow(muc, "Usuários", "UC_USR-4575", false);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            NonManagedWindows.CloseAll();
            windowManager.SaveState();
            windowManager.CloseAll(true);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowManager.Cascade();
        }

        private void fecharTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowManager.CloseAll(true);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            windowManager.menuJanela = menuJanela;
            windowManager.BarraTarefas = barraTarefas;
            Notificacao.Inicializar(imgIconeNotificacao, lbNotificacao, lbTela);
            NonManagedWindows.Initialize();
            NonManagedWindows.WindowManager = windowManager;
           // windowManager.RestoreState();
        }

        private void btTiposMov_Click(object sender, EventArgs e)
        {
          //  IManagedUserControl muc = new UC_TiposMovimento();
           //  windowManager.AddOrShow(muc, "Tipos de movimento", "UC_TMV-45754", false);
        }

        private void minimizarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowManager.MinimizeAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            IManagedUserControl muc = new CadastroEmpresa();
            windowManager.AddOrShow(muc, "Empresas", "UC_EMPR-4487", false);
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
        }

        private void btAbrirBusca_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.Find();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.New();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.Edit();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.Save();
        }

        private void btPrimeiroRegistro_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.First();
        }

        private void btRegistroAnterior_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.Previous();
        }

        private void btProximoRegistro_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.Next();
        }

        private void btUltimoRegistro_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.Last();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.Delete();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            windowManager.CurrentUserControl.OnReload();
        }
    }
}
