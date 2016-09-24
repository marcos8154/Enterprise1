namespace Financeiro.UserControls.MdlAdministracao.Cadastros
{
    partial class CadastroGrupos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btSalvar = new Financeiro.UserControls.Especiais.YellowButton();
            this.btSair = new Financeiro.UserControls.Especiais.YellowButton();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acesso = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.inserir = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.alterar = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.excluir = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.rotina,
            this.acesso,
            this.inserir,
            this.alterar,
            this.excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGrid.Location = new System.Drawing.Point(3, 35);
            this.dataGrid.Name = "dataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.Size = new System.Drawing.Size(687, 386);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelX1.Location = new System.Drawing.Point(5, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Nome do grupo";
            // 
            // txNome
            // 
            // 
            // 
            // 
            this.txNome.Border.Class = "TextBoxBorder";
            this.txNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txNome.Location = new System.Drawing.Point(99, 6);
            this.txNome.MaxLength = 100;
            this.txNome.Name = "txNome";
            this.txNome.PreventEnterBeep = true;
            this.txNome.Size = new System.Drawing.Size(316, 23);
            this.txNome.TabIndex = 2;
            // 
            // btSalvar
            // 
            this.btSalvar.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btSalvar.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btSalvar.ButtonText = "&Salvar";
            this.btSalvar.Location = new System.Drawing.Point(528, 427);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(90, 26);
            this.btSalvar.TabIndex = 4;
            // 
            // btSair
            // 
            this.btSair.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ButtonMargin = new System.Windows.Forms.Padding(3);
            this.btSair.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btSair.ButtonText = "S&air";
            this.btSair.Location = new System.Drawing.Point(624, 427);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(66, 26);
            this.btSair.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // rotina
            // 
            this.rotina.HeaderText = "Rotina";
            this.rotina.Name = "rotina";
            this.rotina.ReadOnly = true;
            this.rotina.Width = 200;
            // 
            // acesso
            // 
            this.acesso.Checked = true;
            this.acesso.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.acesso.CheckValue = "N";
            this.acesso.HeaderText = "Acesso";
            this.acesso.Name = "acesso";
            this.acesso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acesso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // inserir
            // 
            this.inserir.Checked = true;
            this.inserir.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.inserir.CheckValue = "N";
            this.inserir.HeaderText = "Inserir";
            this.inserir.Name = "inserir";
            this.inserir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inserir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // alterar
            // 
            this.alterar.Checked = true;
            this.alterar.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.alterar.CheckValue = "N";
            this.alterar.HeaderText = "Alterar";
            this.alterar.Name = "alterar";
            this.alterar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alterar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // excluir
            // 
            this.excluir.Checked = true;
            this.excluir.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.excluir.CheckValue = "N";
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CadastroGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dataGrid);
            this.Name = "CadastroGrupos";
            this.Size = new System.Drawing.Size(693, 458);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txNome;
        private Especiais.YellowButton btSair;
        private Especiais.YellowButton btSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotina;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn acesso;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn inserir;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn alterar;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn excluir;
    }
}
