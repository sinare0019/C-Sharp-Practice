using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice2
{
    delegate void MyDel1( int X);
    delegate void MyDel(ref int X);
    class Program
    {
        public void Sum1(int x) { x += 1; }
        public void sum2(int x) { x += 2; }

        public void Sum4(ref int x) { x += 4; }
            public void sum6(ref int x) { x += 6; }

            public static void Main(string[] args)
            {
                Program mc = new Program();
            MyDel1 mdel1 = mc.Sum1;
            mdel1 += mc.Sum1;
            mdel1 += mc.sum2;
                MyDel mDel = mc.Sum4;
                mDel += mc.Sum4;
                mDel += mc.sum6;
            int y = 10;
                int x = 10;
            mdel1(y);
                mDel(ref x);
            Console.WriteLine(y);
                Console.WriteLine(x);
            Console.ReadKey();

            }
        
    }
}
