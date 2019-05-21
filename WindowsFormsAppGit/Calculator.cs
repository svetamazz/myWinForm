using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGit
{
    public class Calculator
    {
        public int addition(int x, int y)
        {
            return x + y;
        }

        public int subtraction(int x, int y)
        {
            return x - y;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }

        public double division(double x, double y)
        {
          //  if(y==0) throw new ArgumentException("Can't ")
            return x / y;
        }
    }
}
