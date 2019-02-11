using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number of lines: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Insert number of columns: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    int value = int.Parse(values[j]);
                    matrix[i, j] = value;
                }
            }

            Console.WriteLine("What number should i search for? ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == number)
                    {
                        Console.WriteLine($"Position: {i}, {j}");
                        Console.WriteLine($"Up: {matrix[i - 1, j]}");
                        Console.WriteLine($"Right: {matrix[i, j + 1]}");
                        Console.WriteLine($"Down: {matrix[i + 1, j]}");
                        Console.WriteLine($"Left: {matrix[i, j - 1]}");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
