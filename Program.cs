using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Info
            string fullName;
            Console.WriteLine("Enter your full name to open account: ");
            fullName = Console.ReadLine();
        
            Account newBank = new Account();
            newBank.Name = fullName;
            newBank.AccountNumber();
            
            try
            {
              newBank.Deposit();  
            }
            catch(Exception)
            {
                Console.WriteLine("Enter a valid amount.");
            }
            newBank.AccountDetails();


            // loop to perform a transaction
            bool transaction = true;
            while(transaction)
            {
                Console.WriteLine("Select which transaction you want to perform ( deposit / withdrawal / close account / exit) :");
                string action = Console.ReadLine();

                if(action == "deposit")
                {
                    try
                    {
                      newBank.Deposit();  
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Enter a valid amount.");
                    }
                }

                else if(action == "withdrawal")
                {
                    try
                    {
                      newBank.Withdraw();  
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Enter a valid amount.");
                    }
                }

                else if(action == "close account")
                {
                    Console.WriteLine("GoodBye!");
                    newBank = null;
                    transaction = false;
                }
                
                else if(action == "exit")
                {
                    Console.WriteLine("Goodbye");
                    transaction = false;
                }
                else
                {
                    Console.WriteLine("Invalid action");
                }
            }


            // five customers
            Account user1 = new Account();
            user1.Name = "John Doe";
            user1.AccountNumber();

            Account user2 = new Account();
            user2.Name = "Jane Doe";
            user2.AccountNumber();

            Account user3 = new Account();
            user3.Name = "Jacob Doe";
            user3.AccountNumber();

            Account user4 = new Account();
            user4.Name = "Jerry Doe";
            user4.AccountNumber();

            Account user5 = new Account();
            user5.Name = "Jenny Doe";
            user5.AccountNumber();

            
        }
    }
}
