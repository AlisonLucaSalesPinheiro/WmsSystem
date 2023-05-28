using System;
using System.Windows.Forms;

namespace TccSenai
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastrarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarItem fCadastrarItem = new FrmCadastrarItem();
            fCadastrarItem.Show();
        }

        private void unidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarUnidade fCadastrarUnidade = new FrmCadastrarUnidade();
            fCadastrarUnidade.Show();
        }

        private void posiçãoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarPosicao fCadastrarPosicao = new FrmCadastrarPosicao();
            fCadastrarPosicao.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarGrupo fCadastrar = new FrmCadastrarGrupo();
            fCadastrar.Show();
        }

        private void tipoMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarTipo fCadastrarTipo = new FrmCadastrarTipo();
            fCadastrarTipo.Show();
        }
    }
}
