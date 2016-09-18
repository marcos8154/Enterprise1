namespace Financeiro.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOk = new Financeiro.UserControls.Especiais.YellowButton();
            this.btCancelar = new Financeiro.UserControls.Especiais.YellowButton();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btEncerrar = new Financeiro.UserControls.Especiais.YellowButton();
            this.btLogin = new Financeiro.UserControls.Especiais.YellowButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txUsuario
            // 
            this.txUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            // 
            // 
            // 
            this.txUsuario.Border.Class = "TextBoxBorder";
            this.txUsuario.Border.CornerDiameter = 3;
            this.txUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txUsuario.Location = new System.Drawing.Point(326, 158);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.PreventEnterBeep = true;
            this.txUsuario.Size = new System.Drawing.Size(195, 25);
            this.txUsuario.TabIndex = 0;
            this.txUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txUsuario_KeyDown);
            // 
            // txSenha
            // 
            this.txSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            // 
            // 
            // 
            this.txSenha.Border.Class = "TextBoxBorder";
            this.txSenha.Border.CornerDiameter = 3;
            this.txSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txSenha.Location = new System.Drawing.Point(326, 194);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '•';
            this.txSenha.PreventEnterBeep = true;
            this.txSenha.Size = new System.Drawing.Size(195, 25);
            this.txSenha.TabIndex = 2;
            this.txSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txSenha_KeyDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(258, 160);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Usuário";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(258, 194);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Senha";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(227, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 358);
            this.panel1.TabIndex = 8;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelX3.Location = new System.Drawing.Point(8, 6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(382, 29);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Apollo Logon";
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Gold;
            this.line1.Location = new System.Drawing.Point(-1, 33);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(563, 10);
            this.line1.TabIndex = 1;
            this.line1.Text = "line1";
            this.line1.Thickness = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btOk);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.line3);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Controls.Add(this.labelX9);
            this.panel2.Controls.Add(this.labelX8);
            this.panel2.Controls.Add(this.labelX5);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txSenha);
            this.panel2.Controls.Add(this.txUsuario);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 313);
            this.panel2.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.ButtonFont = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btOk.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btOk.ButtonText = "OK";
            this.btOk.Location = new System.Drawing.Point(326, 251);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(74, 26);
            this.btOk.TabIndex = 14;
            this.btOk.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btOk_Yb_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.ButtonFont = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btCancelar.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btCancelar.ButtonText = "Encerrar";
            this.btCancelar.Location = new System.Drawing.Point(406, 251);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(116, 26);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btCancelar_Yb_Click);
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(423, 55);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(23, 2);
            this.line3.TabIndex = 12;
            this.line3.Text = "line3";
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(455, 55);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(56, 2);
            this.line2.TabIndex = 11;
            this.line2.Text = "line2";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("PT Serif", 11.25F);
            this.labelX9.Location = new System.Drawing.Point(428, 57);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(94, 16);
            this.labelX9.TabIndex = 10;
            this.labelX9.Text = "Enterprise 1";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("PT Serif", 16.25F);
            this.labelX8.Location = new System.Drawing.Point(432, 29);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(94, 28);
            this.labelX8.TabIndex = 9;
            this.labelX8.Text = "Apollo";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Gold;
            this.labelX5.Location = new System.Drawing.Point(313, 31);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(113, 48);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Ware";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(258, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(55, 48);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Do";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Financeiro.Properties.Resources.bussinessman;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Gold;
            this.labelX6.Location = new System.Drawing.Point(932, 527);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(66, 27);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Ware";
            // 
            // labelX7
            // 
            this.labelX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(899, 527);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(33, 27);
            this.labelX7.TabIndex = 9;
            this.labelX7.Text = "Do";
            // 
            // btEncerrar
            // 
            this.btEncerrar.ButtonFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrar.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btEncerrar.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btEncerrar.ButtonText = "Encerrar";
            this.btEncerrar.Location = new System.Drawing.Point(401, 268);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(120, 26);
            this.btEncerrar.TabIndex = 6;
            // 
            // btLogin
            // 
            this.btLogin.ButtonFont = new System.Drawing.Font("Arial", 9F);
            this.btLogin.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btLogin.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btLogin.ButtonText = "OK";
            this.btLogin.Location = new System.Drawing.Point(326, 268);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(69, 26);
            this.btLogin.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 562);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apollo Logon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txUsuario;
        private DevComponents.DotNetBar.Controls.TextBoxX txSenha;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.Especiais.YellowButton btEncerrar;
        private UserControls.Especiais.YellowButton btLogin;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line2;
        private UserControls.Especiais.YellowButton btOk;
        private UserControls.Especiais.YellowButton btCancelar;
    }
}