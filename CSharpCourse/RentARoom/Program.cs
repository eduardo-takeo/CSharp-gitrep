using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentARoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students gonna rent a room? ");
            int n = int.Parse(Console.ReadLine());

            Student[] Rooms = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Rooms[i] = new Student(name, email, roomNumber);
            }

            Console.WriteLine("Rooms busy: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Rooms[i].RoomNumber + ": " + Rooms[i].Name + " , " + Rooms[i].Email + " ; ");
            }

            Console.ReadLine();
        }
    }
}
