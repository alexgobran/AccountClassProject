using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClassProject {
    class Account {

        private static int nextAccountNmbr = 0;
        public int AccountNumber { get; private set; }
        private decimal Balance { get; set; } = 0.0m;
        public string Description { get; set; }
        public Customer CustomerInstance { get; set; } = null;

        //Constructor 
        //always public, do not return values. ( can eliminate return type) has to be named same as the Class name (Account)

        public Account(Customer customer): this() {
            this.CustomerInstance = customer;

        }
        private Account() {
            AccountNumber = ++nextAccountNmbr;
           
        }

        public Account(string Description, Customer customer): this() {
           this. Description = Description;
            this.CustomerInstance = customer;

        }


        //Method

        public void Transfer(Account acct, decimal amount) 
            {
            var withdrawSuccessful = this.Withdraw(amount);
            if(withdrawSuccessful)
            { acct.Deposit(amount);}
            

        }
        public decimal GetBalance() {
            return Balance;
        }//Method designed to make sure someone cant deposit a negative amount
        private bool CheckAmountIsPositive(decimal amount) {

            if(amount < 0)
            {
                Console.WriteLine("Amount cannot be negative");
                return false;
            }
            return true;
        }
        public bool Deposit(decimal Amount) {
            var valid = CheckAmountIsPositive(Amount);
            if (valid == true)
            { Balance += Amount;
                return true;
            }
            return false;
            
        }
               
                               
                public bool Withdraw(decimal Amount){
                 var valid = CheckAmountIsPositive(Amount);
                 if(valid == true) {
                if (Amount > Balance) {
                    Console.WriteLine("Insufficient funds!");
                }
                else
                {
                    Balance -= Amount;
                    return true;
                }
            }
            return false;
        }
            
        
    
    }
}
