using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatMesg());
            Console.WriteLine("Hi");

            Console.ReadKey();
        }

        public static string CreatMesg()
        {
            return "Hello World!";
        }
    }
}
