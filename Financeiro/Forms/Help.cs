using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro.Forms
{
    public partial class Help : Form
    {
        public Help(string text, DataTable fields)
        {
            InitializeComponent();

            txConteudo.Text = text;
            dataGridCampos.DataSource = fields.DefaultView;
            dataGridCampos.Columns[1].MinimumWidth = 100;
            dataGridCampos.Columns[2].MinimumWidth = 150;
            this.TopMost = true;
            dataGridCampos.Focus();
            this.Show();
        }
    }
}
