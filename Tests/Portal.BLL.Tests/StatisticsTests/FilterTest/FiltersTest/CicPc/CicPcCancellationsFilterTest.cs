﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Portal.BLL.Concrete.Statistics.Filter.Filters.CicPc;
using Portal.BLL.Statistics.Filter;
using Portal.Domain.StatisticContext;

namespace Portal.BLL.Tests.StatisticsTests.FilterTest.FiltersTest.CicPc
{
    [TestClass]
    public class CicPcCancellationsFilterTest
    {
        [TestMethod]
        public void CallTest()
        {
            //Arrange
            var domainStatProjectState1 = new DomainStatProjectState() { Producer = ProductName.CicPc, IsSuccessfulUpload = true };
            var domainStatProjectState2 = new DomainStatProjectState() { Producer = ProductName.CicPc, IsSuccessfulUpload = false };
            var domainStatProjectState3 = new DomainStatProjectState() { Producer = ProductName.CicPc, IsSuccessfulUpload = false };
            var domainStatProjectState4 = new DomainStatProjectState() { Producer = "ProductName", IsSuccessfulUpload = true };

            var domainReport = new DomainReport();

            var statProjectDeletionFilter = new Mock<IStatProjectCancellationFilter>();

            var cicPcCancellationFilter = new CicPcCancellationFilter();
            cicPcCancellationFilter.Set(statProjectDeletionFilter.Object);

            //Act
            cicPcCancellationFilter.Call(domainStatProjectState1, domainReport);
            cicPcCancellationFilter.Call(domainStatProjectState2, domainReport);
            cicPcCancellationFilter.Call(domainStatProjectState3, domainReport);
            cicPcCancellationFilter.Call(domainStatProjectState4, domainReport);

            //Assert
            Assert.AreEqual(2, domainReport.CicPcUploadCancels);
            statProjectDeletionFilter.Verify(m => m.Call(domainStatProjectState1, domainReport), Times.Once());
            statProjectDeletionFilter.Verify(m => m.Call(domainStatProjectState2, domainReport), Times.Once());
            statProjectDeletionFilter.Verify(m => m.Call(domainStatProjectState3, domainReport), Times.Once());
            statProjectDeletionFilter.Verify(m => m.Call(domainStatProjectState4, domainReport), Times.Once());
        }

        [TestMethod]
        public void CallWhenNotSetFelterTest()
        {
            //Arrange
            var domainStatProjectState = new DomainStatProjectState() { Producer = ProductName.CicPc, IsSuccessfulUpload = false };
            var domainReport = new DomainReport();

            var cicPcCancellationFilter = new CicPcCancellationFilter();

            //Act
            cicPcCancellationFilter.Call(domainStatProjectState, domainReport);
            cicPcCancellationFilter.Call(domainStatProjectState, domainReport);

            //Assert
            Assert.AreEqual(2, domainReport.CicPcUploadCancels);
        }
    }
}