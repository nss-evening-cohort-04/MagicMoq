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
        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            Questions questions = new Questions();

            Assert.IsNotNull(questions);
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
            Mock<Answers> mock_answers = new Mock<Answers>();

            // Add code that mocks the "HelloWorld" method response
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World");

            Questions questions = new Questions(mock_answers.Object);

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
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);
            // Add code that mocks the "Zero" method response
            mock_answers.Setup(a => a.One()).Returns(0);


            // Act
            int expected_result = 0;
            int actual_result = questions.OneMinusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.One());
        }

        [TestMethod]
        public void EnsureOnePlusOneReturnsTwo()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.One()).Returns(1);
            // Add code that mocks the "Two" method response
            // mock_answers.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mock_answers.Object);

            // Act
            int expected_result = 2;
            int actual_result = questions.OnePlusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureOnePlusTwoReturnsThree()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);

            mock_answers.Setup(a => a.One()).Returns(1);
            mock_answers.Setup(a => a.Two()).Returns(2);

            int expectedResult = 3;
            int actualResult = questions.OnePlusTwo();

            Assert.AreEqual(expectedResult, actualResult);
            // Ensures the proper tests were run
            mock_answers.Verify(a => a.One());
            mock_answers.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureThisReturnsTrue()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            // Add code that mocks the "True" method response

            Questions questions = new Questions(mock_answers.Object);

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
            Mock<Answers> mock_answers = new Mock<Answers>();
            // Add code that mocks the "False" method response
            Questions questions = new Questions(mock_answers.Object);

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
            Mock<Answers> mock_answers = new Mock<Answers>();
            
            // Add code that mocks the "EmptyString" method response
            Questions questions = new Questions(mock_answers.Object);

            // Act
            string expected_result = "";
            string actual_result = questions.SayNothing();
            
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoPlusTwoReturnsFour()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);

            mock_answers.Setup(a => a.Two()).Returns(2);

            int expectedResult = 4;
            int actualResult = questions.TwoPlusTwo();

            Assert.AreEqual(expectedResult, actualResult);
            mock_answers.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);

            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Two()).Returns(2);
            mock_answers.Setup(a => a.One()).Returns(1);

            int expectedResult = 3;
            int actualResult = questions.FourMinusTwoPlusOne();

            Assert.AreEqual(expectedResult, actualResult);
            mock_answers.Verify(a => a.Four());
            mock_answers.Verify(a => a.Two());
            mock_answers.Verify(a => a.One());
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);

            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Two()).Returns(2);

            int expectedResult = 2;
            int actualResult = questions.FourMinusTwo();

            Assert.AreEqual(expectedResult, actualResult);
            mock_answers.Verify(a => a.Four());
            mock_answers.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            Mock<Answers> mock_answer = new Mock<Answers>();
            Questions questions = new Questions(mock_answer.Object);

            mock_answer.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5});

            List<int> expectedResult = new List<int> {1, 2, 3, 4, 5};
            List<int> actualResult = questions.CountToFive();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            Mock<Answers> mock_answer = new Mock<Answers>();
            Questions questions = new Questions(mock_answer.Object);

            mock_answer.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 0, 2, 4 });

            List<int> expectedResult = new List<int> { 0, 2, 4 };
            List<int> actualResult = questions.CountToFive();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);

            mock_answers.Setup(a => a.Zero()).Returns(0);

            int expectedResult = 0;
            int actualResult = questions.ZeroPlusZero();

            Assert.AreEqual(expectedResult, actualResult);
            mock_answers.Verify(a => a.Zero());
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);

            mock_answers.Setup(a => a.Zero()).Returns(0);
            mock_answers.Setup(a => a.Four()).Returns(4);

            int expectedResult = 4;
            int actualResult = questions.FourPlusZero();

            Assert.AreEqual(expectedResult, actualResult);
            // Ensures the proper tests were run
            mock_answers.Verify(a => a.Zero());
            mock_answers.Verify(a => a.Four());
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            Questions questions = new Questions(mock_answers.Object);

            mock_answers.Setup(a => a.Zero()).Returns(0);
            mock_answers.Setup(a => a.Two()).Returns(2);

            int expectedResult = 2;
            int actualResult = questions.TwoMinusZero();

            Assert.AreEqual(expectedResult, actualResult);
            // Ensures the proper tests were run
            mock_answers.Verify(a => a.Zero());
            mock_answers.Verify(a => a.Two());
        }

    }
}
