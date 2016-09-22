using Entidades;
using Financeiro.Forms;
using Financeiro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Controllers
{
    [Serializable]
    public class WindowManager
    {
        private List<IManagedWindow> managedsWindows = new List<IManagedWindow>();
        public ToolStripMenuItem menuJanela { get; set; }
        public ToolStrip BarraTarefas { get; set; }

        public IManagedUserControl CurrentUserControl { get; set; }

        public void CloseAll(bool withMenu = false)
        {
            BarraTarefas.Enabled = false;
            ignore = true;
            foreach (IManagedWindow imw in managedsWindows)
            {
                imw.CURRENT_FORM.Close();

                if (withMenu)
                {
                    foreach (ToolStripMenuItem item in menuJanela.DropDownItems)
                    {
                        if (item.Name == imw.WindowID)
                        {
                            menuJanela.DropDownItems.Remove(item);
                            break;
                        }
                    }
                }
            }

            if (withMenu) managedsWindows.Clear();
        }

        public void Cascade()
        {
            try
            {

                foreach (IManagedWindow imv in managedsWindows)
                {
                    RecoverWindow(imv.WindowID);
                }
            }
            catch { }
        }

        bool ignore = false;

        public void AddOrShow(IManagedUserControl managedUserControl, string title, string windowID, bool sizable = true, bool maximized = false)
        {
            BarraTarefas.Enabled = true;
            CurrentUserControl = managedUserControl;

            IManagedWindow managedWindow = new BaseWindow(managedUserControl, title, sizable, false);
            managedWindow.WindowID = windowID;
            managedWindow.ManagedUserControl.WindowID = windowID;
            managedWindow.ManagedUserControl.BarraTarefas = new Interfaces.BarraTarefas(BarraTarefas);

            if (maximized) managedWindow.CURRENT_FORM.WindowState = FormWindowState.Maximized;
            if (!managedWindow.ManagedUserControl.IsValid()) return;

            var test = from window in managedsWindows where window.WindowID == windowID select window;

            if (test.Count() > 0) RecoverWindow(windowID);
            else
            {
                managedsWindows.Add(managedWindow);
                managedWindow.CURRENT_FORM.TopMost = true;
                managedWindow.CURRENT_FORM.Resize += CURRENT_FORM_Resize;
                managedWindow.CURRENT_FORM.KeyPreview = true;
                managedWindow.CURRENT_FORM.KeyDown += CURRENT_FORM_KeyDown;
                managedWindow.CURRENT_FORM.GotFocus += CURRENT_FORM_GotFocus;
                managedWindow.ManagedUserControl.CURRENT.Load += CURRENT_Load;
                managedWindow.CURRENT_FORM.Show();

                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = windowID;
                item.Text = title;
                menuJanela.DropDownItems.Add(item);

                item.Click += item_Click;

                managedWindow.CURRENT_FORM.FormClosing += CURRENT_FormClosing;
            }
        }

        private void CURRENT_Load(object sender, EventArgs e)
        {
            UserControl userControl = (sender as UserControl);
            IManagedUserControl muc = (userControl as IManagedUserControl);
            muc.OnLoad();
        }

        private void CURRENT_FORM_GotFocus(object sender, EventArgs e)
        {
            Form form = (sender as Form);
            IManagedWindow managedWindow = (form as IManagedWindow);
            CurrentUserControl = managedWindow.ManagedUserControl;
            CurrentUserControl.OnRestore();
            BarraTarefas.Enabled = true;
        }

        void CURRENT_FORM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.CurrentUserControl = null;
                BarraTarefas.Enabled = false;
                Form form = (sender as Form);
                form.Close();
            }
        }

        void CURRENT_FORM_Resize(object sender, EventArgs e)
        {
            Form form = (sender as Form);

            if (form.WindowState == FormWindowState.Minimized)
            {
                form.Visible = false;
                BarraTarefas.Enabled = false;
            }
            else
            {
                BarraTarefas.Enabled = true;
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (sender as ToolStripMenuItem);
            RecoverWindow(item.Name);
        }

        public void RecoverWindow(string WindowID)
        {
            IManagedWindow current = null;
            try
            {
                foreach (IManagedWindow managedWw in managedsWindows)
                {
                    if (managedWw.WindowID == WindowID)
                    {
                        current = managedWw;
                        CurrentUserControl = managedWw.ManagedUserControl;
                        managedWw.CURRENT_FORM.Visible = true;
                        managedWw.CURRENT_FORM.WindowState = FormWindowState.Normal;
                        BarraTarefas.Enabled = true;
                        managedWw.ManagedUserControl.OnRestore();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                current = new BaseWindow(current.ManagedUserControl, current.Title, current.Sizable);
                managedsWindows.Remove(current);
                AddOrShow(current.ManagedUserControl, current.Title, current.WindowID, current.Sizable);
            }
        }

        private void CURRENT_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (ignore) return;
            BarraTarefas.Enabled = false;
            Form form = (sender as Form);
            var sel = from search in managedsWindows where search.WindowID == (form as IManagedWindow).WindowID select search;

            List<IManagedWindow> to_remove = new List<IManagedWindow>();

            foreach (IManagedWindow imgw in sel)
            {
                to_remove.Add(imgw);
            }

            foreach (IManagedWindow imgw in to_remove)
            {
                managedsWindows.Remove(imgw);

                foreach (ToolStripMenuItem item in menuJanela.DropDownItems)
                {
                    if (item.Name == imgw.WindowID)
                    {
                        menuJanela.DropDownItems.Remove(item);
                        break;
                    }
                }
            }
        }

        public void RestoreState()
        {
            try
            {
                List<UserWindow> list = WindowRestoreProfile.Load(UsuariosController.UsuarioLogado.Id);

                foreach (UserWindow window in list)
                {
                    var type = Type.GetType(window.Name);
                    IManagedUserControl uc = (IManagedUserControl)Activator.CreateInstance(type);
                    AddOrShow(uc, window.Title, window.WindowID, window.Sizable);
                }
            }
            catch (Exception ex) { }
        }

        public void SaveState()
        {
            int usuario_id = UsuariosController.UsuarioLogado.Id;

            WindowRestoreProfile.Save(managedsWindows, usuario_id);
            CloseAll();
        }

        public void MinimizeAll()
        {
            BarraTarefas.Enabled = false;
            try
            {
                foreach (IManagedWindow window in managedsWindows)
                {
                    window.CURRENT_FORM.WindowState = FormWindowState.Minimized;
                }

            }
            catch { }
        }
    }

    public class NonManagedWindows
    {
        static List<Form> forms = null;

        public static WindowManager WindowManager { get; set; }

        public static void Initialize()
        {
            forms  = new List<Form>();
        }

        public static void Add(Form form)
        {
            forms.Add(form);
        }

        public static void CloseAll()
        {
            var results = from result in forms where result != null select result;

            foreach(Form form in results)
            {
                try
                {
                    form.Close();
                }
                catch { }
            }
        }
    }
}
