using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MskbxAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void MskbxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MskbxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            MskbxAltura.Clear();
            MskbxPeso.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double pesoIdeal, altura, pesoAtual;

            altura = Convert.ToDouble(MskbxAltura.Text);
            pesoAtual = Convert.ToDouble(MskbxPeso.Text);

            if (RbtnMasculino.Checked)
                pesoIdeal = Math.Round((72.7 * altura) - 58, 2);
            else
                pesoIdeal = Math.Round((62.1 * altura) - 44.7, 2);

            if (RbtnMasculino.Checked)
            {
                if (pesoIdeal < pesoAtual)
                    MessageBox.Show("Tem que maneirar na alimentação \n"
                        + "e fazer uns exercícios!");
                else if (pesoIdeal == pesoAtual)
                    MessageBox.Show("Continue assim!");
                else if (pesoIdeal > pesoAtual)
                    MessageBox.Show("Precisa se alimentar mais \n" +
                        "e fazer uns exercícios!");
            }
            else
            {
                if (pesoIdeal < pesoAtual)
                    MessageBox.Show("Tem que maneirar na alimentação \n"
                        + "e fazer uns exercícios!");
                else if (pesoIdeal == pesoAtual)
                    MessageBox.Show("Continue assim!");
                else if (pesoIdeal > pesoAtual)
                    MessageBox.Show("Precisa se alimentar mais \n" +
                        "e fazer uns exercícios!");
            }

        }


        private void MskbxPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
