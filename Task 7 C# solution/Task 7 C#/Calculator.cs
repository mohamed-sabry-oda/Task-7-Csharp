using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_C_
{
    internal class Calculator
    {
        public int Sum(int NumberOne , int NumberTwo)
        {
            return NumberOne + NumberTwo;
        }

        public int Sum(int NumberOne, int NumberTwo, int NumberThree)
        {
            return NumberOne + NumberTwo + NumberThree;
        }

        public double Sum(double NumberOne, double NumberTwo)
        {
            return NumberOne + NumberTwo;
        }
    }
}
