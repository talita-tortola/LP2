using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado; // globais

        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");

        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                resultado = num1 * num2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");

        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                if (num2 == 0)
                    MessageBox.Show("Não pode dividir por zero!");
                else
                {
                    resultado = num1 / num2;
                    txtResultado.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Números inválidos!");

        }

        private void buttonMais_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();

            txtNum1.Focus();
        }
    }
}
