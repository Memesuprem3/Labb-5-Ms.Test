﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Projekt_i_grupp___Code_Crusades__SUT23_
{
    internal class Transfer : Customer
    { // behöver ändras om lite i customerklassen där kontonen finns eller mina source och destination för att träffa rätt.
        public decimal Balance { get; set; }
        public string SourceAccountType { get; set; }
        public string DestinationAccountType { get; set; }

        public Transfer(string sourceAccountType, string destinationAccountType, decimal balance): base("TransferCustomer", "", false)
        {
            SourceAccountType = sourceAccountType;
            DestinationAccountType = destinationAccountType;
            Balance = balance;
        }

        public void TransferMoney(Customer sourceCustomer)
        {
            // Hitta källkonto
            Accounts sourceAccount = sourceCustomer.Accounts.Find(acc => acc.Name == SourceAccountType);

            // Hitta målkonto
            Accounts destinationAccount = Accounts.Find(acc => acc.Name == DestinationAccountType);

            if (sourceAccount != null && destinationAccount != null && Balance > 0 && sourceAccount.Balance >= Balance)
            {
                sourceAccount.Balance -= Balance;
                destinationAccount.Balance += Balance;
                Console.WriteLine($"Överfört: {Balance} SEK från konto: {sourceAccount.Name} till kontot: {destinationAccount.Name}");
            }
            else
            {
                Console.WriteLine("Överföring misslyckades. Kontrollera att du har tillräckligt med täckning och att kontona är giltiga.");
            }
        }
    }
}
