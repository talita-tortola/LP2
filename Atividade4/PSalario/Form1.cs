using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;

            double salarioBruto = 0;

            if ((txtNome.Text == "") || (txtNome.Text.Length < 5))
                MessageBox.Show("Nome inválido!");
            else if (!double.TryParse(mskbxSalBruto.Text, out salarioBruto)
                || salarioBruto <= 0)
                MessageBox.Show("Salário inválido!");
            else
            {
                double descINSS = 0;
                double descIRPF = 0;
                double salarioFamilia = 0;
                double salarioLiquido = 0;

                // cálculo do INSS

                if (salarioBruto < 800.48)
                {
                    txtAliINSS.Text = "7.65%";
                    descINSS = salarioBruto * 0.0765;
                }
                else if (salarioBruto < 1050.01)
                {
                    txtAliINSS.Text = "8.65%";
                    descINSS = salarioBruto * 0.0865;
                }
                else if (salarioBruto < 1400.78)
                {
                    txtAliINSS.Text = "9.00%";
                    descINSS = salarioBruto * 0.09;
                }
                else if (salarioBruto < 2801.57)
                {
                    txtAliINSS.Text = "11.00%";
                    descINSS = salarioBruto * 0.11;
                }
                else
                {
                    txtAliINSS.Text = "Teto";
                    descINSS = 308.17;
                }

                txtDescINSS.Text = descINSS.ToString("N2");

                // cálculo do IRPF

                if (salarioBruto < 1257.13)
                {
                    txtAliIRPF.Text = "ISENTO";
                    descIRPF = 0;
                }
                else if (salarioBruto < 2512.09)
                {
                    txtAliIRPF.Text = "15.0%";
                    descIRPF = salarioBruto * 0.15;
                }
                else
                {
                    txtAliIRPF.Text = "27.5%";
                    descIRPF = salarioBruto * 0.275;
                }

                txtDescIRPF.Text = descIRPF.ToString("N1");

                // cálculo do Salário Família

                if (salarioBruto < 435.53)
                {
                    salarioFamilia = Convert.ToDouble(cbxNumFilhos.SelectedItem) * 22.33;
                }
                else if (salarioBruto < 654.62)
                {
                    salarioFamilia = Convert.ToDouble(cbxNumFilhos.SelectedItem) * 15.74;
                }
                else
                {
                    salarioFamilia = 0;
                }

                txtSalFamilia.Text = salarioFamilia.ToString("N2");

                salarioLiquido = salarioBruto - descINSS - descIRPF + salarioFamilia;
                txtSalLiquido.Text = salarioLiquido.ToString("N2");

                // mensagem do Label

                string mensagem = "Os descontos do salário";

                if (rbtnFem.Checked && rbtnCasado.Checked)
                    mensagem = mensagem + "\n" + "da sra." +
                        txtNome.Text + "\n" + "(Casada e tem ";
                else if (rbtnFem.Checked && rbtnSolteiro.Checked)
                    mensagem = mensagem + "\n" + "da sra." +
                        txtNome.Text + "\n" + "(Solteira e tem ";
                else if (rbtnMasc.Checked && rbtnCasado.Checked)
                    mensagem = mensagem + "\n" + "do sr." +
                        txtNome.Text + "\n" + "(Casado e tem ";
                else if (rbtnMasc.Checked && rbtnSolteiro.Checked)
                    mensagem = mensagem + "\n" + "do sr." +
                        txtNome.Text + "\n" + "(Solteiro e tem ";

                mensagem = mensagem + cbxNumFilhos.SelectedItem.ToString() + " filhos/as)";

                lblMensagem.Text = mensagem;
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtAliINSS.Clear();
            txtAliIRPF.Clear();
            txtDescINSS.Clear();
            txtDescIRPF.Clear();
            txtNome.Clear();
            mskbxSalBruto.Clear();
            txtSalFamilia.Clear();
            txtSalLiquido.Clear();
            lblMensagem.Visible = false;
            rbtnCasado.Checked = true;
            rbtnFem.Checked = true;
            cbxNumFilhos.SelectedIndex = 0;


        }

        private void CbxFilhos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
