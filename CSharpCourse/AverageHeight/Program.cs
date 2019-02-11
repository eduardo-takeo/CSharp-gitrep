using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double[] People = new double[n];

            for (int i = 0; i < n; i++)
            {
                People[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}
