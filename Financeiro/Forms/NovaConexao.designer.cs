namespace Financeiro.Forms
{
    partial class NovaConexao
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txServidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txPorta = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btSalvar = new Financeiro.UserControls.Especiais.YellowButton();
            this.btCancelar = new Financeiro.UserControls.Especiais.YellowButton();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txTestDB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ckPersistSecInfo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Financeiro.Properties.Resources._1472929657_add_to_database;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txServidor
            // 
            // 
            // 
            // 
            this.txServidor.Border.Class = "TextBoxBorder";
            this.txServidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txServidor.Location = new System.Drawing.Point(215, 47);
            this.txServidor.Name = "txServidor";
            this.txServidor.PreventEnterBeep = true;
            this.txServidor.Size = new System.Drawing.Size(227, 20);
            this.txServidor.TabIndex = 2;
            this.txServidor.WatermarkText = "Ex.: localhost, Computador1, 192.168.0.105";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(155, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Servidor";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(155, 70);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Porta";
            // 
            // txPorta
            // 
            // 
            // 
            // 
            this.txPorta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txPorta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPorta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txPorta.Location = new System.Drawing.Point(216, 72);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(59, 20);
            this.txPorta.TabIndex = 3;
            this.txPorta.Value = 3306;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(155, 95);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Usuário";
            // 
            // txUsuario
            // 
            // 
            // 
            // 
            this.txUsuario.Border.Class = "TextBoxBorder";
            this.txUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txUsuario.Location = new System.Drawing.Point(215, 98);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.PreventEnterBeep = true;
            this.txUsuario.Size = new System.Drawing.Size(227, 20);
            this.txUsuario.TabIndex = 4;
            this.txUsuario.Text = "root";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(155, 121);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(54, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Senha";
            // 
            // txSenha
            // 
            // 
            // 
            // 
            this.txSenha.Border.Class = "TextBoxBorder";
            this.txSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txSenha.Location = new System.Drawing.Point(215, 124);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.PreventEnterBeep = true;
            this.txSenha.Size = new System.Drawing.Size(227, 20);
            this.txSenha.TabIndex = 5;
            // 
            // btSalvar
            // 
            this.btSalvar.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btSalvar.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btSalvar.ButtonText = "Salvar";
            this.btSalvar.Location = new System.Drawing.Point(354, 193);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(90, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btSalvar_Yb_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btCancelar.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btCancelar.ButtonText = "Cancelar";
            this.btCancelar.Location = new System.Drawing.Point(251, 193);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(97, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btCancelar_Yb_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(155, 18);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(54, 23);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "Nome";
            // 
            // txNome
            // 
            // 
            // 
            // 
            this.txNome.Border.Class = "TextBoxBorder";
            this.txNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNome.Location = new System.Drawing.Point(215, 21);
            this.txNome.Name = "txNome";
            this.txNome.PreventEnterBeep = true;
            this.txNome.Size = new System.Drawing.Size(227, 20);
            this.txNome.TabIndex = 1;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(155, 147);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(54, 23);
            this.labelX6.TabIndex = 16;
            this.labelX6.Text = "Test DB";
            // 
            // txTestDB
            // 
            // 
            // 
            // 
            this.txTestDB.Border.Class = "TextBoxBorder";
            this.txTestDB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txTestDB.Location = new System.Drawing.Point(215, 150);
            this.txTestDB.Name = "txTestDB";
            this.txTestDB.PreventEnterBeep = true;
            this.txTestDB.Size = new System.Drawing.Size(227, 20);
            this.txTestDB.TabIndex = 15;
            // 
            // ckPersistSecInfo
            // 
            this.ckPersistSecInfo.AutoSize = true;
            this.ckPersistSecInfo.Location = new System.Drawing.Point(325, 76);
            this.ckPersistSecInfo.Name = "ckPersistSecInfo";
            this.ckPersistSecInfo.Size = new System.Drawing.Size(119, 17);
            this.ckPersistSecInfo.TabIndex = 17;
            this.ckPersistSecInfo.Text = "Persist Security Info";
            this.ckPersistSecInfo.UseVisualStyleBackColor = true;
            // 
            // NovaConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(456, 228);
            this.Controls.Add(this.ckPersistSecInfo);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txTestDB);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txUsuario);
          //  this.Controls.Add(this.txPorta);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txServidor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaConexao";
            this.Text = "Adicionar Conexão";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txServidor;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput txPorta;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txUsuario;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txSenha;
        private UserControls.Especiais.YellowButton btSalvar;
        private UserControls.Especiais.YellowButton btCancelar;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txNome;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txTestDB;
        private System.Windows.Forms.CheckBox ckPersistSecInfo;
    }
}