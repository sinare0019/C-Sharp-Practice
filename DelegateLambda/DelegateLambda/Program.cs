using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambda
{
    delegate int MyDel(int number);
    class Program
    {
        static void Main(string[] args)
        {
            MyDel del;
            del = (int number) => { return number + 15; };
            int y = del(int.Parse(Console.ReadLine()));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
