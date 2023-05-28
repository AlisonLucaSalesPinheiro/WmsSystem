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
    public partial class FrmCadastrarTipo : Form
    {
        public FrmCadastrarTipo()
        {
            InitializeComponent();
        }

        private void FrmCadastrarTipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbWmsDataSet.tblGrupo' table. You can move, or remove it, as needed.
            this.tblGrupoTableAdapter.Fill(this.dbWmsDataSet.tblGrupo);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblGrupoTableAdapter.FillBy(this.dbWmsDataSet.tblGrupo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            dbWmsEntities1 db = new dbWmsEntities1();
            tblTipo tipo = new tblTipo();
            tblTipoGrupo tipoGrupo = new tblTipoGrupo();
            bool selecionado = false;
            tipo.nomeTipo = txtNomeTipo.Text;
            tipo.descricao = txtDescricao.Text;

            if (txtNomeTipo.Text != "" || txtDescricao.Text != "")
            {
                foreach (DataGridViewRow row in dgvGrupoMateriais.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["selecaoGrupo"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                     {
                        if (selecionado == false)
                        {
                            db.tblTipo.Add(tipo);
                            db.SaveChanges();
                        }
                        selecionado = true;
                        tipoGrupo.idGrupo = Convert.ToInt32(row.Cells["idGrupo"].Value);
                        tblTipo tipo2 = db.tblTipo.Where(x => x.nomeTipo == txtNomeTipo.Text).FirstOrDefault<tblTipo>();
                        tipoGrupo.idTipo = tipo2.idTipo;
                        db.tblTipoGrupo.Add(tipoGrupo);
                        db.SaveChanges();
                        // Por exemplo, você pode acessar os valores das outras células usando row.Cells["NomeDaOutraColuna"].Value
                    }
                }
            }
            else
            {

                MessageBox.Show("Favor preencher todos os campos", "WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (selecionado == false && txtNomeTipo.Text != "" && txtDescricao.Text != "")
            {
                MessageBox.Show("Favor selecionar os grupos no qual o cadastro estara relacionado", "WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
