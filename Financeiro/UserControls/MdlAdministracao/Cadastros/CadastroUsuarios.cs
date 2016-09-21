using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Financeiro.Controllers;

namespace Financeiro.UserControls.MdlAdministracao.Cadastros
{
    public partial class CadastroUsuarios : UserControl
    {
        int id_usuario = 0;
        //Teste
        public CadastroUsuarios(int id_usuario = 0)
        {
            InitializeComponent();

            if(id_usuario != 0)
            {
                this.id_usuario = id_usuario;
                Carregar();
            }
        }

        private void Carregar()
        {
            Usuarios usuario = UsuariosController.Carregar(id_usuario);

            txNome.Text = usuario.Nome;
            txEmail.Text = usuario.Email_rec;
            txSenha.Text = usuario.Senha;
            ckAtivo.Checked = usuario.Ativo;
        }

        private void yellowButton2_Yb_Click()
        {
            Usuarios usuario = new Usuarios();

            usuario.Id = this.id_usuario;
            usuario.Nome = txNome.Text;
            usuario.Email_rec = txEmail.Text;
            usuario.Senha = txSenha.Text;
            usuario.Ativo = ckAtivo.Checked;

            Permissoes perm = UsuariosController.CarregarPermissoes(id_usuario);
            perm.Usuarios_id = usuario.Id;

            if (UsuariosController.Salvar(usuario, perm)) (Parent as Form).Close();
        }

        private void yellowButton1_Yb_Click()
        {
            (Parent as Form).Close();
        }
    }
}
