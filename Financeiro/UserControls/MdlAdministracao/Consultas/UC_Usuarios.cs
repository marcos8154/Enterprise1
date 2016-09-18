using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financeiro.Extencoes;
using Financeiro.Interfaces;
using Financeiro.Controllers;
using Entidades;
using Financeiro.Util;

namespace Financeiro.UserControls.MdlAdministracao.Consultas
{
    public partial class UC_Usuarios : UserControl, IManagedUserControl
    {
        public UC_Usuarios()
        {
            InitializeComponent();

            dataGridPermissoes.AplicarPadroes(false);
            dataGridUsuarios.AplicarPadroes();

            CarregaPermissoes();
            CarregarUsuarios();
        }

        private void CarregarUsuarios(string busca = "")
        {
            dataGridUsuarios.Rows.Clear();

            List<Usuarios> lista = UsuariosController.Listar(busca, ckInativos.Checked);

            foreach (Usuarios u in lista)
            {
                dataGridUsuarios.Rows.Add(u.Id, u.Nome, u.Email_rec);
            }
        }

        private void CarregaPermissoes()
        {
            dataGridPermissoes.Rows.Clear();
            if (dataGridUsuarios.CurrentRow == null || dataGridUsuarios.Rows.Count == 0) return;

            int id = int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString());
            Permissoes permissoes = UsuariosController.CarregarPermissoes(id);

            dataGridPermissoes.Rows.Add("Admin", "Administrador", permissoes.Admin);
            dataGridPermissoes.Rows.Add("Movimentos_acesso", "Movimentos - Acesso", permissoes.Movimentos_acesso);
            dataGridPermissoes.Rows.Add("Movimentos_incluir", "Movimentos - Incluír", permissoes.Movimentos_incluir);
            dataGridPermissoes.Rows.Add("Formas_pg_acesso", "Formas de pagamento - Acesso", permissoes.Formas_pg_acesso);
            dataGridPermissoes.Rows.Add("Formas_pg_incluir", "Formas de pagamento - Incluir", permissoes.Formas_pg_incluir);
            dataGridPermissoes.Rows.Add("Formas_pg_alt", "Formas de pagamento - Alterar", permissoes.Formas_pg_alt);
            dataGridPermissoes.Rows.Add("Formas_pg_excl", "Formas de pagamento - Excluir", permissoes.Formas_pg_excl);
            dataGridPermissoes.Rows.Add("Cxa_abrir", "Caixa - Abrir", permissoes.Cxa_abrir);
            dataGridPermissoes.Rows.Add("Cxa_fechar", "Caixa - Fechar", permissoes.Cxa_fechar);
            dataGridPermissoes.Rows.Add("Cxa_retirada", "Caixa - Efetuar retirada", permissoes.Cxa_retirada);
            dataGridPermissoes.Rows.Add("Situacao_clientes_acesso", "Situação de clientes - Acesso", permissoes.Situacao_clientes_acesso);
            dataGridPermissoes.Rows.Add("Comissao_vendedores_acesso", "Totais em comissão por vendedor - Acesso", permissoes.Comissao_vendedores_acesso);
            dataGridPermissoes.Rows.Add("Ped_vnd_acesso", "Pedidos de venda - Acesso", permissoes.Ped_vnd_acesso);
            dataGridPermissoes.Rows.Add("Ped_vnd_incluir", "Pedidos de venda - Incluír", permissoes.Ped_vnd_incluir);
            dataGridPermissoes.Rows.Add("Ped_vnd_alt", "Pedidos de venda - Alterar", permissoes.Ped_vnd_alt);
            dataGridPermissoes.Rows.Add("Ped_vnd_excl", "Pedidos de venda - Excluír", permissoes.Ped_vnd_excl);
            dataGridPermissoes.Rows.Add("Ped_compra_acesso", "Pedidos de compra - Acesso", permissoes.Ped_compra_acesso);
            dataGridPermissoes.Rows.Add("Ped_compra_incluir", "Pedidos de compra - Incluir", permissoes.Ped_compra_incluir);
            dataGridPermissoes.Rows.Add("Ped_compra_baixa", "Pedidos de compra - Baixa", permissoes.Ped_compra_baixa);
            dataGridPermissoes.Rows.Add("Devolucao_acesso", "Devoluções - Acesso", permissoes.Devolucao_acesso);
            dataGridPermissoes.Rows.Add("Devolucao_efetuar", "Devoluções - Efetuar", permissoes.Devolucao_efetuar);
            dataGridPermissoes.Rows.Add("Cad_item_acesso", "Cadastro de produtos - Acesso", permissoes.Cad_item_acesso);
            dataGridPermissoes.Rows.Add("Cad_item_incluir", "Cadastro de produtos - Incluir", permissoes.Cad_item_incluir);
            dataGridPermissoes.Rows.Add("Cadastro_item_alterar", "Cadastro de produtos - Alterar", permissoes.Cadastro_item_alterar);
            dataGridPermissoes.Rows.Add("Entrada_item_acesso", "Entrada de estoque - Acesso", permissoes.Entrada_item_acesso);
            dataGridPermissoes.Rows.Add("Saida_item_acesso", "Saída de estoque - Acesso", permissoes.Saida_item_acesso);
            dataGridPermissoes.Rows.Add("Pessoas_acesso", "Cadastro de pessoas - Acesso", permissoes.Pessoas_acesso);
            dataGridPermissoes.Rows.Add("Cad_pessoas_incluir", "Cadastro de pessoas - Incluir", permissoes.Cad_pessoas_incluir);
            dataGridPermissoes.Rows.Add("Cad_pessoas_alterar", "Cadastro de pessoas - Alterar", permissoes.Cad_pessoas_alterar);
            dataGridPermissoes.Rows.Add("Cad_pessoas_excluir", "Cadastro de pessoas - Excluir", permissoes.Cad_pessoas_excluir);
        }

        public DataGridView DataGridView
        {
            get { throw new NotImplementedException(); }
        }

        public UserControl CURRENT
        {
            get { return this; }
        }

        public string WindowID { get; set; }

        public bool IsValid()
        {
            Permissoes permissoes = UsuariosController.CarregarPermissoes(UsuariosController.UsuarioLogado.Id);
            if (permissoes.Admin)
            {
                return true;
            }

            Notificacao.Alerta("Acesso negado.");
            return false;
        }

        private void dataGridUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            CarregaPermissoes();
        }

        private void dataGridPermissoes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPermissoes.CurrentRow == null || dataGridPermissoes.Rows.Count == 0) return;

            int id = int.Parse(dataGridUsuarios.ValueAt(0).ToString());
            Permissoes permissoes = UsuariosController.CarregarPermissoes(id);
            Usuarios usuario = UsuariosController.Carregar(id);

            string pName = dataGridPermissoes.ValueAt(0).ToString();
            permissoes.GetType().GetProperty(pName).SetValue(permissoes, (bool)dataGridPermissoes.ValueAt(2), null);
            UsuariosController.Salvar(usuario, permissoes);
        }

        private void btExcluir_Yb_Click()
        {
            new Alerta("Teste");
        }
    }
}
