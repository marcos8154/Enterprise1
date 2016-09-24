using DevComponents.DotNetBar;
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
    public partial class Preparando : Form
    {
        int max = 0;

        public Preparando(int max)
        {
             InitializeComponent();

            this.max = max;
        }

        public void SetText(string texto)
        {
            lbText.Invoke(new Action<LabelX>(text => lbText.Text = texto), lbText);
        }

        public void Publish()
        {
            progresso.Invoke(new Action<ProgressBar>(progr => progresso.Value++), progresso);
        }

        private void Preparando_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            progresso.Maximum = max;
            lbText.Text = string.Empty;
        }
    }
}
