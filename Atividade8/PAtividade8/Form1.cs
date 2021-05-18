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
using System.Collections;

namespace PAtividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "";
            string saida = "";

            for (int x = 0; x < vetor.Length; x++)
            {
                auxiliar = Interaction.InputBox("Entrar com o dado da posição: " + (x + 1).ToString(),
                            "Entrada de Dados");

                if (!int.TryParse(auxiliar, out vetor[x]))
                {
                    MessageBox.Show("Valor inválido!");
                    x--;
                }
                else
                {
                    saida = vetor[x] + "\n" + saida;
                }
            }

            MessageBox.Show(saida);

        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "";
            
            for (int x = 0; x < vetor.Length; x++)
            {
                auxiliar = Interaction.InputBox("Entrar com o dado da posição: " + (x + 1).ToString(),
                            "Entrada de Dados");

                if (!int.TryParse(auxiliar, out vetor[x]))
                {
                    MessageBox.Show("Valor inválido!");
                    x--;
                }
            }

            Array.Reverse(vetor);

            for (int x = 0; x < vetor.Length; x++)
                auxiliar += vetor[x] + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[] qtdeProduto = new double[10];
            double[] precoProduto = new double[10];

            string auxQtde = "";
            string auxPreco = "";

            for (int x = 0; x < 10; x++)
            {
                auxQtde = Interaction.InputBox("Insira a quatidade do " + (x + 1).ToString()
                            + "º produto: ", "Entrada de Dados");

                auxPreco = Interaction.InputBox("Insira o preço do " + (x + 1).ToString()
                            + "º produto: ", "Entrada de Dados");

                if (!double.TryParse(auxQtde, out qtdeProduto[x]))
                {
                    MessageBox.Show("Valor inválido!");
                    x--;
                }
                if (!double.TryParse(auxPreco, out precoProduto[x]))
                {
                    MessageBox.Show("Valor inválido!");
                    x--;
                }
            }

            double faturamento = 0;

            for (int x = 0; x < 10; x++)
            {
                faturamento += qtdeProduto[x] * precoProduto[x];
            }

            MessageBox.Show("O faturamento mensal do armazém é de: R$ " + faturamento.ToString("N2"));

        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose",
                                "Nelma", "Tobby" };

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;

            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }

            MessageBox.Show("O total vale: " + Total);
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();

            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            alunos.Remove("Otávio");

            string nomes = "";

            foreach (string x in alunos)
            {
                nomes += x + "\n";
            }

            MessageBox.Show(nomes);
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] soma = new double[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            string auxiliar = "";

            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    auxiliar = Interaction.InputBox("Entre com a " + (y + 1).ToString() +
                        "ª nota, do " + (x + 1).ToString() + "º aluno: ", "Entrada de Dados");

                    if (!double.TryParse(auxiliar, out notas[x,y]))
                    {
                        MessageBox.Show("Valor inválido!");
                        y--;
                    }
                    
                    soma[x] += notas[x, y];
                }
            }

            string mediaFinal = "";

            for (int x = 0; x < 20; x++)
            {
                mediaFinal += "Aluno " + (x + 1).ToString() + ": média: " + (soma[x] / 3).ToString("N1") + ". \n";
            }

            MessageBox.Show(mediaFinal);
        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            frmExercicio7 frmExercicio7 = new frmExercicio7();
            frmExercicio7.Show();
        }
    }
}
