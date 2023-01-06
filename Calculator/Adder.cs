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
            return 0;
        }
    }
}
