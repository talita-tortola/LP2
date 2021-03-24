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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }



        private void BtnInstHorista_Click(object sender, EventArgs e)
        {

            // Empregado objEmpregado = new Empregado();
            // não pode instanciar objeto de classe abstrata

            // criando o objeto, instanciando o objeto

            Horista objHorista = new Horista();

            // set

            objHorista.NomeEmpregado = TxtNome.Text;
            objHorista.Matricula = Convert.ToInt32(TxtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(TxtSalHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(TxtNumHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(TxtDataEntrada.Text);
            objHorista.DiasFalta = Convert.ToInt32(TxtDiasFaltas.Text);

            // get

            MessageBox.Show("Nome: " + "\n" + objHorista.NomeEmpregado + "\n\n" + 
                            "Matrícula: " + "\n" + objHorista.Matricula + "\n\n" + 
                            "Tempo Trabalho: " + "\n" + objHorista.TempoTrabalho().ToString() + "\n\n" + 
                            "Salário: " + "\n" + objHorista.SalarioBruto().ToString("N2"));

        }
    }
}
