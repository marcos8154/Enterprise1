using Entidades;
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
    public class ProdutosController
    {
        static string controllerName = "ProdutosController";

        public static List<Produtos> Listar(bool para_venda, bool fabricado, bool para_fabricacao, bool para_balanca, string busca = "")
        {
            Session session = null;

            try
            {
                session = new ConfigureSession().GetSession();
                busca = busca.Replace("'", string.Empty);
                string criterio = "";

                criterio += " WHERE produtos.descricao LIKE '{busca}'";
                criterio += " OR    produtos.descricao_reduzida LIKE '{busca}'";
                criterio += " OR    produtos.referencia LIKE '{busca}'";
                criterio += " OR    produtos.ean LIKE '{busca}'";
                criterio += " OR    produtos.marca LIKE '{busca}'";
                criterio += " OR    produtos.para_balanca = " + (para_balanca ? 1 : 0);
                criterio += " OR    produtos.para_fabricacao = " + (para_fabricacao ? 1 : 0);
                criterio += " OR    produtos.fabricado = " + (fabricado ? 1 : 0);
                criterio += " OR    produtos.para_venda = " + (para_venda ? 1 : 0);
                criterio += " OR    unidades.sigla LIKE '{busca}'";
                criterio += " OR    unidades.descricao LIKE '{busca}'";
                criterio += " OR    locais_estoque.descricao LIKE '{busca}'";
                criterio = criterio.Replace("{busca}", ("%" + busca + "%"));

                Produtos produtos = new Produtos();
                Unidades unidades = new Unidades();
                Locais_estoque locais_estoque = new Locais_estoque();
                Grupos grupos = new Grupos();

                List<Produtos> lista = null;

                if (!string.IsNullOrEmpty(busca))
                {
                    Join join = new Join(produtos);

                    join.AddJoin(Persistor_GA.GeneralClasses.Enums.JOIN_TYPE.INNER, unidades, "unidades.id IN (produtos.unidade, produtos.segunda_unidade)");
                    join.AddJoin(Persistor_GA.GeneralClasses.Enums.JOIN_TYPE.INNER, locais_estoque, "locais_estoque.id = produtos.locais_estoque_id");
                    join.AddJoin(Persistor_GA.GeneralClasses.Enums.JOIN_TYPE.LEFT, grupos, "grupos.id = produtos.grupos_id");
                    join.AddFinalCondition(criterio);

                    join.Execute(session);
                    lista = join.GetList(produtos);
                }
                else
                {
                    session.ReadAll(produtos);
                    lista = session.GetList(produtos);
                }

                session.Close();
                return lista;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "listar", ex.Message);
                return new List<Produtos>();
            }
        }

        public static Produtos Carregar(int id_produto)
        {
            Session session = null;
            try
            {
                Produtos produto = new Produtos();

                session = new ConfigureSession().GetSession();
                session.OnID(produto, id_produto);
                session.Close();

                return produto;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "carregar", ex.Message);

                return null;
            }
        }

        public static bool Salvar(Produtos produto, Financeiro_produtos finan_prod, List<Caracteristicas> caracteristicas)
        {
            Session session = null;
            Transaction transaction = null;
            try
            {
                if (!Validar(produto)) return false;
                session = new ConfigureSession().GetSession();
                transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);

                if (EntidadeController.Existe(produto, "id", produto.Id.ToString()))
                {
                    Produtos_caracteristicas pc = new Produtos_caracteristicas();

                    session.Delete(pc, "produtos_id = " + produto.Id, transaction);
                    session.Update(finan_prod, null, transaction);
                    session.Update(produto, null, transaction);
                    SalvaCaracts(caracteristicas, produto.Id, session, transaction);

                    Notificacao.Sucesso("Produto atualizado.");
                }
                else
                {
                    session.Save(produto, transaction);
                    finan_prod.Produtos_id = produto.Id;
                    session.Save(finan_prod, transaction);
                    SalvaCaracts(caracteristicas, produto.Id, session, transaction);

                    Notificacao.Sucesso("Produto salvo.");
                }

                bool result = false;
                if (transaction.Commit()) result = true;
                session.Close();

                return result;
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.RollBack();
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "salvar", ex.Message);

                return false;
            }
        }

        private static void SalvaCaracts(List<Caracteristicas> caracteristicas, int id_produto, Session session, Transaction transaction)
        {
            foreach (Caracteristicas c in caracteristicas)
            {
                Produtos_caracteristicas pc = new Produtos_caracteristicas();

                pc.Produtos_id = id_produto;
                pc.Caracteristicas_id = c.Id;

                session.Save(pc, transaction);
            }
        }

        public static bool Excluir(int id_produto)
        {
            Session session = null;
            Transaction transaction = null;

            try
            {
                Produtos produto = Carregar(id_produto);
                Financeiro_produtos finan_prod = Financeiro_produtos(id_produto);
                Produtos_caracteristicas pc = new Produtos_caracteristicas();

                if (!PodeExcluir(produto)) return false;

                session = new ConfigureSession().GetSession();
                transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);

                session.Delete(pc, "produtos_id = " + produto.Id, transaction);
                session.Delete(produto, id_produto, transaction);
                session.Delete(finan_prod, finan_prod.Id, transaction);

                bool result = false;
                if (transaction.Commit()) result = true;
                session.Close();
                Notificacao.Sucesso("Produto excluído.");

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

        public static Financeiro_produtos Financeiro_produtos(int id_produto)
        {
            Session session = null;

            try
            {
                Financeiro_produtos finan_prod = new Financeiro_produtos();

                session = new ConfigureSession().GetSession();
                session.CreateCriteria(finan_prod, Persistor_GA.GeneralClasses.Enums.RESULT_TYPE.UNIQUE)
                    .Add(Restrictions.Eq(Persistor_GA.GeneralClasses.Enums.FILTER_TYPE.WHERE, "produtos_id", id_produto))
                    .Execute();

                session.Close();
                return finan_prod;
            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Financeiro_produtos", ex.Message);

                return null;
            }
        }

        public static List<Caracteristicas> Caracteristicas(int id_produto)
        {
            Session session = null;
            try
            {
                Caracteristicas caracteristicas = new Caracteristicas();
                Produtos_caracteristicas prod_caract = new Produtos_caracteristicas();

                session = new ConfigureSession().GetSession();
                session.OneToMany(prod_caract, caracteristicas, Persistor_GA.GeneralClasses.Enums.JOIN_TYPE.INNER, "produtos_caracteristicas.produtos_id = " + id_produto);
                session.Close();

                return session.GetList(caracteristicas);
            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Caracteristicas", ex.Message);

                return new List<Caracteristicas>();
            }
        }

        private static bool PodeExcluir(Produtos produto)
        {
            Itens_movimento imv = new Itens_movimento();
            Itens_pedido itens = new Itens_pedido();

            if (EntidadeController.Existe(imv, "produtos_id", produto.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluír este produto. \nEle está relacionado a um ou mais movimentos.");
                return false;
            }

            if (EntidadeController.Existe(itens, "produtos_id", produto.Id.ToString()))
            {
                Notificacao.Alerta("Não é possível excluír este produto. \nEle está relacionado a um ou mais pedidos de compra.");
                return false;
            }

            return true;
        }

        private static bool Validar(Produtos produto)
        {
            if (produto.Unidade == 0)
            {
                Notificacao.Alerta("A primeira unidade é obrigatória.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(produto.Descricao))
            {
                Notificacao.Alerta("A descrição do produto é obrigatória.");
                return false;
            }

            if (EntidadeController.Existe(produto, "ean", produto.EAN))
            {
                Notificacao.Alerta("Já existe um produto com o EAN informado. \nVerifique o EAN e tente novamente");
                return false;
            }

            if (EntidadeController.Existe(produto, "referencia", produto.Referencia))
            {
                Notificacao.Alerta("Já existe um produto com a referência informada. \nVerifique a referência e tente novamente.");
                return false;
            }

            return true;
        }
    }
}