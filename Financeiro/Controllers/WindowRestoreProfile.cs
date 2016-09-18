using Financeiro.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class WindowRestoreProfile
    {
        public static void Save(List<IManagedWindow> list, int user_id)
        {
            FileStream fs = null;
            string arquivo = (Directory.GetCurrentDirectory() + @"\UserSessions\" + user_id + ".conf");
            try
            {
                if (File.Exists(arquivo)) File.Delete(arquivo);

                List<UserWindow> list_window = new List<UserWindow>();

                foreach (IManagedWindow imw in list)
                {
                    UserWindow window = new UserWindow();

                    window.User_ID = user_id;
                    window.WindowID = imw.WindowID;
                    window.Title = imw.Title;
                    window.Name = imw.ManagedUserControl.GetType().FullName;
                    window.Sizable = imw.Sizable;

                    list_window.Add(window);
                }

                fs = new FileStream(arquivo, FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();

                UserSession session = new UserSession();
                session.windows = list_window;

                bf.Serialize(fs, session);

                fs.Close();
            }
            catch (Exception ex)
            {
                if (fs != null) fs.Close();
            }
        }

        public static List<UserWindow> Load(int user_id)
        {
            string arquivo = Directory.GetCurrentDirectory() + @"\UserSessions\" + user_id + ".conf";
            FileStream fs = null;
            try
            {

                fs = new FileStream(arquivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                UserSession session = (UserSession)bf.Deserialize(fs);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "As do login alterior foram restauradas.");
                fs.Close();

                return session.windows;

            }
            catch (Exception ex)
            {
                if (fs != null) fs.Close();
                File.Delete(arquivo);
                return new List<UserWindow>();
            }
        }
    }

    [Serializable]
    public class UserSession
    {
        public List<UserWindow> windows = new List<UserWindow>();
    }

    [Serializable]
    public class UserWindow
    {
        public int User_ID { get; set; }

        public string WindowID { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public bool Sizable { get; set; }
    }
}
