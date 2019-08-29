using System;

namespace AccountClassProject {
    class Go {
        static void Main(string[] args) {

            var cust1 = new Customer();
            cust1.Name = "New Customer";


            var acct1 = new Account("Primary Checking ", cust1);
            acct1.Deposit(2);
            


            var acct2 = new Account("Secondary Checking ", cust1);

            acct2.Deposit(1000);

            cust1.Name = "1st Customer";

            var acct3 = new Account("primary Savings ", cust1);
            acct3.Deposit(50000);



            //creating Array that has a collection of account instances 

            var accounts = new Account[] { acct1, acct2, acct3 };
            var AccountTotal = 0M;

            foreach(var account in accounts)
            {
                AccountTotal += account.GetBalance();
                Console.WriteLine($"{account.AccountNumber} {account.Description}"
             + $"{account.GetBalance()} {account.CustomerInstance.Name}");

            }

            Console.WriteLine($"Total of all Accounts is {AccountTotal}");

        }
    }
}
