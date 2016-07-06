using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_class
{
    public class Class1
    {
        public int div1 = 5;
        public int div2 = 3;
        public string check(int value) {

            if (checkFizzBuzz(value,div1,div2))
                {
                    return("FizzBuzz");
                }
            else if (checkBuzz(value, div1))
                {
                    return("Buzz");
                }
            else if (checkFizz(value,div2))
                {
                    return("Fizz");
                }
                else
                {
                    return value.ToString();
                }
            }

        public Boolean checkFizzBuzz(int value, int div1, int div2)
        {
            if (value % div1 == 0 && value % div2 == 0)
            {
                return true;
            }
            return false;
        }

        public Boolean checkBuzz(int value, int div)
        {
            if (value % div == 0)
            {
                return true;
            }
            return false;
        }

        public Boolean checkFizz(int value, int div)
        {
            if (value % div == 0)
            {
                return true;
            }
            return false;
        }
        }

}
