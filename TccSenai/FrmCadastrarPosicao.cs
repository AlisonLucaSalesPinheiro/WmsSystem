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
    public partial class FrmCadastrarPosicao : Form
    {
        public FrmCadastrarPosicao()
        {
            InitializeComponent();
        }

        private void AlterarPosicao_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                if ((sender as TextBox).Name == "txtRua")
                {
                    maskedTextBox1.Text = TrocarCaractere(maskedTextBox1.Text, Convert.ToChar(txtRua.Text), 0);
                }
                else
                {
                    if ((sender as TextBox).Name == "txtBloco")
                    {
                        maskedTextBox1.Text = TrocarCaractere(maskedTextBox1.Text, Convert.ToChar(txtBloco.Text), 2);
                    }
                    else
                    {
                        if ((sender as TextBox).Name == "txtAndar")
                        {
                            maskedTextBox1.Text = TrocarCaractere(maskedTextBox1.Text, Convert.ToChar(txtAndar.Text), 4);
                        }
                        else
                        {
                            maskedTextBox1.Text = TrocarCaractere(maskedTextBox1.Text, Convert.ToChar(txtApartamento.Text), 6);
                        }
                    }
                }
            }
        }

        private static string TrocarCaractere(string texto, char caractereNovo, int posicao)
        {
            char[] caracteres = texto.ToCharArray();
            for (int i = 0; i <= caracteres.Length; i++)
            {
                if (i == posicao)
                {
                    if (posicao == caracteres.Length)
                    {
                        caracteres[i - 1] = caractereNovo;
                    }
                    else
                    {
                        caracteres[i] = caractereNovo;
                    }
                }
            }
            return new string(caracteres);
        }

        private void TeclaPosicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tratar quando for digitado não numericos e apagar e inserir o digito automaticamente 
            if (char.IsNumber(e.KeyChar) && e.KeyChar != '0' || e.KeyChar == (char)8)
            {
                if ((sender as TextBox).Name == "txtRua")
                {
                    txtRua.ResetText();
                    txtRua.Text = e.KeyChar.ToString();
                }
                else
                {
                    if ((sender as TextBox).Name == "txtBloco")
                    {
                        txtBloco.ResetText();
                        txtBloco.Text = e.KeyChar.ToString();
                    }
                    else
                    {
                        if ((sender as TextBox).Name == "txtAndar")
                        {
                            txtAndar.ResetText();
                            txtAndar.Text = e.KeyChar.ToString();
                        }
                        else
                        {
                            txtApartamento.ResetText();
                            txtApartamento.Text = e.KeyChar.ToString();
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtAndar.Text!="" || txtBloco.Text != "" || txtAndar.Text != "" || txtApartamento.Text != "")
            {
                dbWmsEntities1 db = new dbWmsEntities1();
                tblPosicaoEstoque posicao = new tblPosicaoEstoque();
                posicao.rua = txtRua.Text;
                posicao.bloco = txtBloco.Text;
                posicao.andar = txtAndar.Text;
                posicao.apartamento = txtApartamento.Text;
                db.tblPosicaoEstoque.Add(posicao);
                db.SaveChanges();
                MessageBox.Show("Cadastro realizado", "WMS", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos","WMS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
