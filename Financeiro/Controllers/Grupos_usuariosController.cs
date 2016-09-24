using Entidades;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro.Controllers
{
    public class Grupos_usuariosController
    {
        static string controllerName = "Grupos_usuariosController";

        public static Grupos_usuarios Carregar(int grupo_id)
        {
            Session session = null;
            try
            {
                Grupos_usuarios grupo = new Grupos_usuarios();
                session = new ConfigureSession().GetSession();
                session.OnID(grupo, grupo_id);
                session.Close();
                return grupo;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Carregar", ex.Message);

                return new Grupos_usuarios();
            }
        }

        public static bool Excluir(int grupo_id)
        {
            Session session = null;
            Transaction transaction = null;
            try
            {
                Grupos_usuarios grupo = Carregar(grupo_id);
                Permissoes permissoes = new Entidades.Permissoes();
                if (!PodeExcluir(grupo)) return false;

                session = new ConfigureSession().GetSession();
                transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                session.Delete(permissoes, "grupos_id = " + grupo_id, transaction);
                session.Delete(grupo, grupo_id, transaction);
               
                bool result = transaction.Commit();
                session.Close();
                return result;
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.RollBack();
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Excluir", ex.Message);

                return false;
            }
        }

        private static bool PodeExcluir(Grupos_usuarios grupo)
        {
            Usuarios usuarios = new Usuarios();
            if (EntidadeController.Existe(usuarios, "grupo_id", grupo.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluír este grupo de usuários. Existem um ou mais usuários relacionados a ele.");
                return false;
            }

            return true;
        }

        public static bool Salvar(Grupos_usuarios grupo, List<Permissoes> permissoes)
        {
            Session session = null;
            Transaction transaction = null;
            try
            {
                Permissoes perm = new Permissoes();

                if (!Validar(grupo)) return false;
                session = new ConfigureSession().GetSession();
                transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                session.Delete(perm, "grupos_id = " + grupo.Id, transaction);

                if (EntidadeController.Existe(grupo, "id", grupo.Id.ToString()))
                {
                    session.Update(grupo, null, transaction);
                }
                else
                {
                    session.Save(grupo, transaction);
                }

                foreach (Permissoes p in permissoes)
                {
                    p.Grupos_id = grupo.Id;
                    session.Save(p, transaction);
                }

                bool result = false;
                if (transaction.Commit()) result = true;
                session.Close();
                Notificacao.Sucesso("Alterações realizados com exito.");
                return result;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Salvar", ex.Message);

                return false;
            }
        }

        private static bool Validar(Grupos_usuarios grupo)
        {
            if (string.IsNullOrWhiteSpace(grupo.Descricao))
            {
                Notificacao.Alerta("A descrição não pode estar vazia.");
                return false;
            }

            return true;
        }

        public static List<Permissoes> Permissoes(int grupo_id)
        {
            Session session = null;
            try
            {
                Permissoes perm = new Permissoes();
                session = new ConfigureSession().GetSession();
                session.ReadAll(perm, "grupos_id = " + grupo_id);
                session.Close();

                return session.GetList(perm);
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Permissoes", ex.Message);

                return new List<Entidades.Permissoes>();
            }
        }

        public static Rotinas Rotina(int rotina_id)
        {
            Session session = null;
            try
            {
                Rotinas rotina = new Rotinas();
                session = new ConfigureSession().GetSession();
                session.OnID(rotina, rotina_id);
                session.Close();

                return rotina;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Rotina", ex.Message);
                return new Rotinas();
            }
        }
    }
}
