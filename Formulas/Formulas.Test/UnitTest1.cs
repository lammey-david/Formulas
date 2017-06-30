using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Formulas.Test
{
    [TestClass]
    public class UnitTest1
    {
        List<Formulas> _expectedTotal;

        [TestInitialize]
        public void BeforeEach()
        {
            _expectedTotal = new List<Formulas>()
            {
                new Formulas()
                {
                    SubTotal = 2,
                    Total = 3
                }
            };
        }

        [TestMethod]
        public void ShouldGetTotal()
        {
            //Arange
            var totalList = new List<Formulas>(_expectedTotal);
            {
                new Formulas()
                {
                    SubTotal = 2,
                    Total = 3
                };
            }
            var repoMock = new Mock<FormulasRepository>();
            repoMock.Setup(repo => repo.GetTotal()).Returns(totalList);
            var Calculations = new FormulasCalculations(repoMock.Object);

            //Act
            var result = Calculations.GetTotal(3);

            //Assert
            Assert.IsTrue(result.SequenceEqual(_expectedTotal));
        }
    }
}
