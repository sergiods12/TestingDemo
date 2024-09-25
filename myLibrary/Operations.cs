using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Operations
    {

        public int Add(int number1, int number2)
        {
            return number1+number2;

        }

        public bool IsEven(int number)
        {
            //if (number % 2==0)
            //{
            //    return true;
            //}
            //else
            //{
              //  return false;
            //}

            return number % 2 == 0;

        }

        public double AddDecimal(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
