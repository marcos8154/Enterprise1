namespace Financeiro.Forms
{
    partial class TopClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopClient));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Conexões");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridAmbientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvwConexoes = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmbientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // dataGridAmbientes
            // 
            this.dataGridAmbientes.AllowUserToAddRows = false;
            this.dataGridAmbientes.AllowUserToDeleteRows = false;
            this.dataGridAmbientes.AllowUserToOrderColumns = true;
            this.dataGridAmbientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAmbientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridAmbientes.Location = new System.Drawing.Point(154, 68);
            this.dataGridAmbientes.Name = "dataGridAmbientes";
            this.dataGridAmbientes.ReadOnly = true;
            this.dataGridAmbientes.Size = new System.Drawing.Size(324, 245);
            this.dataGridAmbientes.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ambiente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // tvwConexoes
            // 
            this.tvwConexoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwConexoes.ImageIndex = 0;
            this.tvwConexoes.ImageList = this.imageList1;
            this.tvwConexoes.Location = new System.Drawing.Point(3, 68);
            this.tvwConexoes.Name = "tvwConexoes";
            treeNode1.Name = "conexoes";
            treeNode1.Text = "Conexões";
            this.tvwConexoes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvwConexoes.SelectedImageIndex = 0;
            this.tvwConexoes.Size = new System.Drawing.Size(145, 277);
            this.tvwConexoes.TabIndex = 3;
            this.tvwConexoes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwConexoes_NodeMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexãoToolStripMenuItem,
            this.ambienteToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // conexãoToolStripMenuItem
            // 
            this.conexãoToolStripMenuItem.Name = "conexãoToolStripMenuItem";
            this.conexãoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.conexãoToolStripMenuItem.Text = "Conexão";
            this.conexãoToolStripMenuItem.Click += new System.EventHandler(this.conexãoToolStripMenuItem_Click);
            // 
            // ambienteToolStripMenuItem
            // 
            this.ambienteToolStripMenuItem.Name = "ambienteToolStripMenuItem";
            this.ambienteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ambienteToolStripMenuItem.Text = "Ambiente";
            this.ambienteToolStripMenuItem.Click += new System.EventHandler(this.ambienteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 42);
            this.panel1.TabIndex = 5;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelX1.ForeColor = System.Drawing.Color.Teal;
            this.labelX1.Location = new System.Drawing.Point(3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(209, 34);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Doware NetLauncher";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TopClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvwConexoes);
            this.Controls.Add(this.dataGridAmbientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopClient";
            this.Text = "Doware NetLauncher 1.0.10";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmbientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridAmbientes;
        private System.Windows.Forms.TreeView tvwConexoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
    }
}