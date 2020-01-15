using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//You need to add a reference and a using to the project that you are referencing
using Framework1;

namespace AutoTest.Bindings
{
    [Binding]
    class testBinding
    {
        

        //This i what you have to do to reference a class in another project.               
        public Framework1.POM.GoogleSearch gs = new Framework1.POM.GoogleSearch();
        public Framework1.POM.NewsHome nh = new Framework1.POM.NewsHome();
        public static Hooks.Hooks1 h1 = new Hooks.Hooks1();
        public IWebDriver _driver = h1.LoadBrowser();
               

        [Given(@"I have search for burgers using google")]
        public void GivenIHaveSearchForBurgersUsingGoogle()
        {
            gs.searchItem(_driver,"burger");
            

        }

        [Then(@"I am done")]
        public void ThenIAmDone()
        {
            nh.navigateToNews(_driver);
        }



    }
}
