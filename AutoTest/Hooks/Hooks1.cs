using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTest.Hooks
{
    [Binding]
    class Hooks1
    {
        public IWebDriver _driver;
        //IWebDriver _driver = new ChromeDriver();

        public IWebDriver LoadBrowser()
        {
            _driver = new ChromeDriver();
            return _driver;
        }


        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
            //erroring that the object has not beendeclared and can't be closed.
            _driver.Close();
            
        }
    }
}
