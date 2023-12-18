using Moq;
using NUnit.Framework;
using ProgGym.PrinterMonitor.Domain_Win.Interfaces;
using ProgGym.PrinterMonitor.Domain_Win.Services;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgGym.PrinterMonitor.IntegrationTest.Service
{
    [TestFixture()]
    public class SearchDeviceServiceTests
    {
        private readonly Mock<IAuthDomain> authDomain = new Mock<IAuthDomain>();
        private SearchDeviceService service;

        [SetUp]
        public void SearchDeviceServiceTestsSetUp()
        {
            //Arrange 

            authDomain.Setup(a => a.Root).Returns(new DirectoryEntry());
            service = new SearchDeviceService(authDomain.Object);
        }

        [Test()]
        public void GetPrintersTest()
        {
            //Act 
            var items = service.GetPrinters();

            //Assert
            Assert.IsTrue(items.Any());
        }
    }
}