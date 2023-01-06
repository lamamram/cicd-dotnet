using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;


namespace _020123
{
    [TestClass]
    public class E2EDawanTest
    {

        [TestMethod, TestCategory("E2E")]
        public void TestHomeTitle()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--headless");
            //IWebDriver driver = new FirefoxDriver(options);
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://selenium_server:4444/wd/hub"), options: options);
            driver.Url = "https://dawan.fr";
            StringAssert.Contains(driver.Title, "Dawan");
            driver.Close();
        }
    }
}