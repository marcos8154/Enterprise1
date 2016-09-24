namespace Financeiro.UserControls.MdlAdministracao.Cadastros
{
    partial class CadastroUsuarios
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ckAtivo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.yellowButton2 = new Financeiro.UserControls.Especiais.YellowButton();
            this.yellowButton1 = new Financeiro.UserControls.Especiais.YellowButton();
            this.dataGridPerm = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelX1.Location = new System.Drawing.Point(8, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(41, 21);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nome";
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            // 
            // 
            // 
            this.txNome.Border.Class = "TextBoxBorder";
            this.txNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNome.Location = new System.Drawing.Point(56, 7);
            this.txNome.MaxLength = 100;
            this.txNome.Name = "txNome";
            this.txNome.PreventEnterBeep = true;
            this.txNome.Size = new System.Drawing.Size(229, 20);
            this.txNome.TabIndex = 1;
            // 
            // ckAtivo
            // 
            // 
            // 
            // 
            this.ckAtivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckAtivo.Checked = true;
            this.ckAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAtivo.CheckValue = "Y";
            this.ckAtivo.Location = new System.Drawing.Point(56, 85);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(50, 23);
            this.ckAtivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckAtivo.TabIndex = 2;
            this.ckAtivo.Text = "Ativo";
            // 
            // txEmail
            // 
            // 
            // 
            // 
            this.txEmail.Border.Class = "TextBoxBorder";
            this.txEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txEmail.Location = new System.Drawing.Point(56, 33);
            this.txEmail.MaxLength = 100;
            this.txEmail.Name = "txEmail";
            this.txEmail.PreventEnterBeep = true;
            this.txEmail.Size = new System.Drawing.Size(229, 20);
            this.txEmail.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelX2.Location = new System.Drawing.Point(8, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(41, 21);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Email";
            // 
            // txSenha
            // 
            this.txSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            // 
            // 
            // 
            this.txSenha.Border.Class = "TextBoxBorder";
            this.txSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txSenha.Location = new System.Drawing.Point(56, 59);
            this.txSenha.MaxLength = 100;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '•';
            this.txSenha.PreventEnterBeep = true;
            this.txSenha.Size = new System.Drawing.Size(229, 20);
            this.txSenha.TabIndex = 6;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelX3.Location = new System.Drawing.Point(9, 59);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(41, 21);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Senha";
            // 
            // yellowButton2
            // 
            this.yellowButton2.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowButton2.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.yellowButton2.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.yellowButton2.ButtonText = "&Salvar";
            this.yellowButton2.Location = new System.Drawing.Point(469, 320);
            this.yellowButton2.Name = "yellowButton2";
            this.yellowButton2.Size = new System.Drawing.Size(75, 26);
            this.yellowButton2.TabIndex = 8;
            this.yellowButton2.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.yellowButton2_Yb_Click);
            // 
            // yellowButton1
            // 
            this.yellowButton1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowButton1.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.yellowButton1.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.yellowButton1.ButtonText = "&Sair";
            this.yellowButton1.Location = new System.Drawing.Point(550, 320);
            this.yellowButton1.Name = "yellowButton1";
            this.yellowButton1.Size = new System.Drawing.Size(56, 26);
            this.yellowButton1.TabIndex = 7;
            this.yellowButton1.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.yellowButton1_Yb_Click);
            // 
            // dataGridPerm
            // 
            this.dataGridPerm.AllowUserToAddRows = false;
            this.dataGridPerm.AllowUserToDeleteRows = false;
            this.dataGridPerm.AllowUserToOrderColumns = true;
            this.dataGridPerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPerm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPerm.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPerm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridPerm.Location = new System.Drawing.Point(291, 7);
            this.dataGridPerm.Name = "dataGridPerm";
            this.dataGridPerm.ReadOnly = true;
            this.dataGridPerm.Size = new System.Drawing.Size(315, 307);
            this.dataGridPerm.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "pName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Permissão";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Habilitar";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.dataGridPerm);
            this.Controls.Add(this.yellowButton2);
            this.Controls.Add(this.yellowButton1);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.ckAtivo);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.labelX1);
            this.Name = "CadastroUsuarios";
            this.Size = new System.Drawing.Size(610, 351);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txNome;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckAtivo;
        private DevComponents.DotNetBar.Controls.TextBoxX txEmail;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txSenha;
        private DevComponents.DotNetBar.LabelX labelX3;
        private Especiais.YellowButton yellowButton1;
        private Especiais.YellowButton yellowButton2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridPerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
