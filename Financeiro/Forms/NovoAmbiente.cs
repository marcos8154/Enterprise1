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
    public partial class NovoAmbiente : Form
    {
        public NovoAmbiente()
        {
            InitializeComponent();
            ListaConexoes();
        }

        private void ListaConexoes()
        {
            DBXConnection conn = new DBXConnection();
            conn.Configure("localhost", "APOLLO", "LOG");

            DBXCommand cmd = new DBXCommand();
            cmd.Execute("select * from conexoes");
            ResponseObject ro = ClientService.ReceiveResponse();

            foreach (DataRow row in ro.DataTable.Rows)
            {
                cbConexoes.Items.Add(row["NOME"]);
            }
        }

        private List<FileInfo> ListaTabelas()
        {
            DirectoryInfo dInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\Tables\");
            FileInfo[] files = dInfo.GetFiles();

            List<FileInfo> result = new List<FileInfo>();

            foreach (FileInfo file in files)
            {
                if (file.Extension == ".sql") result.Add(file);
            }

            return result;
        }

        private void btCriar_Yb_Click()
        {
            Criar();
        }

        private void Criar()
        {
            try
            {
                DBXConnection conn = new DBXConnection();
                conn.Configure("localhost", "APOLLO", "LOG");

                DBXCommand cmd = new DBXCommand();
                cmd.Execute("insert into ambientes(conexao, nome, base) values (" + cbConexoes.Text + ", " + txNome.Text + ", " + txBase.Text + ")");
                ResponseObject ro = ClientService.ReceiveResponse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um problema durante a criação do ambiente: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
