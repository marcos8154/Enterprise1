using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.UserControls.Especiais
{
    public partial class YellowButton : UserControl
    {
        public delegate void YB_Click();
        public event YB_Click Yb_Click;
        
        public string ButtonText
        {
            get
            {
                return baseButton.Text;
            }
            set
            {
                baseButton.Text = value;
            }
        }

        public Padding ButtonPadding
        {
            get
            {
                return baseButton.Padding;
            }
            set
            {
                baseButton.Padding = value;
            }
        }

        public Padding ButtonMargin
        {
            get
            {
                return baseButton.Margin;
            }
            set
            {
                baseButton.Margin = value;
            }
        }

        public Font ButtonFont
        {
            get
            {
                return baseButton.Font;
            }
            set
            {
                baseButton.Font = value;
            }
        }

        public YellowButton()
        {
            InitializeComponent();
        }

        private void baseButton_Click(object sender, EventArgs e)
        {
            if (Yb_Click != null) Yb_Click();
        }
    }
}
