namespace Financeiro.UserControls.MdlAdministracao.Consultas
{
    partial class BuscarEmpresa
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEmpr = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txPesquisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.yellowButton1 = new Financeiro.UserControls.Especiais.YellowButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmpr
            // 
            this.dataGridEmpr.AllowUserToAddRows = false;
            this.dataGridEmpr.AllowUserToDeleteRows = false;
            this.dataGridEmpr.AllowUserToOrderColumns = true;
            this.dataGridEmpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmpr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmpr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridEmpr.Location = new System.Drawing.Point(3, 32);
            this.dataGridEmpr.Name = "dataGridEmpr";
            this.dataGridEmpr.ReadOnly = true;
            this.dataGridEmpr.Size = new System.Drawing.Size(892, 419);
            this.dataGridEmpr.TabIndex = 0;
            this.dataGridEmpr.DoubleClick += new System.EventHandler(this.dataGridEmpr_DoubleClick);
            // 
            // txPesquisa
            // 
            // 
            // 
            // 
            this.txPesquisa.Border.Class = "TextBoxBorder";
            this.txPesquisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txPesquisa.Location = new System.Drawing.Point(3, 4);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.PreventEnterBeep = true;
            this.txPesquisa.Size = new System.Drawing.Size(416, 23);
            this.txPesquisa.TabIndex = 2;
            this.txPesquisa.WatermarkText = "Pesquisar";
            this.txPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPesquisa_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome fantasia";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Razão social";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CNPJ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telefone 1";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefone 2";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Celular";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cidade";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 180;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 458);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(282, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Duplo clique para selecionar a empresa";
            // 
            // yellowButton1
            // 
            this.yellowButton1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowButton1.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.yellowButton1.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.yellowButton1.ButtonText = "&Sair";
            this.yellowButton1.Location = new System.Drawing.Point(822, 457);
            this.yellowButton1.Name = "yellowButton1";
            this.yellowButton1.Size = new System.Drawing.Size(73, 26);
            this.yellowButton1.TabIndex = 1;
            this.yellowButton1.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.yellowButton1_Yb_Click);
            // 
            // BuscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.yellowButton1);
            this.Controls.Add(this.dataGridEmpr);
            this.Name = "BuscarEmpresa";
            this.Size = new System.Drawing.Size(898, 490);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridEmpr;
        private Especiais.YellowButton yellowButton1;
        private DevComponents.DotNetBar.Controls.TextBoxX txPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}
