using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using BankAccount;

namespace BankAccountManagement
{
  class Program
  {
    public static void Main(string[] args) 
    {
       Console.WriteLine("Welcome to Raven Bank LLC.");
       Account sam = new Account();
       sam.ClientName = "sammy";
       sam.Balance = 0;

       int clientChoice;
      do{

       Console.WriteLine("Would you like to \n 1. Withdraw \n 2. Deposit \n 3. Check Balance \n 4.Exit");
       Console.WriteLine("Please pick a number: ");
        
      clientChoice = Convert.ToInt32(Console.ReadLine());
        
      
            
        if(clientChoice == 1){ 
          Console.WriteLine("How much would you like to Withdraw: ");
          
          sam.Withdraw(Convert.ToDouble(Console.ReadLine()));
          
        }
        else if(clientChoice == 2){
          Console.WriteLine("How much would you like to deposit: ");
          
          sam.Deposit(Convert.ToDouble(Console.ReadLine()));
        }

        else if(clientChoice == 3){
          sam.AccountBalance();
        }

        else if (clientChoice == 4){
          Console.WriteLine("Thank you for using Raven Bank LLC!");
        }

        else{
          Console.WriteLine("Invalid Choice");
        }

    } while (clientChoice != 4);
    }

  }
}
