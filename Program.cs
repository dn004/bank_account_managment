using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using BankAccount;

namespace BankAccountManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> nameofclient = new List<string>{
                "Joey",
                "George",
                "Vinnie",
                "Tony",
                "Tommy"
            };

            List<int> accountNumber = new List<int>{
                485839988,
                538484385,
                539958585,
                488539295,
                583949595
            };

            List<double> amountinaccount = new List<double>{
                458583,
                53848439,
                45,
                565,
                58394
            };

            Account sam = new Account();



            
            Console.WriteLine("Are you a client of Raven Bank LLC? Yes or No?");
            string? response = Console.ReadLine();
            string aretheyclient = response.ToLower();

            if (aretheyclient == "yes"){
                Console.WriteLine("Welcome to Raven Bank LLC.");
            }
            else if (aretheyclient == "no"){
                Console.WriteLine("Would you like to create an account with Raven Bank LLC? Yes or No?");
                string? responsetwo = Console.ReadLine();
                string wanttojoin = responsetwo.ToLower();

                if (wanttojoin == "no"){
                    Console.WriteLine("Thats Unfortunate");
                    return;
            }
                else if (wanttojoin == "yes"){
                    int initialdeposit = 0;
                    //adding name to list
                    Console.WriteLine("Please type your name: ");
                    string? newclientname = Console.ReadLine();
                    nameofclient.Add(newclientname);
                    
                    //creating account number
                    Random random = new Random();
                    for (int i = 0; i < 10; i++)
                    {
                        int newAccountNumber;
                        do
                        {
                            newAccountNumber = GenerateRandom10DigitNumber(random);
                        } while (accountNumber.Contains(newAccountNumber));

                            nameofclient.Add(newclientname);
                            accountNumber.Add(newAccountNumber);
                    }
                    //Adding to balance
                    Console.WriteLine("You need to deposit a minimum of $1000 dollars /n How much do will you deposit?");
                    initialdeposit = Convert.ToInt32(Console.ReadLine());
                    if(initialdeposit > 1000){
                        Console.WriteLine("You have successfully created an account with Raven Bank LLC");
                        Console.WriteLine("Would you like to access your account? Yes or No");
                        string? responsethree = Console.ReadLine();
                        string wanttocontinue = responsethree.ToLower();
                        if (wanttocontinue == "yes"){
                            Console.WriteLine("Processing....");
                        }
                        else{
                            return;
                        }
                    }
                    else{
                        Console.WriteLine("quit playin");
                        return;
                    }


            }
            }


            Console.WriteLine("Please type your name: ");
            string? givenname = Console.ReadLine();

            bool nameFound = false;

            for (int i = 0; i < nameofclient.Count; i++)
            {
                if (string.Equals(nameofclient[i], givenname, StringComparison.OrdinalIgnoreCase))
                {
                    sam.ClientName = nameofclient[i];
                    sam.Balance = amountinaccount[i];
                    sam.AccountNumber = accountNumber[i];
                    nameFound = true;

                }
            }

            if (!nameFound)
            {
                Console.WriteLine("Invalid name. Exiting...");
                return; // End the program
            }

            int clientChoice;
            do
            {
                Console.WriteLine("Would you like to \n 1. Withdraw \n 2. Deposit \n 3. Check Balance \n 4. Exit");
                Console.WriteLine("Please pick a number: ");
                clientChoice = Convert.ToInt32(Console.ReadLine());

                if (clientChoice == 1)
                {
                    Console.WriteLine("How much would you like to Withdraw: ");
                    sam.Withdraw(Convert.ToDouble(Console.ReadLine()));
                }
                else if (clientChoice == 2)
                {
                    Console.WriteLine("How much would you like to deposit: ");
                    sam.Deposit(Convert.ToDouble(Console.ReadLine()));
                }
                else if (clientChoice == 3)
                {
                    sam.AccountBalance();
                }
                else if (clientChoice == 4)
                {
                    Console.WriteLine("Thank you for using Raven Bank LLC!");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (clientChoice != 4);
        }
        static int GenerateRandom10DigitNumber(Random random)
        {
            return random.Next(100000000, 1000000000); // Generates a random 10-digit number
        }
    }
}
