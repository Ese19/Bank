using System.Security.Cryptography;
using System.ComponentModel.Design.Serialization;
using System;
namespace BankAccount
{
    public class Account
    {
        Random rd = new Random();

        public string Name { get; set; } 

        public double Balance { get; set; }

        public int accNumber { get; set;}
        
        public void AccountNumber()
        {
            accNumber = rd.Next(100000000, 2000000000);
        }

        public void Deposit()
        {
            Console.WriteLine("Enter amount to deposit: ");
            double money = int.Parse(Console.ReadLine());
            Balance += money;
            Console.WriteLine("Your account balance is: " + Balance);
        }

        public void Withdraw()
        {
            if(Balance > 0)
            {
                Console.WriteLine("Enter amount to Withdraw: ");
                double money = int.Parse(Console.ReadLine());
                Balance -= money;
                Console.WriteLine("Your account balance is: " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
            
        }

        public void AccountDetails()
        {
            Console.WriteLine("Account Name: " + Name);
            Console.WriteLine("Account Number: " + accNumber);
            Console.WriteLine("Account Balance: " + Balance);
        }

    }
}