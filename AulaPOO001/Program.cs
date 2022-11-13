using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Juka";
            funcionario.SalarioHora = 25;

            Console.WriteLine($"Nome: {funcionario.Nome}, Salário Hora: {funcionario.SalarioHora}, Salário Mensal: {funcionario.SalarioMensal()}, Horas Trabalhadas Mês: {funcionario.HorasMes()}");

            Professor professor = new Professor();
            professor.Nome = "Montanha";
            professor.HorasSemanais = 6;
            professor.SalarioHora = 25;

            Console.WriteLine($"Nome: {professor.Nome}, Salário Hora: {professor.SalarioHora}, Salário Mensal: {professor.SalarioMensal()}, Horas Trabalhadas Mês: {professor.HorasMes()}");


            Console.ReadKey();
        }
    }
}
