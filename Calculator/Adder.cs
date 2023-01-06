using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;

namespace Calculator
{
    public class Adder
    {
        FirefoxOptions options = new FirefoxOptions();
        public static int Add(int x, int y) {
            return x + y;
        }

        public static int Sum(int [] values)
        {
            if (values.Length == 0)
            {
                return 0;
            }
            int s = 0;
            for (int i=0; i < values.Length; i++)
            {
                s += values[i];
            }
            return s;
        }
    }
}
