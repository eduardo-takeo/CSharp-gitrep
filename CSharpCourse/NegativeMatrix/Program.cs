using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = Convert.ToInt16(Console.ReadLine());
            
            int[,] matriz = new int[n, n];
            List<int> mainDiagonal = new List<int>();
            List<int> negativeNumbers = new List<int>();

            for (int line = 0; line < n; line++)
            {                
                string[] values = Console.ReadLine().Split(' ');
                for (int column = 0; column < n; column++)
                {
                    int number = int.Parse(values[column]);
                    matriz[line, column] = number;
                }                
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        mainDiagonal.Add(matriz[i, j]);
                    if (matriz[i, j] < 0)
                        negativeNumbers.Add(matriz[i, j]);
                }
            }

            Console.Write("Main diagonal: ");
            foreach (int item in mainDiagonal)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("Negative numbers: ");
            foreach (int item in negativeNumbers)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
