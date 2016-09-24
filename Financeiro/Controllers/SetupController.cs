using Entidades;
using Financeiro.Forms;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Financeiro.Controllers
{
    public class SetupController
    {

        public static void SystemFirstUse()
        {
            Preparando progresso = new Preparando(80);
            progresso.Show();

            new Thread(() =>
            {
                Session session = null;
                Transaction transaction = null;
                StreamReader reader = null;

                try
                {
                    session = new ConfigureSession().GetSession();
                    transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    string line = string.Empty;
                    reader = new StreamReader(Directory.GetCurrentDirectory() + @"\Config\ROTINAS.TXT");

                    while ((line = reader.ReadLine()) != null)
                    {
                        progresso.Publish();
                        progresso.SetText("Criando rotina " + line);

                        string[] s = line.Split('-');

                        Rotinas rotina = new Rotinas();
                        rotina.Codigo = int.Parse(s[0]);
                        rotina.Nome = s[1];

                        session.Save(rotina, transaction);

                        for(int i = 0; i < 100000000; i++)
                        {

                        }
                    }

                    reader.Close();

                    Grupos_usuarios grupo = new Grupos_usuarios();
                    grupo.Descricao = "Administradores";
                    session.Save(grupo, transaction);

                    Usuarios usuario = new Usuarios();
                    usuario.Nome = "Admin";
                    usuario.Senha = "";
                    usuario.Ativo = true;
                    usuario.Grupo_id = grupo.Id;
                    session.Save(usuario, transaction);
                    
                    Rotinas rotinas = new Rotinas();
                    session.ReadAll(rotinas);
                    List<Rotinas> listRotinas = session.GetList(rotinas);

                    for (int i = 0; i < listRotinas.Count; i++)
                    {
                        Rotinas r = listRotinas[i];

                        Permissoes p = new Permissoes();
                        p.Rotina_id = r.Id;
                        p.Acesso = true;
                        p.Inserir = true;
                        p.Alterar = true;
                        p.Excluir = true;
                        p.Grupos_id = grupo.Id;
                        session.Save(p, transaction);

                        progresso.Publish();
                        progresso.SetText("Criando permissão " + i + " de " + listRotinas.Count);

                        for(int a = 0; a < 50000000; a++)
                        {

                        }
                    }

                    progresso.Invoke(new Action<Form>(close => progresso.Close()), progresso);
                      transaction.Commit();
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.RollBack();
                    if (session != null) session.Close();
                }
            }).Start();
        }
    }
}
