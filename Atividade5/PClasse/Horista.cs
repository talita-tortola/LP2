using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    class Horista : Empregado
    {

        // não existe herança múltipla
        // uma classe pode ter diversas subclasses
        // porém uma subclasse só pode ter uma classe de herança

        public double SalarioHora { get; set; }

        public double NumeroHora { get; set; }

        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora);
        }

        // override indica sobreescrever
        public override int TempoTrabalho()
        {
            // o método retorna um tipo span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (Convert.ToInt32(span.Days) - DiasFalta);
        }

    }
}
