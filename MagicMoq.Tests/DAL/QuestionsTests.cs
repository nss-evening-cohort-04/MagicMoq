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
        // Runs BEFORE every test
        public void Setup() // Name of this method does not matter
        {
            mock_answers = new Mock<Answers>();
            questions = new Questions(mock_answers.Object);
        }

        [TestCleanup]
        // Runs AFTER every test
        public void Cleanup()
        {
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
            Questions questions = new Questions();
            Assert.IsNotNull(questions.Wand);
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
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World"); // Look for call to HelloWorld, then return
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
            mock_answers.Setup(a => a.One()).Returns(1);
            mock_answers.Setup(a => a.Two()).Returns(2);
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
            mock_answers.Setup(a => a.True()).Returns(true);
            // Add code that mocks the "True" method response
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
            mock_answers.Setup(a => a.False()).Returns(false);
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
            mock_answers.Setup(a => a.Two()).Returns(2);
            int expected = 4;
            int actual = questions.TwoPlusTwo();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Two()).Returns(2);
            mock_answers.Setup(a => a.One()).Returns(1);
            int expected = 3;
            int actual = questions.FourMinusTwoPlusOne();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Two()).Returns(2);
            int expected = 2;
            int actual = questions.FourMinusTwoPlusOne();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            // It class - a Matcher of Argument types
            // It.Is<int>()
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i==5)))
                .Returns(new List<int>{ 1, 2, 3, 4, 5});
            // Least Restrictive
            // mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>()))
            //    .Returns(new List<int>{ 1, 2, 3, 4, 5});
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actual = questions.CountToFive();
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 6)))
                .Returns(new List<int> { 1, 2, 3, 4, 5, 6 });
            List<int> expected = new List<int> { 2, 4, 6 };
            List<int> actual = questions.FirstThreeEvenInts();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 6)))
                .Returns(new List<int> { 1, 2, 3, 4, 5, 6 });
            List<int> expected = new List<int> { 1, 3, 5 };
            List<int> actual = questions.FirstThreeOddInts();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            mock_answers.Setup(a => a.Zero()).Returns(0);
            int expected = 0;
            int actual = questions.ZeroPlusZero();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Zero()).Returns(0);
            int expected = 4;
            int actual = questions.FourPlusZero();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            mock_answers.Setup(a => a.Zero()).Returns(0);
            mock_answers.Setup(a => a.Two()).Returns(2);
            int expected = 2;
            int actual = questions.TwoMinusZero();
            Assert.AreEqual(expected, actual);
        }

    }
}
