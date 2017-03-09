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
            Mock<Answers> mockAnswer = new Mock<Answers>();

            // Add code that mocks the "HelloWorld" method response
            mockAnswer.Setup(a => a.HelloWorld()).Returns("Hello World");

            Questions questions = new Questions(mockAnswer.Object);

            // Act
            string expected_result = "Hello World";
            string actual_result = questions.SayHelloWorld();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            
            // Methods used in this test
            mockAnswer.Verify(a => a.HelloWorld());
        }

        [TestMethod]
        public void EnsureOneMinusOneReturnsZero()
        {
            // Arrange
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);
            // Add code that mocks the "Zero" method response
            mockAnswer.Setup(a => a.One()).Returns(0);

            // Act
            int expected_result = 0;
            int actual_result = questions.OneMinusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            
            // Methods used in this test
            mockAnswer.Verify(a => a.One());
        }

        [TestMethod]
        public void EnsureOnePlusOneReturnsTwo()
        {
            // Arrange
            Mock<Answers> mockAnswer = new Mock<Answers>();
            mockAnswer.Setup(a => a.One()).Returns(1);
            // Add code that mocks the "Two" method response
            // mockAnswer.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mockAnswer.Object);

            // Act
            int expected_result = 2;
            int actual_result = questions.OnePlusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);

            // Methods used in this test
            mockAnswer.Verify(a => a.One());
        }

        [TestMethod]
        public void EnsureOnePlusTwoReturnsThree()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.One()).Returns(1);
            mockAnswer.Setup(a => a.Two()).Returns(2);

            int expectedResult = 3;
            int actualResult = questions.OnePlusTwo();

            Assert.AreEqual(expectedResult, actualResult);
            
            // Ensures the proper tests were run
            mockAnswer.Verify(a => a.One());
            mockAnswer.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureThisReturnsTrue()
        {
            // Arrange
            Mock<Answers> mockAnswer = new Mock<Answers>();
            // Add code that mocks the "True" method response
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.True()).Returns(true);
            // Act
            bool expected_result = true;
            bool actual_result = questions.ReturnTrue();

            // Assert
            Assert.AreEqual(expected_result, actual_result);

            // Methods used in this test
            mockAnswer.Verify(a => a.True());
        }

        [TestMethod]
        public void EnsureThisReturnsFalse()
        {
            // Arrange
            Mock<Answers> mockAnswer = new Mock<Answers>();
            // Add code that mocks the "False" method response
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.False()).Returns(false);
            // Act
            bool expected_result = false;
            bool actual_result = questions.ReturnFalse();

            // Assert
            Assert.AreEqual(expected_result, actual_result);

            // Methods used in this test
            mockAnswer.Verify(a => a.False());
        }

        [TestMethod]
        public void EnsureSayNothingReturnsEmptyString()
        {
            // Arrange
            Mock<Answers> mockAnswer = new Mock<Answers>();
            
            // Add code that mocks the "EmptyString" method response
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.EmptyString()).Returns("");

            // Act
            string expected_result = "";
            string actual_result = questions.SayNothing();
            
            // Assert
            Assert.AreEqual(expected_result, actual_result);

            // Methods used in this test
            mockAnswer.Verify(a => a.EmptyString());
        }

        [TestMethod]
        public void EnsureTwoPlusTwoReturnsFour()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.Two()).Returns(2);

            int expectedResult = 4;
            int actualResult = questions.TwoPlusTwo();

            Assert.AreEqual(expectedResult, actualResult);

            // Methods used in this test
            mockAnswer.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.Four()).Returns(4);
            mockAnswer.Setup(a => a.Two()).Returns(2);
            mockAnswer.Setup(a => a.One()).Returns(1);

            int expectedResult = 3;
            int actualResult = questions.FourMinusTwoPlusOne();

            Assert.AreEqual(expectedResult, actualResult);

            // Methods used in this test
            mockAnswer.Verify(a => a.Four());
            mockAnswer.Verify(a => a.Two());
            mockAnswer.Verify(a => a.One());
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.Four()).Returns(4);
            mockAnswer.Setup(a => a.Two()).Returns(2);

            int expectedResult = 2;
            int actualResult = questions.FourMinusTwo();

            Assert.AreEqual(expectedResult, actualResult);

            // Methods used in this test
            mockAnswer.Verify(a => a.Four());
            mockAnswer.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5});

            List<int> expectedResult = new List<int> {1, 2, 3, 4, 5};
            List<int> actualResult = questions.CountToFive();

            CollectionAssert.AreEqual(expectedResult, actualResult);

            // Methods used in this test
            mockAnswer.Verify(a => a.ListOfNInts(It.IsAny<int>()));
        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.Two()).Returns(2);
            mockAnswer.Setup(a => a.Four()).Returns(4);

            List<int> expectedResult = new List<int> { 2, 4, 6 };
            List<int> actualResult = questions.FirstThreeEvenInts();

            CollectionAssert.AreEqual(expectedResult, actualResult);

            // Methods used in this test
            mockAnswer.Verify(a => a.Two());
            mockAnswer.Verify(a => a.Four());
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.One()).Returns(1);
            mockAnswer.Setup(a => a.Two()).Returns(2);
            mockAnswer.Setup(a => a.Three()).Returns(3);

            List<int> expectedResult = new List<int> { 1, 3, 5 };
            List<int> actualResult = questions.FirstThreeOddInts();

            CollectionAssert.AreEqual(expectedResult, actualResult);

            // Methods used in this test
            mockAnswer.Verify(a => a.One());
            mockAnswer.Verify(a => a.Two());
            mockAnswer.Verify(a => a.Three());
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.Zero()).Returns(0);

            int expectedResult = 0;
            int actualResult = questions.ZeroPlusZero();

            Assert.AreEqual(expectedResult, actualResult);

            // Methods used in this test
            mockAnswer.Verify(a => a.Zero());
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.Zero()).Returns(0);
            mockAnswer.Setup(a => a.Four()).Returns(4);

            int expectedResult = 4;
            int actualResult = questions.FourPlusZero();

            Assert.AreEqual(expectedResult, actualResult);

            // Ensures the proper tests were run
            mockAnswer.Verify(a => a.Zero());
            mockAnswer.Verify(a => a.Four());
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            Mock<Answers> mockAnswer = new Mock<Answers>();
            Questions questions = new Questions(mockAnswer.Object);

            mockAnswer.Setup(a => a.Zero()).Returns(0);
            mockAnswer.Setup(a => a.Two()).Returns(2);

            int expectedResult = 2;
            int actualResult = questions.TwoMinusZero();

            Assert.AreEqual(expectedResult, actualResult);

            // Ensures the proper tests were run
            mockAnswer.Verify(a => a.Zero());
            mockAnswer.Verify(a => a.Two());
        }

    }
}
