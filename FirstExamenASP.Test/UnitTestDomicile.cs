using System;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ModelFakes = FirstExamenASP.Data.Repositories.Fakes;
using FirstExamenASP.Data.Repositories;
using FirstExamenASP.Domain.Entities;
using FirstExamenASP.Service;

namespace FirstExamenASP.Test
{
    /// <summary>
    /// Summary description for UnitTestDomicile
    /// </summary>
    [TestClass]
    public class UnitTestDomicile
    {
        public UnitTestDomicile()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TesGetDomicilesByPrice()
        {
            //Arrange Phase
            const double Prix = 30000;
            IDomicileRepository repository = new ModelFakes.StubIDomicileRepository
            {
                GetAll = () => {
                    var list = new List<Domicile> {
                                    new Domicile {Id = 1, NbrePiece = 5, Prix = 20000, Surface = 500},
                                    new Domicile {Id = 2, NbrePiece = 6, Prix = 30000, Surface = 600},
                                    new Domicile {Id = 3, NbrePiece = 7, Prix = 40000, Surface = 700}
                                };
                    return list.AsQueryable();
                }
            };
            ServiceToTest service = new ServiceToTest(repository);

            //Act Phase
            List<Domicile> domiciles = service.GetDomicilesByPrice(Prix).ToList();

            //Assert Phase
            Assert.AreEqual(1, domiciles.Count);
        }
    }
}
