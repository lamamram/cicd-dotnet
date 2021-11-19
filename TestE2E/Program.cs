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
            driver.Navigate().GoToUrl("https://www.google.com/");
            // identify the Google search text box  
            IWebElement ele = driver.FindElement(By.Name("q"));
            //enter the value in the google search text box  
            ele.SendKeys("dawan");
            //identify the google search button  
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            // click on the Google search button  
            ele1.Click();
            //close the browser  
            string s = driver.PageSource;
            Console.Write(s);
        }
    }
}