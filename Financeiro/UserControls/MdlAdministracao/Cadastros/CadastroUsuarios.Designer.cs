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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ckAtivo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.yellowButton2 = new Financeiro.UserControls.Especiais.YellowButton();
            this.yellowButton1 = new Financeiro.UserControls.Especiais.YellowButton();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelX1.Location = new System.Drawing.Point(11, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(41, 21);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nome";
            // 
            // txNome
            // 
            // 
            // 
            // 
            this.txNome.Border.Class = "TextBoxBorder";
            this.txNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNome.Location = new System.Drawing.Point(59, 9);
            this.txNome.MaxLength = 100;
            this.txNome.Name = "txNome";
            this.txNome.PreventEnterBeep = true;
            this.txNome.Size = new System.Drawing.Size(234, 20);
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
            this.ckAtivo.Location = new System.Drawing.Point(299, 7);
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
            this.txEmail.Location = new System.Drawing.Point(59, 35);
            this.txEmail.MaxLength = 100;
            this.txEmail.Name = "txEmail";
            this.txEmail.PreventEnterBeep = true;
            this.txEmail.Size = new System.Drawing.Size(234, 20);
            this.txEmail.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelX2.Location = new System.Drawing.Point(11, 35);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(41, 21);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Email";
            // 
            // txSenha
            // 
            // 
            // 
            // 
            this.txSenha.Border.Class = "TextBoxBorder";
            this.txSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txSenha.Location = new System.Drawing.Point(59, 61);
            this.txSenha.MaxLength = 100;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '•';
            this.txSenha.PreventEnterBeep = true;
            this.txSenha.Size = new System.Drawing.Size(234, 20);
            this.txSenha.TabIndex = 6;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelX3.Location = new System.Drawing.Point(11, 61);
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
            this.yellowButton2.Location = new System.Drawing.Point(193, 91);
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
            this.yellowButton1.Location = new System.Drawing.Point(274, 91);
            this.yellowButton1.Name = "yellowButton1";
            this.yellowButton1.Size = new System.Drawing.Size(75, 26);
            this.yellowButton1.TabIndex = 7;
            this.yellowButton1.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.yellowButton1_Yb_Click);
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
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
            this.Size = new System.Drawing.Size(358, 126);
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
    }
}
