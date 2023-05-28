
namespace TccSenai
{
    partial class FrmCadastrarItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGrupoMateriais = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPosicao = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.btnCadTipo = new System.Windows.Forms.Button();
            this.btnCadastarBotao = new System.Windows.Forms.Button();
            this.btnCadastrarPosicao = new System.Windows.Forms.Button();
            this.btnCadUnidade = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 39);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsuarioLogado);
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1065, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 37);
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
            this.btnConfig.Location = new System.Drawing.Point(463, 0);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1571, 33);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CADASTRAR ITEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOME DO PRODUTO";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItem.Location = new System.Drawing.Point(75, 93);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(1032, 26);
            this.txtNomeItem.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(75, 161);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1414, 152);
            this.txtDescricao.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "DESCRIÇÃO";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnit.Location = new System.Drawing.Point(1191, 93);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(298, 26);
            this.txtValorUnit.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1191, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "VALOR UNITARIO";
            // 
            // cbTipo
            // 
            this.cbTipo.DisplayMember = "idTipo";
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(75, 368);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(648, 28);
            this.cbTipo.TabIndex = 11;
            this.cbTipo.ValueMember = "idTipo";
            this.cbTipo.SelectionChangeCommitted += new System.EventHandler(this.cbTipo_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "TIPO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(75, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "UNIDADE";
            // 
            // cbUnidade
            // 
            this.cbUnidade.DisplayMember = "idUnidade";
            this.cbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(75, 439);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(648, 28);
            this.cbUnidade.TabIndex = 13;
            this.cbUnidade.ValueMember = "idUnidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(75, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "FORNECEDOR";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DisplayMember = "idFornecedor";
            this.cbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(75, 510);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(648, 28);
            this.cbFornecedor.TabIndex = 15;
            this.cbFornecedor.ValueMember = "idFornecedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(821, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "GRUPO DE MATERIAIS";
            // 
            // cbGrupoMateriais
            // 
            this.cbGrupoMateriais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGrupoMateriais.FormattingEnabled = true;
            this.cbGrupoMateriais.Location = new System.Drawing.Point(821, 368);
            this.cbGrupoMateriais.Name = "cbGrupoMateriais";
            this.cbGrupoMateriais.Size = new System.Drawing.Size(633, 28);
            this.cbGrupoMateriais.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(821, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "POSIÇÃO";
            // 
            // cbPosicao
            // 
            this.cbPosicao.DisplayMember = "idPosicao";
            this.cbPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosicao.FormattingEnabled = true;
            this.cbPosicao.Location = new System.Drawing.Point(821, 439);
            this.cbPosicao.Name = "cbPosicao";
            this.cbPosicao.Size = new System.Drawing.Size(633, 28);
            this.cbPosicao.TabIndex = 19;
            this.cbPosicao.ValueMember = "idPosicao";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(821, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "LEAD TIME";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(218)))), ((int)(((byte)(110)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Corbel Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(960, 566);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(234, 62);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(181)))), ((int)(((byte)(231)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Corbel Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1247, 566);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(234, 62);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(729, 510);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(28, 28);
            this.btnCadastrarFornecedor.TabIndex = 25;
            this.btnCadastrarFornecedor.Text = "+";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // btnCadTipo
            // 
            this.btnCadTipo.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadTipo.Location = new System.Drawing.Point(729, 368);
            this.btnCadTipo.Name = "btnCadTipo";
            this.btnCadTipo.Size = new System.Drawing.Size(28, 28);
            this.btnCadTipo.TabIndex = 26;
            this.btnCadTipo.Text = "+";
            this.btnCadTipo.UseVisualStyleBackColor = false;
            this.btnCadTipo.Click += new System.EventHandler(this.btnCadTipo_Click);
            // 
            // btnCadastarBotao
            // 
            this.btnCadastarBotao.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastarBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastarBotao.Location = new System.Drawing.Point(1461, 368);
            this.btnCadastarBotao.Name = "btnCadastarBotao";
            this.btnCadastarBotao.Size = new System.Drawing.Size(28, 28);
            this.btnCadastarBotao.TabIndex = 27;
            this.btnCadastarBotao.Text = "+";
            this.btnCadastarBotao.UseVisualStyleBackColor = false;
            this.btnCadastarBotao.Click += new System.EventHandler(this.btnCadastarBotao_Click);
            // 
            // btnCadastrarPosicao
            // 
            this.btnCadastrarPosicao.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPosicao.Location = new System.Drawing.Point(1461, 439);
            this.btnCadastrarPosicao.Name = "btnCadastrarPosicao";
            this.btnCadastrarPosicao.Size = new System.Drawing.Size(28, 28);
            this.btnCadastrarPosicao.TabIndex = 28;
            this.btnCadastrarPosicao.Text = "+";
            this.btnCadastrarPosicao.UseVisualStyleBackColor = false;
            this.btnCadastrarPosicao.Click += new System.EventHandler(this.btnCadastrarPosicao_Click);
            // 
            // btnCadUnidade
            // 
            this.btnCadUnidade.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUnidade.Location = new System.Drawing.Point(729, 439);
            this.btnCadUnidade.Name = "btnCadUnidade";
            this.btnCadUnidade.Size = new System.Drawing.Size(28, 28);
            this.btnCadUnidade.TabIndex = 30;
            this.btnCadUnidade.Text = "+";
            this.btnCadUnidade.UseVisualStyleBackColor = false;
            this.btnCadUnidade.Click += new System.EventHandler(this.btnCadUnidade_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(821, 510);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 28);
            this.textBox1.TabIndex = 31;
            // 
            // FrmCadastrarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1571, 690);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCadUnidade);
            this.Controls.Add(this.btnCadastrarPosicao);
            this.Controls.Add(this.btnCadastarBotao);
            this.Controls.Add(this.btnCadTipo);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbPosicao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGrupoMateriais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCadastrarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarItem";
            this.Load += new System.EventHandler(this.FrmCadastrarItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGrupoMateriais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbPosicao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.Button btnCadTipo;
        private System.Windows.Forms.Button btnCadastarBotao;
        private System.Windows.Forms.Button btnCadastrarPosicao;
        private System.Windows.Forms.Button btnCadUnidade;
        private System.Windows.Forms.TextBox textBox1;
    }
}