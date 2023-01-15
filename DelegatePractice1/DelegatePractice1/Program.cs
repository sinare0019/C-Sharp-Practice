using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice1
{
    class Program
    {
        // declare delegate
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;

            printDel(100000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(200);

            Print valueAdded = PrintNumberSum;
            valueAdded += PrintMoneySum;
            valueAdded.Invoke(500);
            Console.ReadKey();
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: "+ num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: "+ money);
        }


        public static void PrintNumberSum(int num)
        {
            int sumNumbers = num + 9000;
            Console.WriteLine("Number: " + sumNumbers);
        }

        public static void PrintMoneySum(int money)
        {
            int sumNumbers = money + 8000;
            Console.WriteLine("Money: " + sumNumbers);
        }
    }
}
