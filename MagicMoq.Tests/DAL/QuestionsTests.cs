using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MagicMoq.DAL;
using Moq;
using System.Collections.Generic;

namespace MagicMoq.Tests.DAL
{
    [TestClass]
    public class QuestionsTests
    {
        private Mock<Answers> mock_answers { get; set; }
        private Questions questions { get; set; }



        [TestInitialize]// the attribute does matter
        public void Setup()// Name of this method does not matter
        {
            // Runs BEFORE EVERY test
            mock_answers = new Mock<Answers>();
            questions = new Questions(mock_answers.Object);

        }

        private void MyHelperMethod()
        {
            // Do some stuff, but it is not a test.
        }

        [TestCleanup]
        public void Cleanup()
        {
            //Runs AFTER EVERY test
            mock_answers = null;
            questions = null;
        }

        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            // Write this test
            Questions a_questions = new Questions();

            Assert.IsNotNull(a_questions);
        }

        [TestMethod]
        public void EnsureICanCreateAnswersInstance()
        {
            // Write this test
            Answers answers = new Answers();
            Assert.IsNotNull(answers);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsAnswersInstance()
        {
            // Hint: Implement a Constructor (for Questions class)
            Questions a_questions = new Questions();

            Assert.IsNotNull(a_questions.Wand);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsInjectedAnswersInstance()
        {

            // Hint 1: Create an instance of your Answers class
            Answers answers = new Answers();
            // Hint 2: Implement another Constructor (for Questions class)
            Questions questions = new Questions(answers);/* Hint 3: inject an Answers instance here*/

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureSayHelloReturnsHelloWorld()
        {
            // Arrange
            
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World");//How to hijack the method call
                //a => a.something()
                //function(a) {
                //return a.something();
                //}
            
            // Add code that mocks the "HelloWorld" method response

           //inject the "fake" answers instance into questions class

            // Act
            string expected_result = "Hello World";
            string actual_result = questions.SayHelloWorld();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureOneMinusOneReturnsZero()
        {
            // Arrange
            
            mock_answers.Setup(a => a.Zero()).Returns(0);
            // Add code that mocks the "Zero" method response

            

            // Act
            int expected_result = 0;
            int actual_result = questions.OneMinusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.Zero());
        }

        [TestMethod]
        public void EnsureOnePlusOneReturnsTwo()
        {
            // Arrange

            

            //Add code that mocks the two method response
            mock_answers.Setup(a => a.Two()).Returns(2);

            // Add code that mocks the "Two" method response

            // Act
            int expected_result = 2;
            int actual_result = questions.OnePlusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureOnePlusTwoReturnsThree()
        {
            // Arrange


            mock_answers.Setup(a => a.Three()).Returns(3);

            // Add code that mocks the "Three" method response

            // Act
            int expected_result = 3;
            int actual_result = questions.OnePlusTwo();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureThisReturnsTrue()
        {
            // Arrange


            // Add code that mocks the "True" method response
            mock_answers.Setup(a => a.True()).Returns(true);



            // Act
            bool expected_result = true;
            bool actual_result = questions.ReturnTrue();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureThisReturnsFalse()
        {
            // Arrange
            
            // Add code that mocks the "False" method response

            // Act
            bool expected_result = false;
            bool actual_result = questions.ReturnFalse();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureSayNothingReturnsEmptyString()
        {
            // Arrange
            

            //Add code that mocks the two method response
            mock_answers.Setup(a => a.EmptyString()).Returns("");

            // Add code that mocks the "EmptyString" method response
            // Act
            string expected_result = "";
            string actual_result = questions.SayNothing();
            
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoPlusTwoReturnsFour()
        {
     

            //Add code that mocks the two method response
            mock_answers.Setup(a => a.Four()).Returns(4);

            // Add code that mocks the "EmptyString" method response

            // Act
            int expected_result = 4;
            int actual_result = questions.TwoPlusTwo();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            // Write this test
            

            //Add code that mocks the two method response
            mock_answers.Setup(a => a.Three()).Returns(3);

            // Add code that mocks the "EmptyString" method response

            // Act
            int expected_result = 3;
            int actual_result = questions.FourMinusTwoPlusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            // Write this test


            //Add code that mocks the two method response
            mock_answers.Setup(a => a.Two()).Returns(2);

            // Add code that mocks the "EmptyString" method response

            // Act
            int expected_result = 2;
            int actual_result = questions.FourMinusTwo();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            // Write this test

            //It class - a matcher of Argument types
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 5))).Returns(new List<int> {1,2,3,4,5});
            // mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> {1,2,3,4,5});


            // Act
            List<int> expected_result = new List<int> {1,2,3,4,5};
            List<int> actual_result = questions.CountToFive();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);

        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            // Write this test

                //i needs to be large enough so you get a list that CONTAINS 3 even numbers
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 10))).Returns(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            // Act
            List<int> expected_result = new List<int> { 2,4,6 };
            List<int> actual_result = questions.FirstThreeEvenInts();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            // Write this test

            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 10))).Returns(new List<int> { 1,2,3,4,5,6,7,8,9,10 });


            // Act
            List<int> expected_result = new List<int> { 1,3,5};
            List<int> actual_result = questions.FirstThreeOddInts();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {

            mock_answers.Setup(a => a.Zero()).Returns(0);


            // Act
            int expected_result = 0;
            int actual_result = questions.ZeroPlusZero();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {

            mock_answers.Setup(a => a.Four()).Returns(4);


            // Act
            int expected_result = 4;
            int actual_result = questions.FourPlusZero();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {

            mock_answers.Setup(a => a.Two()).Returns(2);


            // Act
            int expected_result = 2;
            int actual_result = questions.TwoMinusZero();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

    }
}
