using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        public static int addNum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int sum = addNum(2, 3);
            Console.WriteLine(sum);
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
