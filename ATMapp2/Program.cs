using ATMApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose One from the following options...");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Check Account balance");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Withdraw Cash");
                Console.WriteLine("5. Transfer Cash");
                Console.WriteLine("6. Quit App");

            }

            void deposit(cardHolder  currentUser)
            {
                Console.WriteLine("How much Money do you want to Deposit? ");
                double deposits = Double.Parse(Console.ReadLine());
                currentUser.setBalance(deposits);
                Console.WriteLine("Deposit complete. Your new balance is: " + currentUser.getBalance());
            }

            void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much Money do you want to Deposit? ");
                double withdrawal = Double.Parse(Console.ReadLine());
                // Check if the User has enough money to Withdraw
                if (currentUser.getBalance() > withdrawal)
                {
                    Console.WriteLine("Insufficient balance :(");
                }
                else
                {
                    double newBalance = currentUser.getBalance();
                }
            }
        }
    }
}
