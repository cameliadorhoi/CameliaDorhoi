using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace NewProject
{
    [TestClass]
    public class HomePageTests : BaseTest

    {        

        [TestMethod]
        public void checkHomepageLoads()
        {
            // Act
            homePage.GoTo();
            // Assert 
            Assert.AreEqual("Automation Practice Website", homePage.siteDescriptionTitle.Text);
        }

        [TestMethod]
        public void checkIfMenuExistsInPage() 
        {
            // Act
            homePage.GoTo();
            // Assert 
            Assert.IsNotNull(homePage.meniu, "the menu is present on page");
        }


        [TestMethod]
        public void checkIfElementIsDisplayed()
        {
            // Act
            homePage.GoTo();
            // Assert 
            Assert.IsNotNull(homePage.summerCollection, "elementul e afisat");
        }

    }
}
