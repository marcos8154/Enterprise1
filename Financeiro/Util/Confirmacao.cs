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
    public partial class Confirmacao : Form
    {
        public bool Result { get; set; }

        public Confirmacao(string msg)
        {
            InitializeComponent();
            
            txMsg.Text = msg;
            this.TopMost = true;
            Result = false;
            this.ShowDialog();
        }

        private void btSIM_Yb_Click()
        {
            Result = true;
            Close();
        }

        private void btOK_Yb_Click()
        {
            Close();
        }
    }
}
