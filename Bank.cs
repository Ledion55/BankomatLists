using Bankomat2._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bankomat2._0
{
    internal class Bank
    {
        private List<BankAccount> bankAccounts;
        private string filePath = "bankaccounts.json";

        public Bank()
        {
            if (File.Exists(filePath))
            {
                LoadAcountsFromFile();
            }
            else
            {
                bankAccounts = new List<BankAccount>();

                bankAccounts.Add(new BankAccount(1));
                bankAccounts.Add(new BankAccount(2));
                bankAccounts.Add(new BankAccount(3));
                bankAccounts.Add(new BankAccount(4));
                bankAccounts.Add(new BankAccount(5));
                bankAccounts.Add(new BankAccount(6));
                bankAccounts.Add(new BankAccount(7));
                bankAccounts.Add(new BankAccount(8));
                bankAccounts.Add(new BankAccount(9));
                bankAccounts.Add(new BankAccount(10));


            }
        }

        public List<BankAccount> GetBankAccounts()
        {
            return bankAccounts;
        }

        public void SaveAccountsToFile()
        {
            string jsonstring = JsonSerializer.Serialize(bankAccounts);
            System.IO.File.WriteAllText(filePath, jsonstring);
        }

        public void LoadAcountsFromFile()
        {
            string jsonstring2 = System.IO.File.ReadAllText(filePath);
            List<BankAccount> bankAccounts1 = JsonSerializer.Deserialize<List<BankAccount>>(jsonstring2);

        }
    }
}
