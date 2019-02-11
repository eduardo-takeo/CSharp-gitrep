using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMediaSalario
{
    class Program
    {
        static void Main(string[] args)
        {            
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = Convert.ToDouble(Console.ReadLine());

            double media = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine("Salário médio: " + media);

            Console.ReadLine();
        }
    }
}
