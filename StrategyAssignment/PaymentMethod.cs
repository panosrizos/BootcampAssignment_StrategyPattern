using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    abstract class PaymentMethod
    {

        public abstract bool Pay(decimal amount);
    }


    class DebitCard : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 50000)
            {
                Console.WriteLine($"Paying {amount} using Dedit Card declined");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nPaying {amount} using Dedit Card\n");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
        }
    }


    class BankTransfer : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 100000)
            {
                Console.WriteLine($"Paying {amount} using Bank Transfer declined");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nPaying {amount} using Bank Transfer\n");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
        }
    }


    class Cash : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 2000)
            {
                Console.WriteLine($"Paying {amount} using Cash declined");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nPaying {amount} using Cash\n");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
        }
    }












































}
