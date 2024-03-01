using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUygulaması
{
    internal class Customer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Pin { get; set; }
        public long CardNumber { get; set; }
        public decimal AccountBalance { get; set; }

        
        public Customer(string firstName, string lasName, int pin, long cardNumber, decimal accountBalance)
        {
            FirstName = firstName;
            LastName = lasName;
            Pin = pin;
            CardNumber = cardNumber;
            AccountBalance = accountBalance;
        }
    }
 }
