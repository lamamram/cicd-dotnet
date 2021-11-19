using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test case started ");
            //create the reference for the browser  
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArguments("--headless");
            IWebDriver driver = new RemoteWebDriver(new Uri("http://gitlab_selenium_server:4444/wd/hub"), firefoxOptions);
            // navigate to URL  
            driver.Navigate().GoToUrl("http://python.org/");
            // identify the Python search text box  
            IWebElement ele = driver.FindElement(By.Name("q"));
            //enter the value in the python search text box
            ele.SendKeys("pycon");
            //identify the python search button  
            IWebElement ele1 = driver.FindElement(By.Id("submit"));
            // click on the python search button  
            ele1.Click();
            //close the browser
            string s = driver.PageSource;
            Console.Write(s);
        }
    }
}