﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Projekt_i_grupp___Code_Crusades__SUT23_
{
    internal class SavingsAccount : Accounts
    {
        public decimal InterestRate { get; private set; }
        public SavingsAccount(decimal interestRate, string name, decimal balance) : base(name, balance)
        {

            InterestRate = interestRate;

        }
       
        public static void CreateSavingsAccount(Customer currentuser)
        {
            decimal insert = 10000;
            string name = "Annas Sparkonto";
            decimal interestRate = 5;
            currentuser.Accounts.Add(new SavingsAccount(interestRate, name, insert));
        }
    }
}