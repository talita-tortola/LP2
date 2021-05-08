using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {

            int cont = 0;
            
            for (var i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if (char.IsNumber(rchtxtTexto.Text[i]))
                    cont += 1;
            }

            MessageBox.Show("Quantidade de números: " + cont);

        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int posicao = cont - 1;
            string espaco = rchtxtTexto.Text;

            if (espaco == "")
            {
                MessageBox.Show("Está todo em branco!");
            }
            else
            {
                while (posicao <= 0)
                {
                    if (!char.IsWhiteSpace(rchtxtTexto.Text[cont]))
                    {
                        cont += 1;
                    }
                    else
                    {
                        posicao = cont;
                    }
                }

                MessageBox.Show("O primeiro espaço em branco está na posição de número: " + posicao);

            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach (char letra in rchtxtTexto.Text)
            {
                if (char.IsLetter(letra))
                    cont += 1;
            }

            MessageBox.Show("Quantidade de Letras: " + cont);

        }
    }
}
