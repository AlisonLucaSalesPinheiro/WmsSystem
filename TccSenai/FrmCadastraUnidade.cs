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
    public partial class FrmCadastraUnidade : Form
    {
        public FrmCadastraUnidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtAbreviacao.Text == "" || txtUnidade.Text == "")
            {
                MessageBox.Show("Favor Preencher todos os campos", "WMS-AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbWmsEntities db = new dbWmsEntities();
                tblUnidade unidade = new tblUnidade();
                unidade.nomeUnidade = txtUnidade.Text;
                unidade.abreviacao = txtAbreviacao.Text;
                db.tblUnidade.Add(unidade);
                db.SaveChanges();
            }
        }
    }
}
