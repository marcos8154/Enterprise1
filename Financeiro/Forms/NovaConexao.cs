using DBX.Entities;
using DBX_VisualClient.SERVICE;
using DBXConnector;
using Persistor.Persistence;
using Persistor_GA.DBConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Forms
{
    public partial class NovaConexao : Form
    {
        public NovaConexao()
        {
            InitializeComponent();
        }

        private void btCancelar_Yb_Click()
        {
            Close();
        }

        private bool TestaConexao()
        {
            try
            {
                DBConfig config = new DBConfig();

                config.DataBase = txTestDB.Text;
                config.Host = txServidor.Text;
                config.Port = txPorta.Value;
                config.User = txUsuario.Text;
                config.Password = txSenha.Text;
               // config.PersistSecurityInfo = ckPersistSecInfo.Checked;

                Session session = new Session(config);

                if (session.GetDatabaseConnection().State == ConnectionState.Open)
                {
                    session.Close();

                    return true;
                }

                session.Close();

            }
            catch (Exception ex)
            {

            }
            return false;
        }

        private void btSalvar_Yb_Click()
        {
            if (string.IsNullOrWhiteSpace(txServidor.Text)) return;
            if (string.IsNullOrWhiteSpace(txNome.Text)) return;

            if (string.IsNullOrWhiteSpace(txUsuario.Text)) return;

               if (!TestaConexao())
                {
                    MessageBox.Show("Não foi possível conectar com o servidor informado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            DBXConnection connection = new DBXConnection();
            connection.Configure("localhost", "APOLLO", "LOG");
            DBXCommand cmd = new DBXCommand();
            cmd.Execute("select * from conexoes where nome = " + txNome.Text);
            ResponseObject ro = ClientService.ReceiveResponse();

            if (ro != null)
                if (ro.DataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Já existe uma conexão com o nome '" + txNome.Text + "'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            cmd.Execute("insert into conexoes(nome, servidor, porta, usuario, senha, psi) values (" + txNome.Text + ", " + txServidor.Text + ", " + txPorta.Value + ", " + txUsuario.Text + ", " + txSenha.Text + ", " + (ckPersistSecInfo.Checked ? 1 : 0) + ")");
            ResponseObject ro2 = ClientService.ReceiveResponse();

            Close();
        }
    }
}
