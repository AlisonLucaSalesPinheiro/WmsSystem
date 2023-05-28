using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TccSenai
{
    public partial class FrmGerenciarItens : Form
    {
        public FrmGerenciarItens()
        {
            InitializeComponent();
        }

        private void FrmGerenciarItens_Load(object sender, EventArgs e)
        {
            cboxNome.FlatStyle = FlatStyle.Standard;
            // TODO: This line of code loads data into the 'dbWmsDataSet.tblProduto' table. You can move, or remove it, as needed.
            this.tblProdutoTableAdapter.Fill(this.dbWmsDataSet.tblProduto);
            // TODO: This line of code loads data into the 'dbWmsDataSet.tblProduto' table. You can move, or remove it, as needed.
            this.tblProdutoTableAdapter.Fill(this.dbWmsDataSet.tblProduto);
            // TODO: This line of code loads data into the 'dbWmsDataSet.tblFornecedorItem' table. You can move, or remove it, as needed.
            //this.tblFornecedorItemTableAdapter.Fill(this.dbWmsDataSet.tblFornecedorItem);
            // TODO: This line of code loads data into the 'dbWmsDataSet.tblProduto' table. You can move, or remove it, as needed.
           this.tblProdutoTableAdapter.Fill(this.dbWmsDataSet.tblProduto);
         
            this.cboxTipo.ResetText();
            this.cboxCustoEstoque.ResetText();
            this.cboxCustoUni.ResetText();  
            this.cboxFornecedor.ResetText();
            this.cboxGrupo.ResetText();
            this.cboxLeadtime.ResetText();
            this.cboxPosicao.ResetText();   
            this.cboxQuantidade.ResetText();
            this.cboxUnidade.ResetText(); 
            this.rbtnAtivo.Checked = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

            if (cboxId.Text != "" || cboxId.Text != null)
            {
                SqlDataAdapter pesquisa = new SqlDataAdapter("SELECT nomeProduto,quantidade," +
                "idPosicao,idUnidade,idTipo,idGrupo  FROM tblProduto", DadosDaConexao.strConexao);
                DataTable tabelaTipo = new DataTable();
                pesquisa.Fill(tabelaTipo);
                this.cboxNome.DataSource = tabelaTipo;
                this.cboxNome.DisplayMember = "nomeProduto";

                this.cboxQuantidade.DataSource = tabelaTipo;
                this.cboxQuantidade.DisplayMember = "quantidade";

                this.cboxPosicao.DataSource = tabelaTipo;
                this.cboxPosicao.DisplayMember = "idPosicao";

                this.cboxUnidade.DataSource = tabelaTipo;
                this.cboxUnidade.DisplayMember = "idUnidade";

                this.cboxTipo.DataSource = tabelaTipo;
                this.cboxTipo.DisplayMember = "idTipo";

                this.cboxGrupo.DataSource = tabelaTipo;
                this.cboxGrupo.DisplayMember = "idGrupo";
               panel.Enabled = true;

            }
            

        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            FrmCadastrarTipo fCadastrarTipo = new FrmCadastrarTipo();
            fCadastrarTipo.Show();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            FrmCadastrarGrupo fCadastrar = new FrmCadastrarGrupo();
            fCadastrar.Show();
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            FrmCadastrarPosicao fCadastrarPosicao = new FrmCadastrarPosicao();
            fCadastrarPosicao.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
