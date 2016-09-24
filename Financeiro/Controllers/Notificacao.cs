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
        private static Label notificacao;
        private static Label telaAtual;
        
        public static void Inicializar(PictureBox pb, Label lbNotificacao, Label lbTelaAtual)
        {
            mainPb = pb;
            notificacao = lbNotificacao;
            telaAtual = lbTelaAtual;
            telaAtual.Text = string.Empty;

            Publicar(TIPO_NOTIFICACAO.SUCESSO, "Sistema carregado com sucesso.");
        }

        public static void Tela(string tela)
        {
            telaAtual.Text = tela;
        }

        public static void Alerta(string msg)
        {
            Publicar(TIPO_NOTIFICACAO.ALERTA, msg);
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
                        notificacao.Text = mensagem;

                        break;

                    case TIPO_NOTIFICACAO.ERRO:

                        mainPb.BackgroundImage = Financeiro.Properties.Resources.ic_erro;
                        notificacao.Text = mensagem;

                        break;

                    case TIPO_NOTIFICACAO.SUCESSO:

                        mainPb.BackgroundImage = Financeiro.Properties.Resources.ic_sucesso;
                        notificacao.Text = mensagem;

                        break;
                }
            }
            catch { }
        }
    }
}
