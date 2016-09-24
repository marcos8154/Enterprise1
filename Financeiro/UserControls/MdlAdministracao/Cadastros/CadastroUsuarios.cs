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
using Financeiro.Interfaces;
using Financeiro.Extencoes;

namespace Financeiro.UserControls.MdlAdministracao.Cadastros
{
    public partial class CadastroUsuarios : UserControl, IManagedUserControl
    {
        int id_atual = 0;
        int primeiro_id = 0;
        int ultimo_id = 0;

        public CadastroUsuarios()
        {
            InitializeComponent();

            dataGridPerm.AplicarPadroes();
        }

        public DataGridView DataGridView { get; set; }

        public UserControl CURRENT
        {
            get
            {
                return this;
            }
        }

        public string WindowID { get; set; }

        public BarraTarefas BarraTarefas { get; set; }

        public bool IsValid()
        {
            //Permissoes p = UsuariosController.CarregarPermissoes(UsuariosController.UsuarioLogado.Id);
            return true;
         //   return p.Admin;
        }

        public void Find()
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            this.Enabled = true;
            IMucController.LimparCampos(this);
            BarraTarefas.Bt_Salvar(true);
            BarraTarefas.Bt_Editar(false);
        }

        public void Save()
        {
            Usuarios usuario = new Usuarios();

            usuario.Id = this.id_atual;
            usuario.Nome = txNome.Text;
            usuario.Email_rec = txEmail.Text;
            usuario.Senha = txSenha.Text;
            usuario.Ativo = ckAtivo.Checked;

          //  Permissoes perm = UsuariosController.CarregarPermissoes(id_atual);
          //  perm.Usuarios_id = usuario.Id;

          //  if (UsuariosController.Salvar(usuario, perm)) (Parent as Form).Close();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void First()
        {
            throw new NotImplementedException();
        }

        public void Previous()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Last()
        {
            throw new NotImplementedException();
        }

        public void Help()
        {
            throw new NotImplementedException();
        }

        public void OnRestore()
        {
           this.OnRestore(BarraTarefas, id_atual);
        }

        public void OnLoad()
        {
            CarregaId();
        }

        public void OnReload()
        {
            Carregar();
        }

        private void yellowButton1_Yb_Click()
        {
            (Parent as Form).Close();
        }

        private void CarregaId()
        {
            Usuarios primeiro = new Usuarios();
            Usuarios ultimo = new Usuarios();
            primeiro_id = ((Usuarios)EntidadeController.Primeiro_id(primeiro)).Id;
            ultimo_id = ((Usuarios)EntidadeController.Ultimo_id(ultimo)).Id;
        }

        private void Carregar()
        {
            Usuarios usuario = UsuariosController.Carregar(id_atual);

            txNome.Text = usuario.Nome;
            txEmail.Text = usuario.Email_rec;
            txSenha.Text = usuario.Senha;
            ckAtivo.Checked = usuario.Ativo;
        }

        private void yellowButton2_Yb_Click()
        {
            Save();
        }
    }
}
