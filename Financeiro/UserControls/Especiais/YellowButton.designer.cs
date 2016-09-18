namespace Financeiro.UserControls.Especiais
{
    partial class YellowButton
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
            this.basePanel = new DevComponents.DotNetBar.PanelEx();
            this.baseButton = new DevComponents.DotNetBar.ButtonX();
            this.basePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.basePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.basePanel.Controls.Add(this.baseButton);
            this.basePanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(91, 27);
            this.basePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.basePanel.Style.BackColor1.Color = System.Drawing.Color.Lavender;
            this.basePanel.Style.BackColor2.Color = System.Drawing.Color.Lavender;
            this.basePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.basePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.basePanel.Style.CornerDiameter = 2;
            this.basePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.basePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.basePanel.Style.GradientAngle = 90;
            this.basePanel.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.basePanel.StyleMouseDown.BackColor1.Color = System.Drawing.Color.Gold;
            this.basePanel.StyleMouseDown.BackColor2.Color = System.Drawing.Color.Gold;
            this.basePanel.StyleMouseDown.CornerDiameter = 2;
            this.basePanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.basePanel.TabIndex = 0;
            // 
            // baseButton
            // 
            this.baseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.baseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.baseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.baseButton.Location = new System.Drawing.Point(3, 3);
            this.baseButton.Name = "baseButton";
            this.baseButton.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.baseButton.Size = new System.Drawing.Size(84, 20);
            this.baseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.baseButton.TabIndex = 1;
            this.baseButton.Text = "buttonX1";
            this.baseButton.Click += new System.EventHandler(this.baseButton_Click);
            // 
            // YellowButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basePanel);
            this.Name = "YellowButton";
            this.Size = new System.Drawing.Size(90, 26);
            this.basePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx basePanel;
        private DevComponents.DotNetBar.ButtonX baseButton;
    }
}
