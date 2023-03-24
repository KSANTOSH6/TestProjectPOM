using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProjectPOM.Drivers;
using TestProjectPOM.Source.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace TestProjectPOM.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class HomeTest : Driver
    {
        /*
        public IWebDriver _driver;
        //_driver = new ChromeDriver();
        //public string field;

        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }
        */
        [Test]
        public void Cust()
        {
            Random ran = new Random();
            int a = ran.Next();

            //string uno = "000025";

            HomePage hp = new HomePage(); //_driver
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://autovmnew-3f614dab4e1a1230cdevaos.cloudax.dynamics.com/?cmp=usmf&mi=DefaultDashboard");
            hp.search("automated.test1@saglobal.com", "5B33!6jYXTX8mSy", "sk "+a, "10");
            //Assert.True(_driver.Title.Contains("smart phones"));

            //string av = hp.validateField();
            //Assert.IsTrue(av.Contains(uno));

            //hp.closee();

        }
        [Test]
        public void ProjectCreation()
        {
            Random ran = new Random();
            int a = ran.Next();
            //SelectElement dropDown = new SelectElement(_driver.FindElement(By.XPath("//*[@name='projTable_Type']")));
            //dropDown.SelectByIndex(1);

            HomePage hp = new HomePage();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://autovmnew-3f614dab4e1a1230cdevaos.cloudax.dynamics.com/?cmp=usmf&mi=DefaultDashboard");
            hp.proj("automated.test1@saglobal.com", "5B33!6jYXTX8mSy", "sk " + a, "000001", "dropDown.SelectByIndex(2)");

            //hp.closee();
        }
        [Test]
        public void vendorCreation()
        {
            Random ran = new Random();
            int a = ran.Next();

            HomePage hp = new HomePage();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://autovmnew-3f614dab4e1a1230cdevaos.cloudax.dynamics.com/?cmp=usmf&mi=DefaultDashboard");
            hp.vendor("automated.test1@saglobal.com", "5B33!6jYXTX8mSy", "sk " + a, "10");

            //hp.closee();
            
        }

        [Test]
        public void humanResource()
        {
            Random ran = new Random();
            int a = ran.Next();

            string edate = System.DateTime.Now.ToString();
            string adate = System.DateTime.Now.ToString();
            //string positionset = selectbyvalue(1);

            HomePage hp = new HomePage();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://autovmnew-3f614dab4e1a1230cdevaos.cloudax.dynamics.com/?cmp=usmf&mi=DefaultDashboard");
            //hp.createhr("automated.test1@saglobal.com", "5B33!6jYXTX8mSy", "sk ", "a", "000237");
            hp.createhr("automated.test1@saglobal.com", "5B33!6jYXTX8mSy", "sk ", "a", "000237", edate, adate);
        }

        /*
        [Test]
        public void checkFields()
        {
            //Random ran = new Random();
            //int x = ran.Next();
            HomePage hp = new HomePage(_driver);

            Assert.IsTrue(field.Contains(field));

          // string username = 
            //string toDate = "14th June";

           // string content = hp.validateField();
            // Pages.OP.validateField();
           // Assert.IsTrue(content.Contains(username));
            //Assert.IsTrue(validateField);
        }
        */
        /*
        [TearDown]
        public void ClosePage()
        {
            Thread.Sleep(5000);
            _driver.Quit();
        } */
    }
}