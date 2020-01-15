using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTest.Bindings
{
    [Binding]
    class bindClass2
    {
        public Framework1.POM.GoogleSearch gs = new Framework1.POM.GoogleSearch();
        public Framework1.POM.NewsHome nh = new Framework1.POM.NewsHome();
        public static Hooks.Hooks1 h1 = new Hooks.Hooks1();
        public IWebDriver _driver = h1.LoadBrowser();

        [When(@"i do something else")]
        public void WhenIDoSomethingElse()
        {
            nh.navigateToNews(_driver);
        }

    }
}
