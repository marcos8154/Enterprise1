namespace Financeiro.Util
{
    partial class Confirmacao
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
            this.btOK = new Financeiro.UserControls.Especiais.YellowButton();
            this.txMsg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSIM = new Financeiro.UserControls.Especiais.YellowButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btOK.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btOK.ButtonText = "&NÃO";
            this.btOK.Location = new System.Drawing.Point(407, 116);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(69, 26);
            this.btOK.TabIndex = 1;
            this.btOK.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btOK_Yb_Click);
            // 
            // txMsg
            // 
            this.txMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txMsg.BackColor = System.Drawing.Color.Lavender;
            // 
            // 
            // 
            this.txMsg.Border.Class = "TextBoxBorder";
            this.txMsg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txMsg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txMsg.Location = new System.Drawing.Point(96, 15);
            this.txMsg.Multiline = true;
            this.txMsg.Name = "txMsg";
            this.txMsg.PreventEnterBeep = true;
            this.txMsg.ReadOnly = true;
            this.txMsg.Size = new System.Drawing.Size(380, 93);
            this.txMsg.TabIndex = 10;
            this.txMsg.Text = "Mensagem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Financeiro.Properties.Resources.confirmacao;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 82);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btSIM
            // 
            this.btSIM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSIM.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSIM.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btSIM.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btSIM.ButtonText = "&SIM";
            this.btSIM.Location = new System.Drawing.Point(332, 116);
            this.btSIM.Name = "btSIM";
            this.btSIM.Size = new System.Drawing.Size(69, 26);
            this.btSIM.TabIndex = 5;
            this.btSIM.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btSIM_Yb_Click);
            // 
            // Confirmação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(488, 154);
            this.Controls.Add(this.btSIM);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txMsg);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirmação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmacao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Especiais.YellowButton btOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.Especiais.YellowButton btSIM;
    }
}