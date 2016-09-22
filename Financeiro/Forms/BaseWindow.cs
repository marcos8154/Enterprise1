using Financeiro.Controllers;
using Financeiro.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Forms
{
    [Serializable]
    public partial class BaseWindow : Form, IManagedWindow
    {
        private IManagedUserControl managedUserControl;

        public BaseWindow(IManagedUserControl userControl, string title, bool sizable = true, bool apply_size = true)
        {
            InitializeComponent();

            this.TopMost = true;
            this.Width = userControl.CURRENT.Width + 20;
            this.Height = userControl.CURRENT.Height + 40;
            this.Controls.Add(userControl.CURRENT);
            this.Text = title;

            userControl.CURRENT.Dock = DockStyle.Fill;

            managedUserControl = userControl;
            Title = title;
            Sizable = sizable;

            if (!sizable)
            {
                this.MaximizeBox = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            }
        }

        public BaseWindow(UserControl userControl, string title)
        {
            this.Width = userControl.Width + 20;
            this.Height = userControl.Height + 40;
            this.Controls.Add(userControl);
            this.Text = title;
            this.Title = title;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            NonManagedWindows.Add(this);
            this.ShowDialog();
        }

        public string Title { get; set; }

        public string WindowID { get; set; }

        public Form CURRENT_FORM
        {
            get { return this; }
        }

        public IManagedUserControl ManagedUserControl
        {
            get { return managedUserControl; }
        }


        public bool Sizable { get; set; }
    }
}
