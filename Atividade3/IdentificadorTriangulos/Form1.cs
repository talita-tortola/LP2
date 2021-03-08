using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentificadorTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtLadoA.Clear();
            TxtLadoB.Clear();
            TxtLadoC.Clear();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if (String.IsNullOrWhiteSpace(TxtLadoA.Text) ||
                String.IsNullOrWhiteSpace(TxtLadoB.Text) ||
                String.IsNullOrWhiteSpace(TxtLadoC.Text))
                MessageBox.Show("Insira os dados");
            else
            {
                ladoA = Convert.ToDouble(TxtLadoA.Text);
                ladoB = Convert.ToDouble(TxtLadoB.Text);
                ladoC = Convert.ToDouble(TxtLadoC.Text);

                // Equilátero = todos os lados iguais
                // Isósceles = apenas dois lados iguais
                // Escaleno = nenhum lado igual

                if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC)
                    MessageBox.Show("Triângulo Equilátero");
                if ((ladoA == ladoB && ladoA != ladoC) ||
                    (ladoA == ladoC && ladoA != ladoB) ||
                    (ladoB == ladoC && ladoB != ladoA))
                    MessageBox.Show("Triângulo Isósceles");
                if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                    MessageBox.Show("Triângulo Escaleno");
            }
        }

        private void TxtLadoA_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtLadoB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtLadoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLadoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLadoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLadoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
