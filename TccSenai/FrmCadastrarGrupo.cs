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
    public partial class FrmCadastrarGrupo : Form
    {
        public FrmCadastrarGrupo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeGrupo.Text == "" || txtDescricao.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos", "WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dbWmsEntities1 db = new dbWmsEntities1();
                tblGrupo grupo = new tblGrupo();
                grupo.nomeGrupo = txtNomeGrupo.Text;
                grupo.descricao = txtDescricao.Text;
                db.tblGrupo.Add(grupo);
                db.SaveChanges();
                MessageBox.Show("Cadastro realizado", "WMS");
            }
        }
    }
}
