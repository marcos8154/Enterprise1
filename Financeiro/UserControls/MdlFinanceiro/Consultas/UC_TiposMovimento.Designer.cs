namespace Financeiro.UserControls.MdlFinanceiro.Consultas
{
    partial class UC_TiposMovimento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Component Designer

        /// <summary> 
        /// Método necessário para o suporte do Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridTmv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txPesquisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSair = new Financeiro.UserControls.Especiais.YellowButton();
            this.btExcluir = new Financeiro.UserControls.Especiais.YellowButton();
            this.btNovo = new Financeiro.UserControls.Especiais.YellowButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTmv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTmv
            // 
            this.dataGridTmv.AllowUserToAddRows = false;
            this.dataGridTmv.AllowUserToDeleteRows = false;
            this.dataGridTmv.AllowUserToOrderColumns = true;
            this.dataGridTmv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTmv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.q,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTmv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTmv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridTmv.Location = new System.Drawing.Point(4, 35);
            this.dataGridTmv.Name = "dataGridTmv";
            this.dataGridTmv.ReadOnly = true;
            this.dataGridTmv.Size = new System.Drawing.Size(708, 411);
            this.dataGridTmv.TabIndex = 0;
            // 
            // txPesquisa
            // 
            // 
            // 
            // 
            this.txPesquisa.Border.Class = "TextBoxBorder";
            this.txPesquisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txPesquisa.Location = new System.Drawing.Point(7, 8);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.PreventEnterBeep = true;
            this.txPesquisa.Size = new System.Drawing.Size(276, 21);
            this.txPesquisa.TabIndex = 1;
            this.txPesquisa.WatermarkText = "Pesquisar por descrição";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Descrição";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 220;
            // 
            // q
            // 
            this.q.HeaderText = "Movimentação itens";
            this.q.Name = "q";
            this.q.ReadOnly = true;
            this.q.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Movimentação valores";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ativo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btSair
            // 
            this.btSair.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btSair.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btSair.ButtonText = "&Sair";
            this.btSair.Location = new System.Drawing.Point(640, 452);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(72, 25);
            this.btSair.TabIndex = 4;
            // 
            // btExcluir
            // 
            this.btExcluir.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btExcluir.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btExcluir.ButtonText = "&Excluir";
            this.btExcluir.Location = new System.Drawing.Point(562, 4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(72, 25);
            this.btExcluir.TabIndex = 3;
            // 
            // btNovo
            // 
            this.btNovo.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btNovo.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btNovo.ButtonText = "&Novo";
            this.btNovo.Location = new System.Drawing.Point(640, 4);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(72, 25);
            this.btNovo.TabIndex = 2;
            // 
            // UC_TiposMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.dataGridTmv);
            this.Name = "UC_TiposMovimento";
            this.Size = new System.Drawing.Size(713, 484);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTmv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridTmv;
        private DevComponents.DotNetBar.Controls.TextBoxX txPesquisa;
        private Especiais.YellowButton btNovo;
        private Especiais.YellowButton btExcluir;
        private Especiais.YellowButton btSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
