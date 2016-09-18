using Entidades;
using Financeiro.Enums;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class MovimentosController
    {
        public static Movimentos UltimoMovimento(int id_pessoa, Tipo_pessoa tipo_pessoa)
        {
            Session session = null;

            try
            {
                session = new ConfigureSession().GetSession();

                string tipo = "";

                Movimentos movRetorno = new Movimentos();

                switch(tipo_pessoa)
                {
                    case Tipo_pessoa.CLIENTE:

                        session.LastRecord(movRetorno, "id_cliente = " + id_pessoa);
                        break;

                    case Tipo_pessoa.FORNECEDOR:

                        session.LastRecord(movRetorno, "id_fornecedor = " + id_pessoa);
                        break;

                    case Tipo_pessoa.FUNCIONARIO:

                        session.LastRecord(movRetorno, "id_funcionario = " + id_pessoa);
                        break;
                }

                session.Close();

                return movRetorno;
            }
            catch(Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Publicar(TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + ex.Message);
                Log.Write("MovimentosController", "UltimoMovimento", ex.Message);

                return new Movimentos();
            }
        }
    }
}
