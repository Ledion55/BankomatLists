using BankomatLists;

namespace Bankomat2._0
{
    public class ATM
    {
        private Bank accountList;
        private List<BankAccount> bankAccounts;

        public ATM()
        {
            accountList = new Bank();
            bankAccounts = accountList.GetBankAccounts();
        }

        public void StartATM()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1: Gör en insättning på ett konto");
                Console.WriteLine("2: Gör ett uttag på ett konto");
                Console.WriteLine("3: Visa saldot på ditt konto");
                Console.WriteLine("4: Skriv ut en lista på alla kontonr och saldon");
                Console.WriteLine("5: Avsluta programmet");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    int accountChoice;
                        GetAccountChoice(bankAccounts, out accountChoice);
                        Console.WriteLine("Ange belopp");
                        int bankDeposit = Convert.ToInt32(Console.ReadLine());
                        bankAccounts[accountChoice].Insert(bankDeposit);
                        break;


                    case 2:
                        GetAccountChoice(bankAccounts, out accountChoice);
                        Console.WriteLine("Ange belopp");
                        int bankWithdraw = Convert.ToInt32(Console.ReadLine());
                        bankAccounts[accountChoice].Withdraw(bankWithdraw);
                        break;

                    case 3:
                        GetAccountChoice(bankAccounts, out accountChoice);
                        Console.WriteLine( $"Saldot på konto {accountChoice + 1} är nu {bankAccounts[accountChoice].Balance} kr");
                        Console.ReadKey();

                        break;

                    case 4:
                        Console.WriteLine(" Lisa på alla");
                        foreach (BankAccount account in bankAccounts)
                        {
                            Console.WriteLine($"Konto: {account.AccountNumber} Saldo: {account.Balance} kr ");
                        }
                        Console.ReadKey();
                        break;


                    case 5:
                        running = false;
                        Console.WriteLine("Du avslutar bankomaten");
                        accountList.SaveAccountsToFile();
                        break;

                   default:
                        Console.WriteLine("Felaktigt val, försök igen");
                        Console.ReadKey();
                        break;
                }

            }
        }

        private void GetAccountChoice(List<BankAccount> bankAccounts, out int accountChoice)
        {

            while (true)

            {
                Console.WriteLine("Välj ett konto mellan 1-10");

                accountChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                if (accountChoice >= 0 && accountChoice < bankAccounts.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel val");
                }
            }
        }



}
}