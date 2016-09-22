using Correios.Net;
using Entidades;
using Financeiro.SessionProvider;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controllers
{
    public class EnderecosController
    {
        static string controllerName = "EnderecosController";
        public static Enderecos CarregarPorCEP(string CEP)
        {
            try
            {
                CEP = CEP.Replace(",", string.Empty);
                CEP = CEP.Replace("-", string.Empty);
                Address enderecoBusca = SearchZip.GetAddress(CEP);

                Enderecos enderecoRetorno = new Enderecos();

                if (enderecoBusca.WasFound)
                {
                    enderecoRetorno.CEP = CEP;
                    enderecoRetorno.Logradouro = enderecoBusca.Street;
                    enderecoRetorno.Municipio = enderecoBusca.City;
                    enderecoRetorno.UF = enderecoBusca.State;
                    enderecoRetorno.Bairro = enderecoBusca.District;
                }

                return enderecoRetorno;
            }
            catch(Exception ex)
            {
                return new Enderecos();
            }
        }

        public static Enderecos Carregar(int id_end)
        {
            Session session = null;
            try
            {
                Enderecos endereco = new Enderecos();

                session = new ConfigureSession().GetSession();
                session.OnID(endereco, id_end);
                session.Close();

                return endereco;

            }
            catch (Exception ex)
            {
                if (session != null) session.Close();
                Notificacao.Erro(ex.Message);
                Log.Write(controllerName, "Carregar", ex.Message);
                return null;
            }
        }
    }
}
