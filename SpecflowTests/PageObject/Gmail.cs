using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SpecflowTests.PageObject
{
    class Gmail
    {
        public static void TypeFirstName()
        {
            Driver.Instance.FindElement(By.XPath(".//*[@id='FirstName']")).Clear();
            Driver.Instance.FindElement(By.XPath(".//*[@id='FirstName']")).SendKeys("QA");

        }

        public static void TypeLastName()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='LastName']")).Clear();
            Driver.Instance.FindElement(By.XPath("//*[@id='LastName']")).SendKeys("HassanBhuiyan");
        }


        public static void TypeGmailAddress(String email)
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='GmailAddress']")).Clear();
            Driver.Instance.FindElement(By.XPath("//*[@id='GmailAddress']")).SendKeys(email);
        }

        public static void TypeInvalidGmailAddress()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='GmailAddress']")).Clear();
            Driver.Instance.FindElement(By.XPath("//*[@id='GmailAddress']")).SendKeys("hb");
        }

        public static void TypePassword()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='Passwd']")).Clear();
            Driver.Instance.FindElement(By.XPath("//*[@id='Passwd']")).SendKeys("Finderspa.1");
        }
        public static void TypePasswordAgain()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='PasswdAgain']")).Clear();
            Driver.Instance.FindElement(By.XPath("//*[@id='PasswdAgain']")).SendKeys("Finderspa.1");
        }

        public static void EnterDD()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='BirthDay']")).SendKeys("11");
        }

        public static void EnterMM()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='BirthMonth']/div[1]")).SendKeys("November" + Keys.Enter);
        }

        public static void EnterYYYY()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='BirthYear']")).SendKeys("2001");
        }

        public static void EnterGender()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='Gender']/div[1]")).SendKeys("Male" + Keys.Enter);

        }

        public static void EnterPhoneNum()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='RecoveryPhoneNumber']")).SendKeys("7185597821");

        }

        public static void ClickNextStepButton()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='submitbutton']")).Click();
        }


        public static void ScrollDown()
        {

            Driver.Instance.FindElement(By.XPath("//*[@id='tos-scroll-button']/div/img")).Click();
            Driver.Instance.FindElement(By.XPath("//*[@id='tos-scroll-button']/div/img")).Click();
        }

        public static void ClickOnIagreeButton()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='iagreebutton']")).Click();
        }

        public static void AssertInvalidEmailErrorMsg()
        {
            String actualvalue = Driver.Instance.FindElement(By.XPath("//*[@id='errormsg_0_GmailAddress']")).Text;
            Assert.IsTrue(actualvalue.Contains("Please use between 6 and 30 characters."), actualvalue + " doesn't contains 'Please use between 6 and 30 characters.'");
        }

        public static void NavigateToURL(String Url)
        {
            Driver.Instance.Navigate().GoToUrl(Url);
        }

        public static void EnterEmailOrPhone()
        {
            Driver.Instance.FindElement(By.XPath("//input[@type='email']")).SendKeys("hasan.november30");
        }

        public static void EnterPassword()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input")).SendKeys("Finderspa.1");
        }

        public static void ClickNextButtonAfterEnterUserName()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='identifierNext']/content/span")).Click();
        }
        public static void ClickNextButtonAfterEnterPassword()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='passwordNext']/content/span")).Click();
        }

        public static void ClickOnGmailLogo()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='yDmH0d']/div[2]/c-wiz/div/div/div[5]/div[2]/c-wiz/div/div[1]/div/div[1]/div[2]/a[2]")).Click();
        }

        public static void ClickOnMyAccountLogo()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='gb']/div[1]/div[1]/div[2]/div[5]/div[1]/a/span")).Click();
        }

        public static void ClickOnSignOutButton()
        {
            Driver.Instance.FindElement(By.XPath("//*[@id='gb_71']")).Click();
        }

        public static void AssertSignOut()
        {
            String actualvalue = Driver.Instance.FindElement(By.XPath("//*[@id='forgotPassword']")).Text;
            Assert.IsTrue(actualvalue.Contains("Forgot password?"), actualvalue + " doesn't contains 'Forgot password?'");
        }


    }
}

