using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasse
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstMensalista_Click(object sender, EventArgs e)
        {

            // criar ou instanciar o objeto da classe Mensalista

            Mensalista objMensalista = new Mensalista();

            // set

            objMensalista.Matricula = Convert.ToInt32(TxtMatricula.Text);
            objMensalista.NomeEmpregado = TxtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(TxtDataEntrada.Text); // dd/mm/yyyy
            objMensalista.SalarioMensal = Convert.ToDouble(TxtSalMensal.Text);

            // get

            MessageBox.Show("Matrícula: " + "\n" + objMensalista.Matricula + "\n\n" +
                            "Nome: " + "\n" + objMensalista.NomeEmpregado + "\n\n" +
                            "Data Entrada: " + "\n" + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n\n" +
                            "Salário Bruto: " + "\n" + objMensalista.SalarioBruto().ToString("N2") + "\n\n" + 
                            "Tempo Empresa (dias): " + "\n" + objMensalista.TempoTrabalho());


        }

        private void BtnInstMenPar_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(TxtMatricula.Text),
                TxtNome.Text, Convert.ToDateTime(TxtDataEntrada.Text),
                Convert.ToDouble(TxtSalMensal.Text));

            // get

            MessageBox.Show("Matrícula: " + "\n" + objMensalista.Matricula + "\n\n" +
                            "Nome: " + "\n" + objMensalista.NomeEmpregado + "\n\n" +
                            "Data Entrada: " + "\n" + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n\n" +
                            "Salário Bruto: " + "\n" + objMensalista.SalarioBruto().ToString("N2") + "\n\n" +
                            "Tempo Empresa (dias): " + "\n" + objMensalista.TempoTrabalho());

        }
    }
}
