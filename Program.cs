using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String hw = "Hello";
            String name = "Kabin";

            uint noNegative = 65U;//this can only store Positive values, Need to add U/u
            sbyte sb = 125;//Signed 8 bit integer -128 to 127

            Console.WriteLine(hw + " " + name);
            Console.WriteLine("The unsigned uint Assigned = " + noNegative);
            Console.WriteLine("the Signed sbyte Number = " + sb);
            Console.ReadLine();
        }
    }
}
