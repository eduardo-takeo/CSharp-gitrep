using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            string nomePessoa1 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idadePessoa1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            string nomePessoa2 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idadePessoa2 = Convert.ToInt32(Console.ReadLine());

            if (idadePessoa1 > idadePessoa2)
            {
                Console.WriteLine("Pessoa mais velha: " + nomePessoa1);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + nomePessoa2);
            }

            Console.WriteLine("Teste");

            Console.ReadLine();
        }
    }
}
