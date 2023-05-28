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

namespace TccSenai
{
    public partial class FrmCadastrarItem : Form
    {
        public FrmCadastrarItem()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            dbWmsEntities1 db = new dbWmsEntities1();
            tblProduto produto = new tblProduto();
            produto.nomeProduto = txtNomeItem.Text;
            if (txtDescricao.Text != "")
            {
                produto.descricao = txtDescricao.Text;
            }
            produto.quantidade = 0;
            produto.idPosicao = Convert.ToInt32(cbPosicao.SelectedValue);
            produto.idUnidade = Convert.ToInt32(cbUnidade.SelectedValue);
            produto.idTipo = Convert.ToInt32(cbTipo.SelectedValue);
            produto.idGrupo = Convert.ToInt32(cbGrupoMateriais.SelectedValue);
            db.tblProduto.Add(produto);
            db.SaveChanges();


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastrarItem_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT idTipo,nomeTipo FROM tblTipo", DadosDaConexao.strConexao);
            DataTable tabelaTipo = new DataTable();
            adapter.Fill(tabelaTipo);
            cbTipo.DataSource = tabelaTipo;
            cbTipo.DisplayMember = "nomeTipo";
            cbTipo.ValueMember = "idTipo";

            SqlDataAdapter adapterGrupo = new SqlDataAdapter("SELECT tblGrupo.idGrupo, nomeGrupo From tblGrupo " +
                "inner join tblTipoGrupo ON tblTipoGrupo.idGrupo = tblGrupo.idGrupo " +
                "inner join tblTipo ON tblTipo.idTipo = tblTipoGrupo.idTipo  " +
                "Where tblTipo.idTipo =" + Convert.ToInt32(cbTipo.SelectedValue), DadosDaConexao.strConexao);
            DataTable tabelaGrupo = new DataTable();
            adapterGrupo.Fill(tabelaGrupo);
            cbGrupoMateriais.DataSource = tabelaGrupo;
            cbGrupoMateriais.DisplayMember = "nomeGrupo";
            cbGrupoMateriais.ValueMember = "idGrupo";

            SqlDataAdapter adapterUnidade = new SqlDataAdapter("SELECT idUnidade,nomeUnidade FROM tblUnidade", DadosDaConexao.strConexao);
            DataTable tabelaUnidade = new DataTable();
            adapterUnidade.Fill(tabelaUnidade);
            cbUnidade.DataSource = tabelaUnidade;
            cbUnidade.DisplayMember = "nomeUnidade";
            cbUnidade.ValueMember = "idUnidade";

            SqlDataAdapter adapterPosicao = new SqlDataAdapter("SELECT idPosicao,posicaoEstoq FROM tblPosicaoEstoque", DadosDaConexao.strConexao);
            DataTable tabelaPosicao = new DataTable();
            adapterPosicao.Fill(tabelaPosicao);
            cbPosicao.DataSource = tabelaPosicao;
            cbPosicao.DisplayMember = "posicaoEstoq";
            cbPosicao.ValueMember = "idPosicao";

            SqlDataAdapter adapterFornecedor = new SqlDataAdapter("SELECT idFornecedor,razaoSocial FROM tblFornecedor", DadosDaConexao.strConexao);
            DataTable tabelaFornecedor = new DataTable();
            adapterFornecedor.Fill(tabelaFornecedor);
            cbFornecedor.DataSource = tabelaFornecedor;
            cbFornecedor.DisplayMember = "razaoSocial";
            cbFornecedor.ValueMember = "idFornecedor";


        }

        private void cbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbGrupoMateriais.ResetText();
            SqlDataAdapter adapterGrupo = new SqlDataAdapter("SELECT tblGrupo.idGrupo,nomeGrupo From tblGrupo " +
                "inner join tblTipoGrupo ON tblTipoGrupo.idGrupo = tblGrupo.idGrupo " +
                "inner join tblTipo ON tblTipo.idTipo = tblTipoGrupo.idTipo  " +
                "Where tblTipo.idTipo =" + Convert.ToInt32(cbTipo.SelectedValue), DadosDaConexao.strConexao);


            DataTable tabelaGrupo = new DataTable();
            adapterGrupo.Fill(tabelaGrupo);
            cbGrupoMateriais.DataSource = tabelaGrupo;
            cbGrupoMateriais.DisplayMember = "nomeGrupo";
            cbGrupoMateriais.ValueMember = "idGrupo";
        }

        private void btnCadUnidade_Click(object sender, EventArgs e)
        {
            FrmCadastrarUnidade fCadastrarUnidade = new FrmCadastrarUnidade();
            fCadastrarUnidade.Show();
        }

        private void btnCadastrarPosicao_Click(object sender, EventArgs e)
        {
            FrmCadastrarPosicao fCadastrarPosicao = new FrmCadastrarPosicao();
            fCadastrarPosicao.Show();
        }

        private void btnCadastarBotao_Click(object sender, EventArgs e)
        {
            FrmCadastrarGrupo fCadastrar = new FrmCadastrarGrupo();
            fCadastrar.Show();
        }

        private void btnCadTipo_Click(object sender, EventArgs e)
        {
            FrmCadastrarTipo fCadastrarTipo = new FrmCadastrarTipo();
            fCadastrarTipo.Show();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {

        }
    }
}
