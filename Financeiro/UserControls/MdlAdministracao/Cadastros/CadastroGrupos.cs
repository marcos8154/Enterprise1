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
using Financeiro.Enums;
using Financeiro.Interfaces;
using Financeiro.Extencoes;
using Financeiro.HelpProviders;
using Financeiro.Util;

namespace Financeiro.UserControls.MdlAdministracao.Cadastros
{
    public partial class CadastroGrupos : UserControl, IManagedUserControl
    {
        int Id_atual = 0;
        int ultima_id = 0;
        int primeira_id = 0;

        public CadastroGrupos()
        {
            InitializeComponent();
            dataGrid.AplicarPadroes();
        }

        private void CarregaPermissoes()
        {
            dataGrid.ReadOnly = false;
            dataGrid.Columns["codigo"].ReadOnly = true;
            dataGrid.Columns["rotina"].ReadOnly = true;
            dataGrid.Columns["acesso"].ReadOnly = false;
            dataGrid.Columns["inserir"].ReadOnly = false;
            dataGrid.Columns["alterar"].ReadOnly = false;
            dataGrid.Columns["excluir"].ReadOnly = false;

            dataGrid.Rows.Clear();
            List<Permissoes> perm = Grupos_usuariosController.Permissoes(Id_atual);

            foreach (Permissoes p in perm)
            {
                Rotinas r = Grupos_usuariosController.Rotina(p.Rotina_id);
                dataGrid.Rows.Add(r.Codigo, r.Nome, p.Acesso, p.Inserir, p.Alterar, p.Excluir);
            }
        }

        private bool Carregar()
        {
            Grupos_usuarios grupo = Grupos_usuariosController.Carregar(Id_atual);
            if (grupo.Id == 0) return false;
            CarregaPermissoes();
            txNome.Text = grupo.Descricao;
            BarraTarefas.Bt_Salvar(false);
            BarraTarefas.Bt_Editar(true);
            BarraTarefas.Bt_Excluir(true);
            return true;
        }

        public BarraTarefas BarraTarefas { get; set; }

        public UserControl CURRENT
        {
            get
            {
                return this;
            }
        }

        public DataGridView DataGridView
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string WindowID { get; set; }
        public object Grupos_usuariosHelper { get; private set; }

        public void Delete()
        {
            Permissoes p = UsuariosController.CarregarPermissoes(Rotina.Grupos_usuarios);
            if(!p.Excluir)
            {
                Notificacao.Alerta("Solicitação negada.");
                return;
            }

            if(new Confirmacao("Esta ação não poderá ser revertida. Deseja realmente excluír o grupo?").Result)
            {
                if(Grupos_usuariosController.Excluir(Id_atual))
                {
                    CarregaId();
                    Last();
                }
            }
        }

        public void Edit()
        {
            this.Enabled = true;
            dataGrid.ReadOnly = false;
            BarraTarefas.Bt_Salvar(true);
        }

        public void Find()
        {
            // throw new NotImplementedException();
        }

        public void First()
        {
            Grupos_usuarios grupo = new Grupos_usuarios();
            Id_atual = ((Grupos_usuarios)EntidadeController.Primeiro_id(grupo)).Id;
            Carregar();
        }

        public void Help()
        {
            new Grupos_usuarioHelper();
        }

        public bool IsValid()
        {
            Permissoes p = UsuariosController.CarregarPermissoes(Rotina.Grupos_usuarios);
            return p.Acesso;
        }

        public void Last()
        {
            Grupos_usuarios grupo = new Grupos_usuarios();
            Id_atual = ((Grupos_usuarios)EntidadeController.Ultimo_id(grupo)).Id;
            Carregar();
        }

        public void New()
        {
            this.Enabled = true;
            Id_atual = 0;
            txNome.Text = string.Empty;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                row.Cells["acesso"].Value = false;
                row.Cells["inserir"].Value = false;
                row.Cells["alterar"].Value = false;
                row.Cells["excluir"].Value = false;
            }

            BarraTarefas.Bt_Salvar(true);
        }

        public void Next()
        {
            Id_atual++;
            if (Id_atual > ultima_id && ultima_id != 0) Id_atual = ultima_id;
            if (!Carregar()) Next();
        }

        public void Previous()
        {
            Id_atual--;
            if (Id_atual < primeira_id) Id_atual = primeira_id;
            if (Id_atual == 0) Id_atual = 1;
            if (!Carregar()) Previous();
        }

        public void OnLoad()
        {
            this.Enabled = false;
            List<Rotinas> lista = RotinasController.Listar();
            BarraTarefas.Bt_Salvar(false);
            BarraTarefas.Bt_Excluir(false);
            BarraTarefas.Bt_Editar(false);
            BarraTarefas.Bt_Buscar(false);
            BarraTarefas.Bt_Excel(false);

            dataGrid.ReadOnly = false;
            dataGrid.Columns["codigo"].ReadOnly = true;
            dataGrid.Columns["rotina"].ReadOnly = true;
            dataGrid.Columns["acesso"].ReadOnly = false;
            dataGrid.Columns["inserir"].ReadOnly = false;
            dataGrid.Columns["alterar"].ReadOnly = false;
            dataGrid.Columns["excluir"].ReadOnly = false;

            foreach (Rotinas r in lista)
            {
                dataGrid.Rows.Add(r.Id, r.Nome, false, false, false, false);
            }

            CarregaId();
        }

        private void CarregaId()
        {
            Grupos_usuarios grupo = new Grupos_usuarios();
            primeira_id = ((Grupos_usuarios)EntidadeController.Primeiro_id(grupo)).Id;
            ultima_id = ((Grupos_usuarios)EntidadeController.Ultimo_id(grupo)).Id;
        }

        public void OnReload()
        {
            if (Id_atual != 0)
                Carregar();
        }

        public void OnRestore()
        {
            BarraTarefas.Bt_Excel(false);
            BarraTarefas.Bt_Buscar(false);
            if (Id_atual == 0)
            {
                BarraTarefas.Bt_Excluir(false);
                BarraTarefas.Bt_Editar(false);
                BarraTarefas.Bt_Salvar(this.Enabled);
                BarraTarefas.Bt_Novo(true);
                return;
            }
            BarraTarefas.Bt_Excluir(true);
            BarraTarefas.Bt_Editar(true);
            BarraTarefas.Bt_Salvar(this.Enabled);
            BarraTarefas.Bt_Novo(true);
        }

        public void Save()
        {
            Grupos_usuarios grupo = new Grupos_usuarios();
            grupo.Id = Id_atual;
            grupo.Descricao = txNome.Text;

            List<Permissoes> p = new List<Permissoes>();

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                Permissoes permissao = new Permissoes();

                permissao.Rotina_id = int.Parse(row.Cells["codigo"].Value.ToString());
                permissao.Acesso = (bool)row.Cells["acesso"].Value;
                permissao.Inserir = (bool)row.Cells["inserir"].Value;
                permissao.Alterar = (bool)row.Cells["alterar"].Value;
                permissao.Excluir = (bool)row.Cells["excluir"].Value;

                p.Add(permissao);
            }

            if (Grupos_usuariosController.Salvar(grupo, p))
            {
                this.Enabled = false;
                BarraTarefas.Bt_Salvar(false);
                BarraTarefas.Bt_Editar(true);
                Id_atual = grupo.Id;
                Last();

                CarregaId();
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
