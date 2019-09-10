using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewProject
{
    [TestClass]
    public class HomePageTests : BaseTest

    {
        [TestMethod]
        public void CheckHomepageLoads()
        {
            // Arange
            HomePage homePage = new HomePage(Driver);
            // Act
            homePage.GoTo();
            // Assert 
            Assert.AreEqual("Automation Practice Website", homePage.siteDescriptionTitle.Text);
        
       


        }
    }
}
