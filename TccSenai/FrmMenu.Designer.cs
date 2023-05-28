
namespace TccSenai
{
    partial class FrmMenu
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posiçãoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMateriaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 748);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 39);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(884, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 37);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Usuario Logado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::TccSenai.Properties.Resources.ConfigIcon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(463, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MODULO ESTOQUE";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadstToolStripMenuItem,
            this.gerenciarToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.apuraçãoToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1390, 29);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadstToolStripMenuItem
            // 
            this.cadstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarItemToolStripMenuItem,
            this.unidadeToolStripMenuItem,
            this.posiçãoDeEstoqueToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.tipoMateriaisToolStripMenuItem});
            this.cadstToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cadstToolStripMenuItem.Name = "cadstToolStripMenuItem";
            this.cadstToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.cadstToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarItemToolStripMenuItem
            // 
            this.cadastrarItemToolStripMenuItem.Name = "cadastrarItemToolStripMenuItem";
            this.cadastrarItemToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.cadastrarItemToolStripMenuItem.Text = "Item";
            this.cadastrarItemToolStripMenuItem.Click += new System.EventHandler(this.cadastrarItemToolStripMenuItem_Click);
            // 
            // unidadeToolStripMenuItem
            // 
            this.unidadeToolStripMenuItem.Name = "unidadeToolStripMenuItem";
            this.unidadeToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.unidadeToolStripMenuItem.Text = "Unidade";
            this.unidadeToolStripMenuItem.Click += new System.EventHandler(this.unidadeToolStripMenuItem_Click);
            // 
            // posiçãoDeEstoqueToolStripMenuItem
            // 
            this.posiçãoDeEstoqueToolStripMenuItem.Name = "posiçãoDeEstoqueToolStripMenuItem";
            this.posiçãoDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.posiçãoDeEstoqueToolStripMenuItem.Text = "Posição de Estoque";
            this.posiçãoDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.posiçãoDeEstoqueToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.gruposToolStripMenuItem.Text = "Grupo/Materiais";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // tipoMateriaisToolStripMenuItem
            // 
            this.tipoMateriaisToolStripMenuItem.Name = "tipoMateriaisToolStripMenuItem";
            this.tipoMateriaisToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.tipoMateriaisToolStripMenuItem.Text = "Tipo/Materiais";
            this.tipoMateriaisToolStripMenuItem.Click += new System.EventHandler(this.tipoMateriaisToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // apuraçãoToolStripMenuItem
            // 
            this.apuraçãoToolStripMenuItem.Name = "apuraçãoToolStripMenuItem";
            this.apuraçãoToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.apuraçãoToolStripMenuItem.Text = "Apuração";
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.suporteToolStripMenuItem.Text = "Suporte";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImage = global::TccSenai.Properties.Resources.senai_logo_0_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1390, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posiçãoDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoMateriaisToolStripMenuItem;
    }
}

