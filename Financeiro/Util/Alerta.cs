using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro.Util
{
    public partial class Alerta : Form
    {
        public Alerta(string msg)
        {
            InitializeComponent();

            txMsg.Text = msg;
            this.TopMost = true;
            this.ShowDialog();
        }

        private void btOK_Yb_Click()
        {
            Close();
        }
    }
}
