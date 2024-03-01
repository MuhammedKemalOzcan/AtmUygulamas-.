using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUygulaması
{
    internal class Atm
    {
        private Customer currentCustomer;
        public bool isLoggedIn;
        
        public Atm()
        {
            
            Customer sampleCustomer = new Customer("Current", "User", 2543, 1234567890123456, 350);  
            currentCustomer = sampleCustomer;
            isLoggedIn = false; 
        }

        
        public void Login()
        {
            
            Console.Write("Please enter your card number:");
            long cardNumber = long.Parse(Console.ReadLine());

            Console.Write("Please enter your pin:");
            int pin = int.Parse(Console.ReadLine());
            if (currentCustomer.CardNumber == cardNumber && currentCustomer.Pin == pin)
            {
                Console.WriteLine($"Welcome {currentCustomer.FirstName}  {currentCustomer.LastName} ");
                isLoggedIn = true;  
            }
            else
            {
                Console.WriteLine("You have entered wrong cardnumber or pin!");

            }
        }

        
        public void Transaction()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("You cannot make transactions without logging in!");
                return;
            }

            Console.WriteLine("Please select the action you want to perform.");
            Console.WriteLine("1. Withdrawal");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Show balance");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please Enter the amount you want to withdraw");
                    decimal withDrawAmount = decimal.Parse(Console.ReadLine());
                    WithDraw(withDrawAmount);
                    break;
                case 2:
                    Console.WriteLine("Please enter the amount you want to deposit");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    Deposit(depositAmount);
                    break;
                case 3:
                    Console.Write("Balance in your account:");
                    Console.WriteLine(currentCustomer.AccountBalance);
                    break;
                default:
                    Console.WriteLine("invalid action selected!");
                    break;

            }
        }


        private void WithDraw(decimal amount)
        {
            if (amount > 0 && amount <= currentCustomer.AccountBalance)
            {
                currentCustomer.AccountBalance -= amount;
                Console.WriteLine($"{amount} has been withdrawn and your new balance is: {currentCustomer.AccountBalance}");
            }
            else
            {
                Console.WriteLine("Invalid amount!");
            }
        }

       
        private void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                currentCustomer.AccountBalance += amount;
                Console.WriteLine($"{amount} Your money has been deposited your new balance is {currentCustomer.AccountBalance}");
            }
            else
            {
                Console.WriteLine("Invalid amount!");
            }
        }

    }
}
