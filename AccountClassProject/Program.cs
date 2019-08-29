﻿using System;

namespace AccountClassProject {
    class Program {
        static void Main(string[] args) {

            var acct1 = new Account("Primary Checking");

          

            
            acct1.Deposit(1000);
            Console.WriteLine($"{acct1.AccountNumber}{acct1.Description} {acct1.GetBalance()}");
            acct1.Withdraw(5000);
            Console.WriteLine($"{acct1.AccountNumber}{acct1.Description} {acct1.GetBalance()}");
           
            Console.WriteLine($"{acct1.AccountNumber}{acct1.Description} {acct1.GetBalance()}");
            var balance = acct1.GetBalance();
            Console.WriteLine($"{ balance}");
           
            var acct2 = new Account("SecondaryChecking");
            acct1.Transfer(acct2, 2000);
            Console.WriteLine($"{acct1.AccountNumber}{acct1.Description} {acct1.GetBalance()}");

            Console.WriteLine($"{acct2.AccountNumber}{acct2.Description} {acct2.GetBalance()}");

        }
    }
}
