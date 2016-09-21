using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro.Controllers
{
    public class IMucController
    {
        public static void LimparCampos(UserControl userControl)
        {
            foreach (Control control in userControl.Controls)
            {
                if (control.GetType() == typeof(TextBoxX)) (control as TextBoxX).Text = string.Empty;
                if (control.GetType() == typeof(IntegerInput)) (control as IntegerInput).Value = 0;
                if (control.GetType() == typeof(MaskedTextBoxAdv)) (control as MaskedTextBoxAdv).Text = string.Empty;
                if (control.GetType() == typeof(MaskedTextBox)) (control as MaskedTextBox).Text = string.Empty;
            }
        }
    }
}
