using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kattis_3dprinter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis_3dprinter.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void DaysRequiredTest()
        {
            //Arrange
            int input = 1;
            int expected = 1;

            //Act
            int actual = Program.DaysRequired(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DaysRequiredTest2()
        {
            //Arrange
            int input = 5;
            int expected = 4;

            //Act
            int actual = Program.DaysRequired(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}