using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClassProject {
   public class Savings: Account {

        private decimal IntRate = 0.01M;

        public string Print() {
            return base.Print() + $", Int Rate: {IntRate}";


        }

        //Method
        public decimal CalcInterest(int months) {

            return IntRate / 12 * months * GetBalance();
        }
        //void because there is no return 
        public void CalcAndPayInterest(int months) {
            var interest = CalcInterest(months);
            this.Deposit(interest);
        }
        public void SetInterestRate(decimal intRate) {
            this.IntRate = intRate; 
        }
        public Savings(decimal intRate, string Description, Customer customer)
            : base(Description, customer) {
            this.IntRate = intRate;
    
        }
    }
}
