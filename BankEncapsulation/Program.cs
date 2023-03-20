using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var alejandrosAcct = new BankAccount();


            Console.WriteLine("Hello. Welcome to your bank.\n" +
                "What would you like to do?" +
                " Please type: \n1 for deposit\n2 for withdraw\n" +
                "3 to check balance");
            var x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("How much would you like to deposit?");
                var deposit = int.Parse(Console.ReadLine());
                alejandrosAcct.Deposit(deposit);
                Console.WriteLine($"Your new amount is now ${alejandrosAcct.GetBalance()}");
              

            }
            if(x == 2)
            {
                Console.WriteLine("How much would you like to withdraw?");
                var withdraw = int.Parse(Console.ReadLine());
                alejandrosAcct.Withdraw(withdraw);
                Console.WriteLine($"Your new amount is now ${alejandrosAcct.GetBalance()}");
                if (alejandrosAcct.GetBalance()  < 0)
                {
                    Console.WriteLine("Uh oh! Looks like you have overdrawn your account!\nWe are notifying the IRS and calling your mother!");
                }
            }
            if (x == 3)
            {

            Console.WriteLine($"Your balance is ${alejandrosAcct.GetBalance()} Don't spend it all in one place!");
            }



        }
    }
}
