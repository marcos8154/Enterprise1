using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Financeiro.Interfaces;
using Entidades;
using Financeiro.Controllers;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using Financeiro.Util;
using Financeiro.UserControls.MdlAdministracao.Consultas;
using Financeiro.Forms;

namespace Financeiro.UserControls.MdlAdministracao.Cadastros
{
    public partial class CadastroEmpresa : UserControl, IManagedUserControl
    {
        private int Id_atual = 0;
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        public void OnLoad()
        {
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.SelectedIndex = 0;
            CarregaId();
            this.Enabled = false;
            BarraTarefas.Bt_Salvar(false);
            BarraTarefas.Bt_Excel(false);
        }

        private void CarregaId()
        {
            ultima_id = EmpresaController.GetID(Enums.ORDEM.ULTIMO);
            primeira_id = EmpresaController.GetID(Enums.ORDEM.PRIMEIRO);
        }

        public UserControl CURRENT { get { return this; } }

        public DataGridView DataGridView { get; set; }

        public string WindowID { get; set; }

        public BarraTarefas BarraTarefas { get; set; }

        public void Edit()
        {
            Permissoes p = UsuariosController.CarregarPermissoes(Enums.Rotina.Empresa);
            if (!p.Alterar)
            {
                Notificacao.Alerta("Solicitação negada.");
                return;
            }

            if (Id_atual == 0) return;
            BarraTarefas.Bt_Editar(false);
            BarraTarefas.Bt_Salvar(true);
            this.Enabled = true;
        }

        public void Find()
        {
            BuscarEmpresa be = new BuscarEmpresa();
            new BaseWindow(be, "Buscar empresa");

            if (be.Id_selecionado != 0)
            {
                Id_atual = be.Id_selecionado;
                Carregar();
                Edit();
            }
        }

        public void Help()
        {
        }

        public void Delete()
        {
            Permissoes p = UsuariosController.CarregarPermissoes(Enums.Rotina.Empresa);
            if (!p.Excluir)
            {
                Notificacao.Alerta("Solicitação negada.");
                return;
            }

            string msg = "Esta ação não poderá ser revertida. Excluír a empresa mesmo assim?";
            if (new Confirmacao(msg).Result)
            {
                if (EmpresaController.Excluir(Id_atual))
                {
                    Id_atual = 0;
                    CarregaId();
                    First();
                    IMucController.LimparCampos(this);
                }
            }
        }

        public bool IsValid()
        {
            Permissoes p = UsuariosController.CarregarPermissoes(Enums.Rotina.Empresa);
            return p.Acesso;
        }

        int ultima_id = 0;
        int primeira_id = 0;

        public void First()
        {
            Id_atual = EmpresaController.GetID(Enums.ORDEM.PRIMEIRO);
            primeira_id = Id_atual;
            Carregar();
        }

        public void Last()
        {
            Id_atual = EmpresaController.GetID(Enums.ORDEM.ULTIMO);
            ultima_id = Id_atual;
            Carregar();
        }

        public void New()
        {
            Permissoes p = UsuariosController.CarregarPermissoes(Enums.Rotina.Empresa);
            if (!p.Inserir)
            {
                Notificacao.Alerta("Solicitação negada.");
                return;
            }

            this.Enabled = true;
            IMucController.LimparCampos(this);
            BarraTarefas.Bt_Salvar(true);
            BarraTarefas.Bt_Excluir(false);
            Id_atual = 0;
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

        private bool Carregar()
        {
            this.Enabled = false;
            Empresa empresa = EmpresaController.Carregar(Id_atual);
            txNome_f.Text = empresa.Nome_fantasia;
            txRazao_s.Text = empresa.Razao_social;
            txCNPJ.Text = empresa.CNPJ;
            txTel1.Text = empresa.Telefone1;
            txTel2.Text = empresa.Telefone2;
            txCel.Text = empresa.Celular;
            txResponsavel.Text = empresa.Responsavel;
            txEmail.Text = empresa.Email;
            cbTipo.SelectedIndex = empresa.Tipo;

            Enderecos endereco = EnderecosController.Carregar(empresa.Enderecos_id);
            ExibeEndereco(endereco);

            BarraTarefas.Bt_Salvar(false);
            BarraTarefas.Bt_Editar(true);
            OnRestore();
            return (empresa.Id == 0 ? false : true);
        }

        private void ExibeEndereco(Enderecos endereco)
        {
            txCEP.Text = endereco.CEP;
            txBairro.Text = endereco.Bairro;
            txMun.Text = endereco.Municipio;
            txUF.Text = endereco.UF;
            txNumero.Value = endereco.Numero;
            txLogradouro.Text = endereco.Logradouro;
            txCompl.Text = endereco.Complemento;
            //  if (!string.IsNullOrEmpty(endereco.Logradouro)) txNumero.Focus(); ;
        }

        public void Save()
        {
            Empresa empresa = EmpresaController.Carregar(Id_atual);

            empresa.Id = Id_atual;
            empresa.Nome_fantasia = txNome_f.Text;
            empresa.Razao_social = txRazao_s.Text;
            empresa.Responsavel = txResponsavel.Text;
            empresa.Telefone1 = txTel1.Text;
            empresa.Telefone2 = txTel2.Text;
            empresa.Celular = txCel.Text;
            empresa.Email = txEmail.Text;
            empresa.CNPJ = txCNPJ.Text;
            empresa.Tipo = cbTipo.SelectedIndex;
            empresa.Ativo = ckAtivo.Checked;

            Enderecos endereco = new Enderecos();
            endereco.Id = empresa.Enderecos_id;
            endereco.CEP = txCEP.Text;
            endereco.Logradouro = txLogradouro.Text;
            endereco.Bairro = txBairro.Text;
            endereco.Municipio = txMun.Text;
            endereco.UF = txUF.Text;
            endereco.Numero = txNumero.Value;
            endereco.Complemento = txCompl.Text;

            if (EmpresaController.Salvar(empresa, endereco))
            {
                this.Enabled = false;
                BarraTarefas.Bt_Salvar(false);
                BarraTarefas.Bt_Editar(true);
                Id_atual = empresa.Id;
                Last();

                CarregaId();
            }
        }

        private void btSalvar_Yb_Click()
        {
            Save();
        }

        public void OnRestore()
        {
            BarraTarefas.Bt_Excel(false);
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

        public void OnReload()
        {
            Carregar();
        }

        private void txCEP_Leave(object sender, EventArgs e)
        {
            Enderecos endereco = EnderecosController.CarregarPorCEP(txCEP.Text);
            ExibeEndereco(endereco);
        }

        private void btCancelar_Yb_Click()
        {
            (Parent as Form).Close();
        }
    }
}
