using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aug13_EventDriven_MizaBau
{
    public delegate T Formula<T>(T arg1);
    internal class CalculatorClass
    {
        public Formula<double> info;

        public static Double GetSum(double num1, double num2, double sum) 
        {
            sum = num1 + num2; 
            return sum;
        }
        public static Double GetDifference(double num1, double num2, double sum)
        {
            sum = num1 + num2;
            return sum;
        }

    }
}
