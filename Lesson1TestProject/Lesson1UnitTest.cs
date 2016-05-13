using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123__S2016___Lesson1B;

namespace Lesson1TestProject
{
    [TestClass]
    /*
     * this class is used to test the lesson 1 Project
     * used for development only.
     * @Class Lesson1UnitTest*/
    public class Lesson1UnitTest
    {
        /*Unit Test for OutputStringToConsole Method of the program class*/
        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            /*3 things we do inside of our method to intiate a test method
             Arrange , Act, Assert*/
            //Arrange
            string outputString = "Enter Username: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = "Enter Username: ";

            //Act
            actualResult = Program.OutputStringToConsole(outputString, hasNewLine);
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
