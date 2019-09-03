using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClassProject {
    public class Checking {

        private Account _account = null;

        public bool Deposit(decimal amount) {

           return _account.Deposit(amount);

      

        }

        public bool Withdrawel(decimal amount) {
            return _account.Withdraw(amount);

        }

        public decimal GetBalance() {
            return _account.GetBalance();
        }

        public bool WriteCheck(int checkNmbr, decimal amount) {
            return _account.Withdraw(amount);


        }


        public string Print() {
            return _account.Print();
        }
        //using composition instead of inheritance 
        public Checking(string description, Customer customer) {

            _account = new Account(description, customer);

        }
    }
}
