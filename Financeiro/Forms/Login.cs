using Entidades;
using Financeiro.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Log.Configurar();
          
            List<Usuarios> usuarios = UsuariosController.Listar("");

            if(usuarios.Count == 0)
            {
             
                Usuarios usuario = new Usuarios();

                usuario.Nome = "Admin";
                usuario.Senha = "12345678";

                Permissoes permissoes = new Permissoes();
                permissoes.Admin = true;

                UsuariosController.Salvar(usuario, permissoes);
            }

            txUsuario.Focus();
        }

        private void txSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Logon();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Logon()
        {
            this.Visible = false;

            if (UsuariosController.EfetuaLogin(txUsuario.Text, txSenha.Text))
            {
                Home home = new Home();
                this.Hide();
                home.ShowDialog();
            }

            txUsuario.Text = string.Empty;
            txSenha.Text = string.Empty;
            txUsuario.Focus();
            this.Visible = true;
            txUsuario.Focus();
        }

        private void txUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txSenha.Focus();
        }

        private void btOk_Yb_Click()
        {
            Logon();
        }

        private void btCancelar_Yb_Click()
        {
            System.Environment.Exit(0);
        }
    }
}
