﻿//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.IE;



//namespace SeleniumTest
//{
//    class Program
//    {
//        //static InternetExplorerOptions IEoptions;

//        static void Main(string[] args)
//        {
//            IWebDriver driver;




//            ChromeOptions options = new ChromeOptions();

//            //options.AddAdditionalCapability(CapabilityType.Version, "68", true);
//            options.AddAdditionalCapability("os_version", "Sierra", true);
//            options.AddAdditionalCapability("os", "OS X", true);
//            options.AddAdditionalCapability("browser_version", "67", true);

//            driver = new RemoteWebDriver(new Uri("http://<your_username>:<your_access_key>@hub-cloud.browserstack.com/wd/hub/"),
//                                         options.ToCapabilities());

//            driver.Navigate().GoToUrl("http://www.google.com");
//            Console.WriteLine(driver.Title);

//            IWebElement query = driver.FindElement(By.Name("q"));
//            query.SendKeys("Browserstack");
//            query.Submit();
//            Console.WriteLine(driver.Title);

//            driver.Quit();
//        }
//    }
//}






