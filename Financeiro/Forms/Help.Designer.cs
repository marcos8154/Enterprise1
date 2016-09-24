namespace Financeiro.Forms
{
    partial class Help
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
            this.txConteudo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridCampos = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Financeiro.Properties.Resources.confirmacao;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txConteudo
            // 
            this.txConteudo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txConteudo.Border.Class = "TextBoxBorder";
            this.txConteudo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txConteudo.Location = new System.Drawing.Point(112, 13);
            this.txConteudo.Multiline = true;
            this.txConteudo.Name = "txConteudo";
            this.txConteudo.PreventEnterBeep = true;
            this.txConteudo.ReadOnly = true;
            this.txConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txConteudo.Size = new System.Drawing.Size(585, 220);
            this.txConteudo.TabIndex = 100;
            // 
            // dataGridCampos
            // 
            this.dataGridCampos.AllowUserToAddRows = false;
            this.dataGridCampos.AllowUserToDeleteRows = false;
            this.dataGridCampos.AllowUserToOrderColumns = true;
            this.dataGridCampos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCampos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCampos.Location = new System.Drawing.Point(7, 239);
            this.dataGridCampos.Name = "dataGridCampos";
            this.dataGridCampos.ReadOnly = true;
            this.dataGridCampos.RowHeadersVisible = false;
            this.dataGridCampos.Size = new System.Drawing.Size(690, 205);
            this.dataGridCampos.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("PT Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelX1.Location = new System.Drawing.Point(618, 450);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(26, 23);
            this.labelX1.TabIndex = 101;
            this.labelX1.Text = "Do";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("PT Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelX2.ForeColor = System.Drawing.Color.Gold;
            this.labelX2.Location = new System.Drawing.Point(643, 450);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 102;
            this.labelX2.Text = "Ware";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 476);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dataGridCampos);
            this.Controls.Add(this.txConteudo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txConteudo;
        private System.Windows.Forms.DataGridView dataGridCampos;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}