using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("�rea de X: " + x.Area());
            Console.WriteLine("�rea de Y: " + y.Area());
        }
    }
}
