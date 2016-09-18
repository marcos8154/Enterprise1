using Financeiro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Controllers
{
    public class Notificacao
    {
        private static PictureBox mainPb;
        private static Label mainLabel;

        public static void Inicializar(PictureBox pb, Label label)
        {
            mainPb = pb;
            mainLabel = label;

            Publicar(TIPO_NOTIFICACAO.SUCESSO, "Sistema carregado com sucesso.");
        }

        public static void Alerta(string msg)
        {
            Publicar(TIPO_NOTIFICACAO.ALERTA, msg);
           // new Atencao(msg);      
        }

        public static void Sucesso(string msg)
        {
            Publicar(TIPO_NOTIFICACAO.SUCESSO, msg);
        }

        public static void Erro(string msg)
        {
            Publicar(TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema ao processar solicitação: " + msg);
        }

        public static void Publicar(TIPO_NOTIFICACAO tipo, string mensagem)
        {
            try
            {
                switch (tipo)
                {
                    case TIPO_NOTIFICACAO.ALERTA:

                        mainPb.BackgroundImage = Financeiro.Properties.Resources.ic_alerta;
                        mainLabel.Text = mensagem;

                        break;

                    case TIPO_NOTIFICACAO.ERRO:

                        mainPb.BackgroundImage = Financeiro.Properties.Resources.ic_erro;
                        mainLabel.Text = mensagem;

                        break;

                    case TIPO_NOTIFICACAO.SUCESSO:

                        mainPb.BackgroundImage = Financeiro.Properties.Resources.ic_sucesso;
                        mainLabel.Text = mensagem;

                        break;
                }
            }
            catch { }
        }
    }
}
