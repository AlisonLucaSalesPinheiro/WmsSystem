namespace TccSenai
{
    partial class FrmGerenciarItens
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.rbtnAtivo = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.cboxNome = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.cboxPosicao = new System.Windows.Forms.ComboBox();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.btnTipo = new System.Windows.Forms.Button();
            this.cboxGrupo = new System.Windows.Forms.ComboBox();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.cboxUnidade = new System.Windows.Forms.ComboBox();
            this.cboxLeadtime = new System.Windows.Forms.ComboBox();
            this.cboxCustoEstoque = new System.Windows.Forms.ComboBox();
            this.cboxCustoUni = new System.Windows.Forms.ComboBox();
            this.cboxQuantidade = new System.Windows.Forms.ComboBox();
            this.cboxFornecedor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.cboxId = new System.Windows.Forms.ComboBox();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbWmsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbWmsDataSet = new TccSenai.dbWmsDataSet();
            this.tblProdutoTableAdapter = new TccSenai.dbWmsDataSetTableAdapters.tblProdutoTableAdapter();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.btnFornecedor);
            this.panel.Controls.Add(this.rbtnInativo);
            this.panel.Controls.Add(this.rbtnAtivo);
            this.panel.Controls.Add(this.label14);
            this.panel.Controls.Add(this.cboxNome);
            this.panel.Controls.Add(this.txtDescricao);
            this.panel.Controls.Add(this.btnPosicao);
            this.panel.Controls.Add(this.cboxPosicao);
            this.panel.Controls.Add(this.btnGrupo);
            this.panel.Controls.Add(this.btnTipo);
            this.panel.Controls.Add(this.cboxGrupo);
            this.panel.Controls.Add(this.cboxTipo);
            this.panel.Controls.Add(this.cboxUnidade);
            this.panel.Controls.Add(this.cboxLeadtime);
            this.panel.Controls.Add(this.cboxCustoEstoque);
            this.panel.Controls.Add(this.cboxCustoUni);
            this.panel.Controls.Add(this.cboxQuantidade);
            this.panel.Controls.Add(this.cboxFornecedor);
            this.panel.Controls.Add(this.label13);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(37, 95);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1279, 538);
            this.panel.TabIndex = 32;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Location = new System.Drawing.Point(1212, 112);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(26, 28);
            this.btnFornecedor.TabIndex = 33;
            this.btnFornecedor.Text = "+";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.rbtnInativo.ForeColor = System.Drawing.Color.Yellow;
            this.rbtnInativo.Location = new System.Drawing.Point(1072, 21);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(171, 41);
            this.rbtnInativo.TabIndex = 32;
            this.rbtnInativo.Text = "INATIVO";
            this.rbtnInativo.UseVisualStyleBackColor = true;
            // 
            // rbtnAtivo
            // 
            this.rbtnAtivo.AutoSize = true;
            this.rbtnAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAtivo.ForeColor = System.Drawing.Color.Yellow;
            this.rbtnAtivo.Location = new System.Drawing.Point(912, 21);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(137, 41);
            this.rbtnAtivo.TabIndex = 31;
            this.rbtnAtivo.Text = "ATIVO";
            this.rbtnAtivo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(739, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 37);
            this.label14.TabIndex = 30;
            this.label14.Text = "STATUS:";
            // 
            // cboxNome
            // 
            this.cboxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNome.FormattingEnabled = true;
            this.cboxNome.Location = new System.Drawing.Point(31, 112);
            this.cboxNome.Name = "cboxNome";
            this.cboxNome.Size = new System.Drawing.Size(689, 28);
            this.cboxNome.TabIndex = 29;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(31, 414);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1205, 103);
            this.txtDescricao.TabIndex = 28;
            // 
            // btnPosicao
            // 
            this.btnPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicao.Location = new System.Drawing.Point(1211, 311);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(26, 28);
            this.btnPosicao.TabIndex = 27;
            this.btnPosicao.Text = "+";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // cboxPosicao
            // 
            this.cboxPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPosicao.FormattingEnabled = true;
            this.cboxPosicao.Location = new System.Drawing.Point(1009, 311);
            this.cboxPosicao.Name = "cboxPosicao";
            this.cboxPosicao.Size = new System.Drawing.Size(199, 28);
            this.cboxPosicao.TabIndex = 26;
            // 
            // btnGrupo
            // 
            this.btnGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGrupo.Location = new System.Drawing.Point(905, 311);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(26, 28);
            this.btnGrupo.TabIndex = 25;
            this.btnGrupo.Text = "+";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnTipo
            // 
            this.btnTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTipo.Location = new System.Drawing.Point(438, 313);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(26, 28);
            this.btnTipo.TabIndex = 18;
            this.btnTipo.Text = "+";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // cboxGrupo
            // 
            this.cboxGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGrupo.FormattingEnabled = true;
            this.cboxGrupo.Location = new System.Drawing.Point(507, 311);
            this.cboxGrupo.Name = "cboxGrupo";
            this.cboxGrupo.Size = new System.Drawing.Size(392, 28);
            this.cboxGrupo.TabIndex = 24;
            // 
            // cboxTipo
            // 
            this.cboxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Location = new System.Drawing.Point(31, 313);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(401, 28);
            this.cboxTipo.TabIndex = 23;
            // 
            // cboxUnidade
            // 
            this.cboxUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUnidade.FormattingEnabled = true;
            this.cboxUnidade.Location = new System.Drawing.Point(1013, 208);
            this.cboxUnidade.Name = "cboxUnidade";
            this.cboxUnidade.Size = new System.Drawing.Size(224, 28);
            this.cboxUnidade.TabIndex = 22;
            // 
            // cboxLeadtime
            // 
            this.cboxLeadtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLeadtime.FormattingEnabled = true;
            this.cboxLeadtime.Location = new System.Drawing.Point(776, 208);
            this.cboxLeadtime.Name = "cboxLeadtime";
            this.cboxLeadtime.Size = new System.Drawing.Size(199, 28);
            this.cboxLeadtime.TabIndex = 21;
            // 
            // cboxCustoEstoque
            // 
            this.cboxCustoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCustoEstoque.FormattingEnabled = true;
            this.cboxCustoEstoque.Location = new System.Drawing.Point(521, 208);
            this.cboxCustoEstoque.Name = "cboxCustoEstoque";
            this.cboxCustoEstoque.Size = new System.Drawing.Size(199, 28);
            this.cboxCustoEstoque.TabIndex = 20;
            // 
            // cboxCustoUni
            // 
            this.cboxCustoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCustoUni.FormattingEnabled = true;
            this.cboxCustoUni.Location = new System.Drawing.Point(268, 208);
            this.cboxCustoUni.Name = "cboxCustoUni";
            this.cboxCustoUni.Size = new System.Drawing.Size(199, 28);
            this.cboxCustoUni.TabIndex = 19;
            // 
            // cboxQuantidade
            // 
            this.cboxQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxQuantidade.FormattingEnabled = true;
            this.cboxQuantidade.Location = new System.Drawing.Point(31, 208);
            this.cboxQuantidade.Name = "cboxQuantidade";
            this.cboxQuantidade.Size = new System.Drawing.Size(199, 28);
            this.cboxQuantidade.TabIndex = 18;
            // 
            // cboxFornecedor
            // 
            this.cboxFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFornecedor.FormattingEnabled = true;
            this.cboxFornecedor.Location = new System.Drawing.Point(782, 112);
            this.cboxFornecedor.Name = "cboxFornecedor";
            this.cboxFornecedor.Size = new System.Drawing.Size(426, 28);
            this.cboxFornecedor.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(27, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "DESCRIÇÃO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1006, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "POSIÇÃO DE ESTOQUE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(507, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "GRUPO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(27, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "TIPO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1011, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "UNIDADE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(774, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "LEADTIME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(513, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "CUSTO DE ESTOQUE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(270, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "CUSTO UNITÁRIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(27, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "QUANTIDADE ATUAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(783, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "FORNECEDOR ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "DADOS DE ITENS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "CÓD. ITEM";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1101, 653);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(215, 58);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Lime;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(850, 653);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(215, 58);
            this.btnAlterar.TabIndex = 34;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(599, 655);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(215, 58);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.White;
            this.btnPesquisa.BackgroundImage = global::TccSenai.Properties.Resources.lupa;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(225, 49);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(27, 29);
            this.btnPesquisa.TabIndex = 36;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // cboxId
            // 
            this.cboxId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblProdutoBindingSource, "idProduto", true));
            this.cboxId.DataSource = this.tblProdutoBindingSource;
            this.cboxId.DisplayMember = "idProduto";
            this.cboxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxId.FormattingEnabled = true;
            this.cboxId.Location = new System.Drawing.Point(37, 50);
            this.cboxId.Name = "cboxId";
            this.cboxId.Size = new System.Drawing.Size(182, 28);
            this.cboxId.TabIndex = 29;
            this.cboxId.ValueMember = "idProduto";
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "tblProduto";
            this.tblProdutoBindingSource.DataSource = this.dbWmsDataSetBindingSource;
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
            // tblProdutoTableAdapter
            // 
            this.tblProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGerenciarItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1353, 733);
            this.Controls.Add(this.cboxId);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Name = "FrmGerenciarItens";
            this.Text = "FrmGerenciarItens";
            this.Load += new System.EventHandler(this.FrmGerenciarItens_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWmsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.ComboBox cboxPosicao;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.ComboBox cboxGrupo;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.ComboBox cboxUnidade;
        private System.Windows.Forms.ComboBox cboxLeadtime;
        private System.Windows.Forms.ComboBox cboxCustoEstoque;
        private System.Windows.Forms.ComboBox cboxCustoUni;
        private System.Windows.Forms.ComboBox cboxQuantidade;
        private System.Windows.Forms.ComboBox cboxFornecedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cboxId;
        private dbWmsDataSet dbWmsDataSet;
        private System.Windows.Forms.BindingSource dbWmsDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private dbWmsDataSetTableAdapters.tblProdutoTableAdapter tblProdutoTableAdapter;
        private System.Windows.Forms.ComboBox cboxNome;
        private System.Windows.Forms.RadioButton rbtnInativo;
        private System.Windows.Forms.RadioButton rbtnAtivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnFornecedor;
    }
}