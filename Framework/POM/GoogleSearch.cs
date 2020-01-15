using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Framework1.POM
{
    [Binding]
    public class GoogleSearch
    {
        public IWebDriver _driver;
        public IWebElement searchField => _driver.FindElement(By.Name("q"));
        //public IWebElement searchBtn => _driver.FindElement(By.ClassName("gNO89b"));
        //public GoogleSearch() => _driver = new ChromeDriver();

        //lambda operator
        public IWebElement searchBtn => _driver.FindElement(By.Name("btnk"));

        public void searchItem(IWebDriver driver, string searchCriteria)
        {
            _driver = driver;
            //_driver = 
            //_driver = new ChromeDriver();

            
            _driver.Url = "http://www.google.com";
            searchField.SendKeys(searchCriteria);
            searchField.SendKeys(Keys.Enter);
            //searchField.SendKeys("{ENTER}");
            //searchField.SendKeys("\t\t");
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            //searchBtn.Click();


        }


        //driver.Url = "http://www.google.com";

        //    title = driver.Title;
        //    Console.WriteLine(title);
        //    driver.FindElement(By.Name("q")).SendKeys("mp3");
        //driver.FindElement(By.ClassName("gNO89b")).Click();
    }

}

