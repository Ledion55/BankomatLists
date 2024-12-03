using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat2._0
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }


        public BankAccount(int accountNumber, int balance = 0)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }


        public void Insert(int money)
        {

            if (money <= 0)
            {
                Console.WriteLine("Beloppet måste vara större än 0.");
                Console.ReadKey();
            }
            else
            {
                Balance += money;
                Console.WriteLine($"Du har nu satt in {money} kr på konto {AccountNumber}. Ditt nurvarande saldo är: {Balance}kr");
                Console.ReadKey();
            }



        }

        public void Withdraw(int money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Beloppet måste vara större än 0.");
                Console.ReadKey();
            }
            else if (money > Balance)
            {
                Console.WriteLine("Du har inte tillräckligt med pengar på kontot.");
                Console.ReadKey();
            }
            else
            {
                Balance -= money;
                Console.WriteLine($"Du har nu tagit ut {money} kr från konto {AccountNumber}. Ditt nuvarande saldo är: {Balance}kr");
                Console.ReadKey();
            }
        }

    }
}
