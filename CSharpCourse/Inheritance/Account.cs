using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Account
    {
        public int Number { get; set; }
        public string Owner { get; set; }

        public Account(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }
    }
}
