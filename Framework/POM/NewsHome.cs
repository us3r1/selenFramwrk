using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework1.POM
{
    public class NewsHome
    {
        private IWebDriver _driver;
        //public IWebElement loginBtn => _driver.FindElement(By.ClassName("nca-signin-btn"));
        public IWebElement loginBtn => _driver.FindElement(By.LinkText("Log in"));

        public void navigateToNews(IWebDriver driver)
        {
            _driver = driver;
            _driver.Url = "http://news.com.au";

        }


        public void userLogin()
        {
            var actualTitle = _driver.Title;
            var expectedTitle = "news.com.au — Australia’s #1 news site";
            Console.WriteLine(actualTitle);
            Console.WriteLine(loginBtn.Displayed);
            loginBtn.Click();
            Assert.AreEqual(expectedTitle, actualTitle);
            SharedLibs.CommonLib comFunct = new SharedLibs.CommonLib();
            comFunct.verifyElementNameExists(_driver, "email");
        }
    }
}
