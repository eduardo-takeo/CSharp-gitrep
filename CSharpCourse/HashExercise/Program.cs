using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();            

            //Curso A
            Console.WriteLine("O curso A possui quantos alunos? ");
            int studentsA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos a alunos do curso A: ");
            for (int i = 0; i < studentsA; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            //Curso B
            Console.WriteLine("O curso B possui quantos alunos? ");
            int studentsB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos a alunos do curso B: ");
            for (int i = 0; i < studentsB; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            //Curso C
            Console.WriteLine("O curso C possui quantos alunos? ");
            int studentsC = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos a alunos do curso C: ");
            for (int i = 0; i < studentsC; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            A.UnionWith(B);
            A.UnionWith(C);            
            Console.WriteLine("Total de alunos: " + A.Count);
            Console.ReadLine();
        }
    }
}
