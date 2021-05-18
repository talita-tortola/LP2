using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade8
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void frmExercicio7_Load(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // o último dígito do meu RA é 3

            int N = 3;


            string[] nomesCompletos = new string[N];
            int[] qtdeChar = new int[N];

            string nomeEspaço = "";

            string nome = "";

            for (int x = 0; x < N; x++)
            {
                nome = Interaction.InputBox("Insira o " + (x + 1).ToString() +
                                "º nome: ","Entrada de Valores");

                nomesCompletos[x] = nome;
                nomeEspaço = nome.Replace(" ", "");
                qtdeChar[x] = nomeEspaço.Length;
            }

            for (int x = 0; x < N; x++)
            {
                lstbxNomes.Items.Add("O nome: " + nomesCompletos[x] +
                                ". Tem " + qtdeChar[x] + " caracteres.");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstbxNomes.Items.Clear();
        }
    }
}
