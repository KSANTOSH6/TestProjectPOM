using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using TestProjectPOM.Drivers;
//using TestProjectPOM.Tests;

namespace TestProjectPOM.Source.Pages
{
    //[ThreadStatic]
    public class HomePage : Driver
    {
        //[ThreadStatic]
        //public IWebDriver _driver;
       
        /*
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement searchbox;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        public IWebElement searchbutton;
        */

        [FindsBy(How = How.XPath, Using = "//*[@data-report-value='Email_Phone_Skype_Entry']")]
        public IWebElement username;

        [FindsBy(How = How.XPath, Using = "//*[@data-report-value='Submit']")]
        public IWebElement nextbutton;

        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Password']")] 
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@data-report-value='Submit']")]
        public IWebElement loginbtn;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='Modules']")]
        public IWebElement moduleicon;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title='Accounts receivable']")] 
        public IWebElement clickmodule;

        [FindsBy(How = How.XPath, Using = "//*[@title='Collapse all']")]
        public IWebElement collapseall;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title='Customers']")]
        public IWebElement selectmodule;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='All customers']")]
        public IWebElement clickinsidemodule;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname = 'NewCustomer']")]
        public IWebElement newbtn;

        [FindsBy(How = How.XPath, Using = "//*[@name='Org_Name']")]
        public IWebElement entername;

        [FindsBy(How = How.XPath, Using = "//*[@name='DynamicDetail_CustGroup']")]
        public IWebElement grpname;

        [FindsBy(How = How.XPath, Using = "//span[text()='Save']")]
        public IWebElement svbtn;

        [FindsBy(How = How.XPath, Using = "//*[@name='Identification_AccountNum']")]
        public IWebElement accvalidation;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname='SystemDefinedCloseButton']")]
        public IWebElement closebutton;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname='SystemDefinedCloseButton']")]
        public IWebElement closepage;

        //Project
        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title='Project management and accounting']")]
        public IWebElement clickprojmodule;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title='Projects']")]
        public IWebElement selectprojmodule;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='All projects']")]
        public IWebElement clickinsideprojmodule;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname = 'ProjectNewButton']")]
        public IWebElement newprojbtn;

        [FindsBy(How = How.XPath, Using = "//*[@name='Name']")]
        public IWebElement projname;

        [FindsBy(How = How.XPath, Using = "(//*[@title='Open'])[6]")]
        public IWebElement projcontactid;

        [FindsBy(How = How.XPath, Using = "//span[text()='Create project']")]
        public IWebElement projbtn;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname='HeaderHomeTab']")]
        public IWebElement projectheaderbutton;

        [FindsBy(How = How.XPath, Using = "(//*[@data-dyn-controlname='CtrlStages'])[2]")]
        public IWebElement projectstagebutton;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='In process']")]
        public IWebElement projectstage;

        [FindsBy(How = How.XPath, Using = "(//*[@data-dyn-controlname='SystemDefinedCloseButton'])[2]")]
        public IWebElement closeprojectpage;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname='SystemDefinedCloseButton']")]
        public IWebElement closeallprojectpage;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname='Ok']")]
        public IWebElement okbtn;

        [FindsBy(How = How.XPath, Using = "//*[@name='projTable_Type']")]
        public IWebElement projtype;

        //Vendor
        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title='Accounts payable']")] 
        public IWebElement clickvendmodule;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title='Vendors']")]
        public IWebElement selectvendmodule;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='All vendors']")]
        public IWebElement clickinsidevendmodule;

        [FindsBy(How = How.XPath, Using = "//*[@name = 'SystemDefinedNewButton']")] //name="SystemDefinedNewButton"
        public IWebElement newvendbtn; //data-dyn-controlname = 'SystemDefinedNewButton'

        [FindsBy(How = How.XPath, Using = "//*[@name='Org_Name']")]
        public IWebElement vendorname;

        [FindsBy(How = How.XPath, Using = "//*[@name='Posting_VendGroup']")]
        public IWebElement vendorgrp;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-controlname = 'SystemDefinedSaveButton']")]
        public IWebElement savevendbtn; // (//*[@data-dyn-role='CommandButton'])[7]

        [FindsBy(How = How.XPath, Using = "(//*[@data-dyn-role='CommandButton'])[7]")] //*[@data-dyn-controlname='SystemDefinedCloseButton']
        public IWebElement closevendorpage;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='Close']")] //*[@name='Identification_AccountNum']
        public IWebElement closeallvendorpage;

        [FindsBy(How = How.XPath, Using = "//*[@name='Identification_AccountNum']")]
        public IWebElement vendorvalidation;

        //Create Employee
        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title = 'Human resources']")]
        public IWebElement hrmodule;

        [FindsBy(How = How.XPath, Using = "//*[@data-dyn-title = 'Workers']")]
        public IWebElement clickhrmodule;  

        [FindsBy(How = How.XPath, Using = "//*[@aria-label = 'Employees']")]
        public IWebElement clickinsidehrmodule;

        [FindsBy(How = How.XPath, Using = "//*[@name = 'HRNew_Worker']")]
        public IWebElement newhrbtn;

        [FindsBy(How = How.XPath, Using = "//*[@name='FirstName']")]
        public IWebElement hrfirstname;

        [FindsBy(How = How.XPath, Using = "//*[@name='LastName']")]
        public IWebElement hrlastname;

        [FindsBy(How = How.XPath, Using = "//*[@name='EmploymentStartDate']")]
        public IWebElement employeestartdate;

        [FindsBy(How = How.CssSelector, Using = "#HcmWorkerNewWorker_3_Position_input")] //*[@name='Position']
        public IWebElement hrposition;

        [FindsBy(How = How.XPath, Using = "//*[@name='AssignmentStartDate']")]
        public IWebElement Assignmentstartdate;

        [FindsBy(How = How.XPath, Using = "//span[text()='Hire']")]
        public IWebElement hrhirebtn;

        public HomePage()//IWebDriver driver)
        {
            //_driver = driver;
            PageFactory.InitElements(_driver, this); 
        }

        public void search(string name, string pass, string cname, string groupname)
        {
            username.SendKeys(name);
            nextbutton.Click();
            Thread.Sleep(5000);
            password.SendKeys(pass);
            loginbtn.Click();
            Thread.Sleep(5000);

            moduleicon.Click(); 
            Thread.Sleep(2000);
            clickmodule.Click();
            Thread.Sleep(2000);
            collapseall.Click();
            Thread.Sleep(2000);
            selectmodule.Click();
            Thread.Sleep(2000);
            clickinsidemodule.Click();
            Thread.Sleep(2000);

            newbtn.Click();
            Thread.Sleep(2000);
            entername.SendKeys(cname);
            Thread.Sleep(2000);
            grpname.SendKeys(groupname);
            Thread.Sleep(2000);
            svbtn.Click();
            Thread.Sleep(2000);

            //object p = HomePage.validateField.field();

            closebutton.Click();
            Thread.Sleep(3000);
            closepage.Click();
        }
        /*
        public string validateField() //method to validate field
        {
            string field = accvalidation.GetAttribute("text");

            return field;
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("select-demo")));
            dropDown.SelectByValue(dayOfTheWeek);
        }
        */
        //SelectElement dropDown = new SelectElement(_driver.FindElement(By.Id("select-demo")));
        //dropDown.

        public void proj(string name, string pass, string pn, string cont, string dropDown)
        {
            username.SendKeys(name);
            nextbutton.Click();
            Thread.Sleep(5000);
            password.SendKeys(pass);
            loginbtn.Click();
            Thread.Sleep(3000);

            moduleicon.Click();
            Thread.Sleep(2000);
            clickprojmodule.Click();
            Thread.Sleep(2000);
            collapseall.Click();
            Thread.Sleep(2000);
            selectprojmodule.Click();
            Thread.Sleep(2000);
            clickinsideprojmodule.Click();
            Thread.Sleep(2000);
            newprojbtn.Click();
            Thread.Sleep(2000);

            projtype.SendKeys(dropDown);
            projname.SendKeys(pn);
            Thread.Sleep(2000);
            projcontactid.SendKeys(cont);
            //projcontactid.SelectByValue("aaa");

            Thread.Sleep(2000);
            projbtn.Click();
            Thread.Sleep(5000);
            projectheaderbutton.Click();
            Thread.Sleep(2000);
            projectstagebutton.Click();
            Thread.Sleep(2000);
            projectstage.Click();
            Thread.Sleep(2000);
            okbtn.Click();
            Thread.Sleep(5000);

            closeprojectpage.Click();
            Thread.Sleep(3000);
            closeallprojectpage.Click();
        }
        
        public void vendor(string name, string pass, string vname, string vgrp)
        {
            username.SendKeys(name);
            Thread.Sleep(2000);
            nextbutton.Click();
            Thread.Sleep(5000);
            password.SendKeys(pass);
            Thread.Sleep(2000);
            loginbtn.Click();
            Thread.Sleep(2000);

            moduleicon.Click();
            Thread.Sleep(2000);
            clickvendmodule.Click();
            Thread.Sleep(2000);
            collapseall.Click();
            Thread.Sleep(2000);
            selectvendmodule.Click();
            Thread.Sleep(2000);
            clickinsidevendmodule.Click();
            Thread.Sleep(2000);
            newvendbtn.Click();
            Thread.Sleep(2000);
            vendorname.SendKeys(vname);
            Thread.Sleep(2000);
            vendorgrp.SendKeys(vgrp);
            Thread.Sleep(2000);
            //vendorvalidation.
            savevendbtn.Click();
            Thread.Sleep(3000);
            //checkFields();
            //Thread.Sleep(2000);
            closevendorpage.Click();
            Thread.Sleep(3000);
            closeallvendorpage.Click();
            //checkFields();

        }
        
        public void createhr(string name, string pass, string fname, string lname, string pos, string empdate, string assigndate)
        {
            username.SendKeys(name);
            Thread.Sleep(2000);
            nextbutton.Click();
            Thread.Sleep(5000);
            password.SendKeys(pass);
            Thread.Sleep(2000);
            loginbtn.Click();
            Thread.Sleep(2000);

            moduleicon.Click();
            Thread.Sleep(2000);
            hrmodule.Click();
            Thread.Sleep(2000);
            collapseall.Click();
            Thread.Sleep(2000);

            clickhrmodule.Click();
            Thread.Sleep(2000);
            clickinsidehrmodule.Click();
            Thread.Sleep(2000);
            newhrbtn.Click();
            Thread.Sleep(2000);
            hrfirstname.SendKeys(fname);
            Thread.Sleep(2000);
            hrlastname.SendKeys(lname);
            Thread.Sleep(2000);
            employeestartdate.SendKeys(empdate);
            Thread.Sleep(2000);
            hrposition.GetCssValue(pos);
            Thread.Sleep(2000);
            Assignmentstartdate.SendKeys(assigndate);
            Thread.Sleep(2000);

        }

        /*
        public string validateField() //method to validate the field
        {
            field = vendorvalidation.GetAttribute("text");

            FieldAccessException.Equals();

            return field;
        }
        */
    }
}

//var NameObject = _driver.findelement(by.id("//*[@id='Name']")).sendkeys("abc");
//var PassObject = _driver.findelement(by.xpath("//*[@id='Password']")).sendkeys("abc");
//var LoginObject = _driver.findelement(by.xpath("//*[@id='login']")).Click();

//*[@data-dyn-controlname = "NewCustomer"]

////*[@name='DynamicDetail_CustGroup']
///name='Org_Name'
/////*[@data-dyn-controlname='SystemDefinedCloseButton']
///

//employee

//*[@name='FirstName']
//*[@name='LastName']
//*[@name='EmploymentStartDate']
//*[@name='AssignmentStartDate']
//*[@name='Position']
//span[text()='Hire and add details']

//data - dyn - title = "Human resources"