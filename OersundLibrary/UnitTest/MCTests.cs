using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// Tester om prisen er den faste 210kr, uden BroBizz
        /// </summary>
        [TestMethod]
        public void MCPrisTest()
        {
            //Arrange
            MC MCOne = new MC("ABJEL17", DateTime.Now, false);

            //Act
            MCOne.Pris = MCOne.pris();

            //Assert
            Assert.AreEqual(210, MCOne.Pris);
        }

        /// <summary>
        /// Tester om prisen er den faste 73kr, med BroBizz
        /// </summary>
        [TestMethod]
        public void MCPrisTestBrobizz()
        {
            //Arrange
            MC MCOne = new MC("ABJEL17", DateTime.Now, true);

            //Act
            MCOne.Pris = MCOne.pris();

            //Assert
            Assert.AreEqual(73, MCOne.Pris);
        }

        /// <summary>
        /// Tester om metoden k�ret�jType udprinter �resund MC.
        /// </summary>
        [TestMethod]
        public void MCK�reT�jTest()
        {
            //Arrange
            MC MCOne = new MC("ABJEL17", DateTime.Now, true);

            //Act
            

            //Assert
            Assert.AreEqual("�resund MC", MCOne.k�ret�jType());
        }

    }
}
