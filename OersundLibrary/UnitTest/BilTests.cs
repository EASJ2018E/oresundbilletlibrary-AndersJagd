using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BilTests
    {
        /// <summary>
        /// Tester om prisen er den faste 410kr, uden BroBizz
        /// </summary>
        [TestMethod]
        public void BilPrisTest()
        {
            //Arrange
            Bil bilOne = new Bil("ABJEL17", DateTime.Now, false);

            //Act
            bilOne.Pris = bilOne.pris();

            //Assert
            Assert.AreEqual(410, bilOne.Pris);
        }

        /// <summary>
        /// Tester om prisen er den faste 161kr, med BroBizz
        /// </summary>
        [TestMethod]
        public void BilPrisTestBrobizz()
        {
            //Arrange
            Bil bilOne = new Bil("ABJEL17", DateTime.Now, true);

            //Act
            bilOne.Pris = bilOne.pris();

            //Assert
            Assert.AreEqual(new decimal(161), bilOne.Pris);
        }

        /// <summary>
        /// Tester om metoden k�ret�jType udprinter �resund Bil.
        /// </summary>
        [TestMethod]
        public void BilK�reT�jTest()
        {
            //Arrange
            Bil bilOne = new Bil("ABJEL17", DateTime.Now, true);

            //Act
            

            //Assert
            Assert.AreEqual("�resund Bil", bilOne.k�ret�jType());
        }

    }
}
