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
using Financeiro.Enums;
using Financeiro.Extencoes;

namespace Financeiro.UserControls.MdlFinanceiro.Consultas
{
    public partial class UC_TiposMovimento : UserControl, IManagedUserControl
    {
        public UC_TiposMovimento()
        {
            InitializeComponent();

            dataGridTmv.AplicarPadroes();
            Carregar();
           
        }

        private string TipoMovimentacao(int tipo_movimentacao)
        {
            switch (tipo_movimentacao)
            {
                case (int)Tipo_Movimentacao.ENTRADA: return "ENTRADA";
                case (int)Tipo_Movimentacao.SAIDA: return "SAIDA";
                case (int)Tipo_Movimentacao.NENHUM: return "NENHUM";
            }

            return string.Empty;
        }

        private void Carregar(string busca = "")
        {
            dataGridTmv.Rows.Clear();
            List<Tipos_movimento> lista = Tipos_movimentoController.Listar(busca);

            foreach(Tipos_movimento tmv in lista)
            {
                string tmvItens = TipoMovimentacao(tmv.Movimentacao_itens);
                string tmvValores = TipoMovimentacao(tmv.Movimentacao_valores);

                dataGridTmv.Rows.Add(tmv.Id, tmv.Descricao, tmvItens, tmvValores, (tmv.Ativo ? "SIM" : "NÃO"));
            }
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
            return true;
        }
    }
}
