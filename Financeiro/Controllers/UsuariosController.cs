using Entidades;
using Financeiro.Enums;
using Financeiro.Forms;
using Financeiro.Interfaces;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using Persistor_GA.GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class UsuariosController
    {
        public static bool EfetuaLogin(string nome, string senha)
        {
            List<Usuarios> lista = Listar("");

            foreach (Usuarios usuario in lista)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    usuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }

        private static Usuarios usuarioLogado = null;

        public static Usuarios UsuarioLogado
        {
            get
            {
                return usuarioLogado;
            }
        }

        public static List<Usuarios> Listar(string busca, bool usuarios_inativos = false)
        {
            Usuarios usuarios = new Usuarios();
            Session session = null;

            try
            {
                session = new ConfigureSession().GetSession();

                if (!string.IsNullOrWhiteSpace(busca))
                {
                    Criteria c = session.CreateCriteria(usuarios, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.MULTIPLE);

                    if (usuarios_inativos)
                        c.Add(Restrictions.In(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "ativo", "0, 1"));
                    else
                        c.Add(Restrictions.Eq(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "ativo", "1"));

                    c.Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.AND, "nome", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE));
                    c.Add(Restrictions.Like(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.OR, "email_rec", busca, Persistor_GA.GeneralClasses.Enums.MatchMode.ANYWHERE));

                    c.Execute();
                }
                else
                    session.ReadAll(usuarios, "ativo " + (usuarios_inativos ? "IN (0, 1)" : "IN (1)"));

                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, usuarios.ResultList.Count + " usuário(s) carregado(s)");

                session.Close();

                return session.GetList(usuarios);
            }
            catch (Exception ex)
            {
                Log.Write("UsuariosController", "Listar", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                return new List<Usuarios>();
            }
        }

        public static Permissoes CarregarPermissoes(Rotina rotina)
        {
            Session session = null;

            try
            {
                int rotina_id = (int)rotina;
                session = new ConfigureSession().GetSession();
                Permissoes permissoes = new Permissoes();

                session.CreateCriteria(permissoes, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.UNIQUE)
                    .Add(Restrictions.Eq(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "grupos_id", UsuarioLogado.Grupo_id))
                    .Add(Restrictions.Eq(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.AND, "rotina_id", rotina_id))
                    .Execute();

                session.Close();

                return permissoes;
            }
            catch (Exception ex)
            {
                Log.Write("UsuariosController", "CarregaPermissoes", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                return new Permissoes();
            }
        }

        public static Usuarios Carregar(int usuario_id)
        {
            Session session = null;

            try
            {
                Usuarios usuario = new Usuarios();

                session = new ConfigureSession().GetSession();
                session.OnID(usuario, usuario_id);
                session.Close();

                return usuario;
            }
            catch (Exception ex)
            {
                Log.Write("UsuariosController", "Carregar", ex.Message);
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar a solicitação: " + ex.Message);
                return new Usuarios();
            }
        }

        public static bool Salvar(Usuarios usuario)
        {
            if (!Validar(usuario)) return false;
            bool result = false;

            Session session = null;
            Transaction transaction = null;

            try
            {
                session = new ConfigureSession().GetSession();
                transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);

                if (EntidadeController.Existe(usuario, "id", usuario.Id.ToString()))
                {
                    session.Update(usuario, null, transaction);

                    if (transaction.Commit())
                    {
                        Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Usuário alterado.");
                        result = true;
                    }
                }
                else
                {
                    if (EntidadeController.Existe(usuario, "nome", usuario.Nome))
                    {
                        Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "Já existe um usuário com esse nome. Escolha um outro.");
                        session.Close();
                        return false;
                    }

                    session.Save(usuario, transaction);

                    if (transaction.Commit())
                    {
                        Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Usuário incluido.");
                        result = true;
                    }
                }

                session.Close();

                return result;
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.RollBack();
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write("UsuariosController", "Salvar", ex.Message);

                return false;
            }
        }
        
        private static bool Validar(Usuarios usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nome))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "Nome do usuário inválido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuario.Senha))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "A senha do usuário não pode estar vazia.");
                return false;
            }

            if(usuario.Grupo_id == 0)
            {
                Notificacao.Alerta("O grupo é obrigatório.");
            }

            if (usuario.Senha.Length < 6)
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "A senha deve ter pelo menos 6 caracteres.");
                return false;
            }

            return true;
        }
    }
}
