namespace Financeiro.Forms
{
    partial class Preparando
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbText = new DevComponents.DotNetBar.LabelX();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Controls.Add(this.progresso);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 133);
            this.panel1.TabIndex = 0;
            // 
            // lbText
            // 
            // 
            // 
            // 
            this.lbText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbText.ForeColor = System.Drawing.Color.Navy;
            this.lbText.Location = new System.Drawing.Point(22, 52);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(294, 23);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "optional";
            this.lbText.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(22, 81);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(294, 18);
            this.progresso.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelX1.ForeColor = System.Drawing.Color.Navy;
            this.labelX1.Location = new System.Drawing.Point(22, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(294, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Preparando ambiente";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Preparando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(346, 141);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Preparando";
            this.Text = "Preparando";
            this.Load += new System.EventHandler(this.Preparando_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.LabelX lbText;
        public System.Windows.Forms.ProgressBar progresso;
    }
}