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
        [TestMethod] //done
        public void EnsureICanCreateQuestionsInstance()
        {
            Questions questions = new Questions();
            Assert.IsNotNull(questions);
        }

        [TestMethod] //done
        public void EnsureICanCreateAnswersInstance()
        {
            Answers answers = new Answers();
            Assert.IsNotNull(answers);
        }

        [TestMethod] //done
        public void EnsureQuestionsReturnsAnswersInstance()
        {
            Questions questions = new Questions();
            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod] //done
        public void EnsureQuestionsReturnsInjectedAnswersInstance()
        {
            Answers answers = new Answers();
            Questions questions = new Questions(answers);
            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod] //done
        public void EnsureSayHelloReturnsHelloWorld()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.HelloWorld()).Returns("Hello World");
            Questions questions = new Questions(mockAnswers.Object);
            string expectedResult = "Hello World";
            string actualResult = questions.SayHelloWorld();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureOneMinusOneReturnsZero()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Zero()).Returns(0);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 0;
            int actualResult = questions.OneMinusOne();
            Assert.AreEqual(expectedResult, actualResult);
            mockAnswers.Verify();
        }

        [TestMethod] //done
        public void EnsureOnePlusOneReturnsTwo()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 2;
            int actualResult = questions.OnePlusOne();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureOnePlusTwoReturnsThree()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Three()).Returns(3);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 3;
            int actualResult = questions.OnePlusTwo();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureThisReturnsTrue()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.True()).Returns(true);
            Questions questions = new Questions(mockAnswers.Object);
            bool expectedResult = true;
            bool actualResult = questions.ReturnTrue();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureThisReturnsFalse()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.False()).Returns(false);
            Questions questions = new Questions(mockAnswers.Object);
            bool expectedResult = false;
            bool actualResult = questions.ReturnFalse();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureSayNothingReturnsEmptyString()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.EmptyString()).Returns("");
            Questions questions = new Questions(mockAnswers.Object);
            string expectedResult = "";
            string actualResult = questions.SayNothing();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureTwoPlusTwoReturnsFour()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Four()).Returns(4);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 4;
            int actualResult = questions.TwoPlusTwo();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Three()).Returns(3);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 3;
            int actualResult = questions.FourMinusTwoPlusOne();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFourMinusTwoReturnsTwo()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 2;
            int actualResult = questions.FourMinusTwo();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5 });
            Questions questions = new Questions(mockAnswers.Object);
            List<int> expectedResult = new List<int> { 1, 2, 3, 4, 5};
            List<int> actualResult = questions.CountToFive();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 2, 4, 6 });
            Questions questions = new Questions(mockAnswers.Object);
            List<int> expectedResult = new List<int> { 2, 4, 6 };
            List<int> actualResult = questions.FirstThreeEvenInts();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5 });
            Questions questions = new Questions(mockAnswers.Object);
            List<int> expectedResult = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actualResult = questions.FirstThreeOddInts();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureZeroPlusZeroReturnsZero()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Zero()).Returns(0);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 0;
            int actualResult = questions.ZeroPlusZero();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFourPlusZeroReturnsFour()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Four()).Returns(4);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 4;
            int actualResult = questions.FourPlusZero();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            Mock<Answers> mockAnswers = new Mock<Answers>();
            mockAnswers.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mockAnswers.Object);
            int expectedResult = 2;
            int actualResult = questions.TwoMinusZero();
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
