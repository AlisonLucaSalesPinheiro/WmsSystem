
namespace TccSenai
{
    partial class FrmCadastrarTipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeTipo = new System.Windows.Forms.TextBox();
            this.dgvGrupoMateriais = new System.Windows.Forms.DataGridView();
            this.tblGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbWmsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbWmsDataSet = new TccSenai.dbWmsDataSet();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tblGrupoTableAdapter = new TccSenai.dbWmsDataSetTableAdapters.tblGrupoTableAdapter();
            this.selecaoGrupo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoMateriais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1571, 33);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CADASTRAR TIPO/MATERIAL";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 653);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 39);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsuarioLogado);
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(931, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 37);
            this.panel2.TabIndex = 3;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(3, 5);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(200, 24);
            this.lblUsuarioLogado.TabIndex = 2;
            this.lblUsuarioLogado.Text = "Nome Usuario Logado";
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImage = global::TccSenai.Properties.Resources.ConfigIcon;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(597, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(41, 37);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.UseVisualStyleBackColor = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "NOME TIPO";
            // 
            // txtNomeTipo
            // 
            this.txtNomeTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTipo.Location = new System.Drawing.Point(71, 90);
            this.txtNomeTipo.Name = "txtNomeTipo";
            this.txtNomeTipo.Size = new System.Drawing.Size(1428, 35);
            this.txtNomeTipo.TabIndex = 9;
            // 
            // dgvGrupoMateriais
            // 
            this.dgvGrupoMateriais.AllowUserToAddRows = false;
            this.dgvGrupoMateriais.AllowUserToDeleteRows = false;
            this.dgvGrupoMateriais.AutoGenerateColumns = false;
            this.dgvGrupoMateriais.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupoMateriais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupoMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecaoGrupo,
            this.idGrupo,
            this.nomeGrupoDataGridViewTextBoxColumn});
            this.dgvGrupoMateriais.DataSource = this.tblGrupoBindingSource;
            this.dgvGrupoMateriais.Location = new System.Drawing.Point(71, 310);
            this.dgvGrupoMateriais.Name = "dgvGrupoMateriais";
            this.dgvGrupoMateriais.RowHeadersVisible = false;
            this.dgvGrupoMateriais.Size = new System.Drawing.Size(1428, 242);
            this.dgvGrupoMateriais.TabIndex = 10;
            // 
            // tblGrupoBindingSource
            // 
            this.tblGrupoBindingSource.DataMember = "tblGrupo";
            this.tblGrupoBindingSource.DataSource = this.dbWmsDataSetBindingSource;
            // 
            // dbWmsDataSetBindingSource
            // 
            this.dbWmsDataSetBindingSource.DataSource = this.dbWmsDataSet;
            this.dbWmsDataSetBindingSource.Position = 0;
            // 
            // dbWmsDataSet
            // 
            this.dbWmsDataSet.DataSetName = "dbWmsDataSet";
            this.dbWmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(181)))), ((int)(((byte)(231)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Corbel Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1263, 571);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(234, 62);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(218)))), ((int)(((byte)(110)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Corbel Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(976, 571);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(234, 62);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(71, 169);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1428, 80);
            this.txtDescricao.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "DESCRIÇÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "GRUPOS MATERIAIS";
            // 
            // tblGrupoTableAdapter
            // 
            this.tblGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // selecaoGrupo
            // 
            this.selecaoGrupo.FalseValue = "false";
            this.selecaoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selecaoGrupo.HeaderText = "";
            this.selecaoGrupo.Name = "selecaoGrupo";
            this.selecaoGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selecaoGrupo.TrueValue = "true";
            this.selecaoGrupo.Width = 50;
            // 
            // idGrupo
            // 
            this.idGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idGrupo.DataPropertyName = "idGrupo";
            this.idGrupo.HeaderText = "COD. GRUPO";
            this.idGrupo.Name = "idGrupo";
            this.idGrupo.ReadOnly = true;
            this.idGrupo.Width = 200;
            // 
            // nomeGrupoDataGridViewTextBoxColumn
            // 
            this.nomeGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeGrupoDataGridViewTextBoxColumn.DataPropertyName = "nomeGrupo";
            this.nomeGrupoDataGridViewTextBoxColumn.HeaderText = "NOME GRUPO";
            this.nomeGrupoDataGridViewTextBoxColumn.Name = "nomeGrupoDataGridViewTextBoxColumn";
            this.nomeGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCadastrarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1571, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvGrupoMateriais);
            this.Controls.Add(this.txtNomeTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmCadastrarTipo";
            this.Text = "FrmCadastrarTipo";
            this.Load += new System.EventHandler(this.FrmCadastrarTipo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeTipo;
        private System.Windows.Forms.DataGridView dgvGrupoMateriais;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource dbWmsDataSetBindingSource;
        private dbWmsDataSet dbWmsDataSet;
        private System.Windows.Forms.BindingSource tblGrupoBindingSource;
        private dbWmsDataSetTableAdapters.tblGrupoTableAdapter tblGrupoTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecaoGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGrupoDataGridViewTextBoxColumn;
    }
}