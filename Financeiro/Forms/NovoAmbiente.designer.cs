namespace Financeiro.Forms
{
    partial class NovoAmbiente
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
            this.txNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbConexoes = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.yellowButton2 = new Financeiro.UserControls.Especiais.YellowButton();
            this.btCriar = new Financeiro.UserControls.Especiais.YellowButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txBase = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.yellowButton1 = new Financeiro.UserControls.Especiais.YellowButton();
            this.SuspendLayout();
            // 
            // txNome
            // 
            // 
            // 
            // 
            this.txNome.Border.Class = "TextBoxBorder";
            this.txNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(118, 39);
            this.txNome.Name = "txNome";
            this.txNome.PreventEnterBeep = true;
            this.txNome.Size = new System.Drawing.Size(252, 22);
            this.txNome.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 39);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Nome do ambiente";
            // 
            // cbConexoes
            // 
            this.cbConexoes.FormattingEnabled = true;
            this.cbConexoes.Location = new System.Drawing.Point(118, 12);
            this.cbConexoes.Name = "cbConexoes";
            this.cbConexoes.Size = new System.Drawing.Size(252, 21);
            this.cbConexoes.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Conexão";
            // 
            // yellowButton2
            // 
            this.yellowButton2.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowButton2.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.yellowButton2.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.yellowButton2.ButtonText = "Cancelar";
            this.yellowButton2.Location = new System.Drawing.Point(193, 109);
            this.yellowButton2.Name = "yellowButton2";
            this.yellowButton2.Size = new System.Drawing.Size(90, 26);
            this.yellowButton2.TabIndex = 1;
            // 
            // btCriar
            // 
            this.btCriar.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriar.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btCriar.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btCriar.ButtonText = "Criar";
            this.btCriar.Location = new System.Drawing.Point(289, 109);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(81, 26);
            this.btCriar.TabIndex = 0;
            this.btCriar.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btCriar_Yb_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 66);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Base";
            // 
            // txBase
            // 
            // 
            // 
            // 
            this.txBase.Border.Class = "TextBoxBorder";
            this.txBase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBase.Location = new System.Drawing.Point(118, 67);
            this.txBase.Name = "txBase";
            this.txBase.PreventEnterBeep = true;
            this.txBase.Size = new System.Drawing.Size(252, 22);
            this.txBase.TabIndex = 6;
            // 
            // yellowButton1
            // 
            this.yellowButton1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowButton1.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.yellowButton1.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.yellowButton1.ButtonText = "buttonX1";
            this.yellowButton1.Location = new System.Drawing.Point(280, 110);
            this.yellowButton1.Name = "yellowButton1";
            this.yellowButton1.Size = new System.Drawing.Size(90, 26);
            this.yellowButton1.TabIndex = 8;
            // 
            // NovoAmbiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(382, 148);
            this.Controls.Add(this.yellowButton1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txBase);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbConexoes);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoAmbiente";
            this.Text = "Novo Ambiente";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Especiais.YellowButton btCriar;
        private UserControls.Especiais.YellowButton yellowButton2;
        private DevComponents.DotNetBar.Controls.TextBoxX txNome;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cbConexoes;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txBase;
        private UserControls.Especiais.YellowButton yellowButton1;
    }
}