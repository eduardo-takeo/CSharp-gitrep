using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            Account firstAccount;

            Console.Write("Entre com o número da conta: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string owner = Convert.ToString(Console.ReadLine());
            Console.Write("Haverá depósito inicial? (s/n)");
            char firstDeposit = Convert.ToChar(Console.ReadLine());            

            while (firstDeposit != 's' && firstDeposit != 'n')
            {
                Console.WriteLine("Digite 's' para SIM e 'n' para NÃO");
                firstDeposit = Convert.ToChar(Console.ReadLine());
            }

            if (firstDeposit == 's')
            {
                Console.WriteLine("Insira o valor do depósito: ");
                value = Convert.ToDouble(Console.ReadLine());
                firstAccount = new Account(number, owner, value);                
            }
            else
            {
                firstAccount = new Account(number, owner);
            }

            firstAccount.GetAccountInformation();

            Console.WriteLine("Entre um valor para depósito: ");
            value = Convert.ToDouble(Console.ReadLine());            
            firstAccount.Deposit(value);

            firstAccount.GetAccountInformation();

            Console.Write("Entre com um valor para saque: ");
            value = Convert.ToDouble(Console.ReadLine());
            firstAccount.Withdraw(value);

            firstAccount.GetAccountInformation();

            Console.ReadLine();
        }
    }
}
