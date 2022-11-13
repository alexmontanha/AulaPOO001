using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO001
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double SalarioHora { get; set; }
        public virtual double HorasMes()
        {
            int DiasUteis = 20;
            int HorasDia = 8;
            return DiasUteis * HorasDia;
        }

        public double SalarioMensal()
        {
            return HorasMes() * SalarioHora;
        }
    }

    public class Professor: Funcionario
    {
        public double HorasSemanais { get; set; }

        public override double HorasMes()
        {
            double horasMes = HorasSemanais * 4.5;
            return horasMes;
        }
    }
}
