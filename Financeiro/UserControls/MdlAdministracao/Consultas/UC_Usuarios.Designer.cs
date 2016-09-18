namespace Financeiro.UserControls.MdlAdministracao.Consultas
{
    partial class UC_Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridUsuarios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPermissoes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txPesquisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ckInativos = new System.Windows.Forms.CheckBox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btSair = new Financeiro.UserControls.Especiais.YellowButton();
            this.btExcluir = new Financeiro.UserControls.Especiais.YellowButton();
            this.btNovo = new Financeiro.UserControls.Especiais.YellowButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPermissoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            this.dataGridUsuarios.AllowUserToOrderColumns = true;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridUsuarios.Location = new System.Drawing.Point(3, 31);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.Size = new System.Drawing.Size(481, 441);
            this.dataGridUsuarios.TabIndex = 0;
            this.dataGridUsuarios.SelectionChanged += new System.EventHandler(this.dataGridUsuarios_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // dataGridPermissoes
            // 
            this.dataGridPermissoes.AllowUserToAddRows = false;
            this.dataGridPermissoes.AllowUserToDeleteRows = false;
            this.dataGridPermissoes.AllowUserToOrderColumns = true;
            this.dataGridPermissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPermissoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPermissoes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPermissoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridPermissoes.Location = new System.Drawing.Point(490, 31);
            this.dataGridPermissoes.Name = "dataGridPermissoes";
            this.dataGridPermissoes.Size = new System.Drawing.Size(297, 441);
            this.dataGridPermissoes.TabIndex = 1;
            this.dataGridPermissoes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPermissoes_CellValueChanged);
            // 
            // txPesquisa
            // 
            // 
            // 
            // 
            this.txPesquisa.Border.Class = "TextBoxBorder";
            this.txPesquisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txPesquisa.Location = new System.Drawing.Point(5, 4);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.PreventEnterBeep = true;
            this.txPesquisa.Size = new System.Drawing.Size(305, 21);
            this.txPesquisa.TabIndex = 2;
            // 
            // ckInativos
            // 
            this.ckInativos.AutoSize = true;
            this.ckInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ckInativos.Location = new System.Drawing.Point(351, 7);
            this.ckInativos.Name = "ckInativos";
            this.ckInativos.Size = new System.Drawing.Size(163, 20);
            this.ckInativos.TabIndex = 6;
            this.ckInativos.Text = "Exibir usuários inativos";
            this.ckInativos.UseVisualStyleBackColor = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "pName";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Permissão";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Habilitado";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // btSair
            // 
            this.btSair.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btSair.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btSair.ButtonText = "&Sair";
            this.btSair.Location = new System.Drawing.Point(716, 478);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(71, 24);
            this.btSair.TabIndex = 5;
            // 
            // btExcluir
            // 
            this.btExcluir.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btExcluir.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btExcluir.ButtonText = "&Excluir";
            this.btExcluir.Location = new System.Drawing.Point(640, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(71, 24);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Yb_Click += new Financeiro.UserControls.Especiais.YellowButton.YB_Click(this.btExcluir_Yb_Click);
            // 
            // btNovo
            // 
            this.btNovo.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btNovo.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btNovo.ButtonText = "&Novo";
            this.btNovo.Location = new System.Drawing.Point(717, 3);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(71, 24);
            this.btNovo.TabIndex = 3;
            // 
            // UC_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.ckInativos);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.dataGridPermissoes);
            this.Controls.Add(this.dataGridUsuarios);
            this.Name = "UC_Usuarios";
            this.Size = new System.Drawing.Size(792, 508);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPermissoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridPermissoes;
        private DevComponents.DotNetBar.Controls.TextBoxX txPesquisa;
        private Especiais.YellowButton btNovo;
        private Especiais.YellowButton btExcluir;
        private Especiais.YellowButton btSair;
        private System.Windows.Forms.CheckBox ckInativos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}
