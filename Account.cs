using System;

namespace BankAccount
{
  class Account
  {
   private string? clientname;
   private double balance;
   private long accountnumber;
   
   public string ClientName{
    get {return clientname;}
    set{clientname = value;}
   }
   public double Balance{
    get{return balance;}
    set{balance = value;}
   }
   
   public long AccountNumber{
    get{return accountnumber;}
    set{accountnumber = value;}
   }



   public double Withdraw(double withdrawAmount){

    if((Balance - withdrawAmount) < 0 ){
      Console.WriteLine("Insuffient Funds");
    }
    else{
      Balance -= withdrawAmount;
      Console.WriteLine($"You have succesfully withdrawn ${Convert.ToString(withdrawAmount)} from your account");

    }
    return Balance;
   }

  public double Deposit(double depositAmount){
    
    Balance += depositAmount;
    Console.WriteLine($"You have succesfully deposited ${Convert.ToString(depositAmount)} from your account");
    return Balance;
   }

   public double AccountBalance(){
    Console.WriteLine($"You have $1{Convert.ToString(Balance)} left in your account");
    return Balance;
   }

   



  }
}
