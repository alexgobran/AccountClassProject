using System;
using System.Collections.Generic;
using System.Text;
//Always starting with properties (the data) before doing methods
namespace AccountClassProject {
     public class Customer {
        //properties
           private static int nextIdNbr = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; } 
        public string State { get; set; }
        public decimal Sales { get; private set; } = 0;
        public bool Active { get; set; } = true;
        

        //Method called AddSales" giving sum of sales


        public decimal AddSales(decimal salesAmount) {
            var valid = CheckAmountPositive(salesAmount);
            if(valid == true)
            Sales += salesAmount;
            return Sales;
        }
        private void Initialize() {
            Id = ++nextIdNbr;

        }//METHODS

        //setting sales to start at 0
       
        private bool CheckAmountPositive(decimal amount) {
            if(amount < 0) {
                Console.WriteLine("Amount cannot be negative");
                    return false;
                    }
            return true;
        }

        public Customer(string name, string city, string state) {
            Name = name;
            State = state;
            City = city;
            Initialize();
        }
        public Customer() {
            Id = ++nextIdNbr;
            Initialize();


        }
    }
    }
