using DBX.Entities;
using DBX_VisualClient.SERVICE;
using DBXConnector;
using Financeiro.Controllers;
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
    public partial class TopClient : Form
    {
        public TopClient()
        {
            InitializeComponent();
            ListaConexoes();
        }

        private void ListaConexoes()
        {
            int i = 0;

            tvwConexoes.Nodes[0].Nodes.Clear();

            DBXConnection conn = new DBXConnection();
            conn.Configure("localhost", "APOLLO", "LOG");

            DBXCommand cmd = new DBXCommand();
            cmd.Execute("select * from conexoes");
            ResponseObject ro = ClientService.ReceiveResponse();
            
            if(!ClientService.CONNECTED)
            {
                MessageBox.Show("Não foi possível conectar com o DBAccess. \nVerifique se o serviço de DBX está iniciado e tente novamente. \nCaso o problema persista, acione o suporte tecnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            foreach (DataRow row in ro.DataTable.Rows)
            {
                TreeNode node = new TreeNode(row["NOME"].ToString());
                tvwConexoes.Nodes[0].Nodes.Add(node);

                if (i == 0)
                {
                    CarregaAmbientes(row["NOME"].ToString());
                    tvwConexoes.SelectedNode = node;
                }
            }

        }

        private void CarregaAmbientes(string conexao)
        {
            dataGridAmbientes.Rows.Clear();

            DBXConnection conn = new DBXConnection();
            conn.Configure("localhost", "APOLLO", "LOG");

            DBXCommand cmd = new DBXCommand();
            cmd.Execute("select * from ambientes where conexao = " + conexao);
            ResponseObject ro = ClientService.ReceiveResponse();

            foreach (DataRow row in ro.DataTable.Rows)
            {
                dataGridAmbientes.Rows.Add(row["NOME"].ToString());
            }
        }

        private void conexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            NovaConexao nova = new NovaConexao();
            nova.ShowDialog();
            ListaConexoes();
            this.TopMost = true; ;
        }

        private void ambienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            NovoAmbiente novo = new NovoAmbiente();
            novo.ShowDialog();
            ListaConexoes();
            this.TopMost = true;
        }

        private void btConectar_Yb_Click()
        {

        }

        private void Conectar()
        {
            try
            {
                this.Visible = false;
                if (dataGridAmbientes.Rows.Count == 0) return;

                DBXConnection conn = new DBXConnection();
                conn.Configure("localhost", "APOLLO", "LOG");

                DBXCommand cmd = new DBXCommand();
                cmd.Execute("select * from ambientes where conexao = " + tvwConexoes.SelectedNode.Text);
                ResponseObject ro_ambientes = ClientService.ReceiveResponse();

                cmd.Execute("select * from conexoes where nome = " + tvwConexoes.SelectedNode.Text);
                ResponseObject ro_conexao = ClientService.ReceiveResponse();

                DataRow dr_ambiente = ro_ambientes.DataTable.Rows[0];
                DataRow dr_conexao = ro_conexao.DataTable.Rows[0];

                DBConfig config = new DBConfig();

                config.DataBase = dr_ambiente["BASE"].ToString().ToLower();
                config.Host = dr_conexao["SERVIDOR"].ToString();
                config.Port = int.Parse(dr_conexao["PORTA"].ToString());
                config.User = dr_conexao["USUARIO"].ToString().ToLower();
                config.Password = dr_conexao["SENHA"].ToString().ToLower();

                Session session = new Session(config);

                if (session.GetDatabaseConnection().State == ConnectionState.Open)
                {
                    session.Close();

                    EnvironmentController.Config = config;
                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                }
                else
                {
                    this.Visible = true;
                    MessageBox.Show("Não foi possível conectar com o servidor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.Visible = true;
                Log.Write("TopClient", "Conectar", ex.Message);
                MessageBox.Show("O sistema encontrou problemas em processar a solicitação e precisará ser encerrado. \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void tvwConexoes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (tvwConexoes.SelectedNode.Text == "Conexões") return;

            CarregaAmbientes(tvwConexoes.SelectedNode.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectar();
        }
    }
}
