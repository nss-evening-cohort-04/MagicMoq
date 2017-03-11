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

        [TestInitialize]
        public void Setup() // Name does not matter
        {
            // Runs BEFORE every test
            mock_answers = new Mock<Answers>();
            questions = new Questions(mock_answers.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Runs AFTER every test
            mock_answers = null;
            questions = null;
        }

        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            Questions a_question = new Questions();

            Assert.IsNotNull(a_question);
        }

        [TestMethod]
        public void EnsureICanCreateAnswersInstance()
        {
            Answers answers = new Answers();

            Assert.IsNotNull(answers);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsAnswersInstance()
        {
            // Hint: Implement a Constructor (for Questions class)
            Questions a_question = new Questions();

            Assert.IsNotNull(a_question.Wand);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsInjectedAnswersInstance()
        {

            // Hint 1: Create an instance of your Answers class
            Answers answers = new Answers();

            // Hint 2: Implement another Constructor (for Questions class)
            Questions questions = new Questions(answers);

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureSayHelloReturnsHelloWorld()
        {
            // Arrange
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World");
            
            // Add code that mocks the "HelloWorld" method response


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
            mock_answers.Setup(a => a.One()).Returns(1);

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
            mock_answers.Setup(a => a.False()).Returns(false);


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

            // Add code that mocks the "EmptyString" method response
            mock_answers.Setup(a => a.EmptyString()).Returns("");


            // Act
            string expected_result = "";
            string actual_result = questions.SayNothing();
            
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoPlusTwoReturnsFour()
        {
            // Write this test

            mock_answers.Setup(a => a.Four()).Returns(4);


            int expected_result = 4;
            int actual_result = questions.TwoPlusTwo();

            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            mock_answers.Setup(a => a.Three()).Returns(3);


            int expected_response = 3;
            int actual_response = questions.FourMinusTwoPlusOne();

            Assert.AreEqual(expected_response, actual_response);
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            // Write this test
            mock_answers.Setup(a => a.Two()).Returns(2);


            int expected_response = 2;
            int actual_response = questions.FourMinusTwo();

            Assert.AreEqual(expected_response, actual_response);
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5 });


            List<int> expected_response = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actual_response = questions.CountToFive();

            CollectionAssert.AreEqual(expected_response, actual_response);
            //CollectionAssert.AreEqual(expected_response.Count, actual_response.Count);
        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            // Write this test
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            List<int> expected_response = new List<int> { 2, 4, 6 };
            List<int> actual_response = questions.FirstThreeEvenInts();

            CollectionAssert.AreEqual(expected_response, actual_response);
            mock_answers.Verify(a => a.ListOfNInts(It.IsAny<int>()));
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            List<int> expected_response = new List<int> { 1, 3, 5 };
            List<int> actual_response = questions.FirstThreeOddInts();

            CollectionAssert.AreEqual(expected_response, actual_response);
            mock_answers.Verify(a => a.ListOfNInts(It.IsAny<int>()));
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            // Write this test
            mock_answers.Setup(a => a.Zero()).Returns(0);


            int expected_result = 0;
            int actual_result = questions.ZeroPlusZero();

            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            // Write this test
            mock_answers.Setup(a => a.Four()).Returns(4);


            int expected_result = 4;
            int actual_result = questions.FourPlusZero();

            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            mock_answers.Setup(a => a.Two()).Returns(2);


            int expected_result = 2;
            int actual_result = questions.TwoMinusZero();

            Assert.AreEqual(expected_result, actual_result);
        }
    }
}
