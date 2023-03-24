using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectPOM.Source.Pages;
//using TestProjectPOM.Tests;

namespace TestProjectPOM.validation
{
    public class validate
    {
        /*
        public IWebDriver _driver;
        ChromeDriver driver = new ChromeDriver();
        HomePage hp = new HomePage(driver);
        //HomeTest ht = new HomeTest(_driver);

        public string validateField() //method to validate the field
        {
            string field = vendorvalidation.GetAttribute("text");

            return field;
        }

        [Test]
        public void checkFields()
        {
            //Random ran = new Random();
            //int x = ran.Next();
            //HomePage hp = new HomePage(_driver);

            Assert.IsTrue(Contains(field));

            // string username = 
            //string toDate = "14th June";

            // string content = hp.validateField();
            // Pages.OP.validateField();
            // Assert.IsTrue(content.Contains(username));
            //Assert.IsTrue(validateField);
        }
        */
        public string m1(string x, string y, string z)
        {
            //int x = 20;
            //int y = 30;

            z = x + 2;

            return z;
        }

        //Test data
        //var o = "abc";
    }  
}