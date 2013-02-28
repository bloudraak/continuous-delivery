using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Web.Application.Controllers;

namespace Sample.Web.Application.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var target = new HomeController();

            // Act
            ActionResult result = target.Index();

            // Assert
            Assert.IsNotNull(result, "The HomeController.Index returned null");
        }
    }
}
