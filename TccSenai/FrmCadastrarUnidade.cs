using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccSenai
{
    public partial class FrmCadastrarUnidade : Form
    {
        public FrmCadastrarUnidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtAbreviacao.Text == "" || txtNomeUnidade.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos","WMS");
            }
            else
            {
                dbWmsEntities1 db = new dbWmsEntities1();
                tblUnidade unidade = new tblUnidade();
                unidade.nomeUnidade = txtNomeUnidade.Text;
                unidade.abreviacao = txtAbreviacao.Text;
                db.tblUnidade.Add(unidade);
                db.SaveChanges();
                MessageBox.Show("Cadastro Realizado", "WMS");
            }
        }
    }
}
