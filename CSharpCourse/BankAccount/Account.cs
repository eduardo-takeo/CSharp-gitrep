using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private int _number;
        public string Owner { get; set; }
        public double Balance { get; private set; } = 0;

        public Account()
        {

        }

        public Account(int number, string owner)
        {
            _number = number;
            Owner = owner;
        }

        public Account(int number, string owner, double balance)
        {
            _number = number;
            Owner = owner;
            Balance = balance;
        }
                
        public double Deposit(double value)
        {
            while (value <= 0)
            {
                Console.WriteLine("Insira um valor válido");
                value = Convert.ToDouble(Console.ReadLine());
            }

            Balance += value;
            return Balance;
        }

        public double Withdraw(double value)
        {
            while (value > Balance)
            {
                Console.WriteLine("Saldo insuficiente");
                value = Convert.ToDouble(Console.ReadLine());
            }
            Balance = (Balance - value) - 5;
            return Balance;
        }

        public void GetAccountInformation()
        {
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine($"Conta {_number}, Titular: {Owner}, Saldo: R${Balance}");
        }
    }
}
