using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fizzbuzz_class;

namespace Fizzbuzz_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fizzbuzz_console = new FizzClass();

            for (int iter = 1; iter <= 100; iter++)
            {
                string result = Fizzbuzz_console.check(iter);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }



    }
}
