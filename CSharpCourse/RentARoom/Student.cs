using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentARoom
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoomNumber { get; set; }

        public Student(string name, string email, int roomNumber)
        {
            Name = name;
            Email = email;
            RoomNumber = roomNumber;
        }
    }
}
