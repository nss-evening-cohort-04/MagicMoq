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
        public Mock<Answers> mockAnswers { get; set; }
        private Questions questions { get; set; }

        [TestInitialize]
        public void Setup()
        {
            mockAnswers = new Mock<Answers>();
            questions = new Questions(mockAnswers.Object);
        }

        private void MyHelperMethod()
        {
            // Do some stuff, but not a test.
        }

        [TestCleanup]
        public void Cleanup()
        {
            mockAnswers = null;
            questions = null;
        }

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
            mockAnswers.Setup(a => a.HelloWorld()).Returns("Hello World");
            string expectedResult = "Hello World";
            string actualResult = questions.SayHelloWorld();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureOneMinusOneReturnsZero()
        {
            mockAnswers.Setup(a => a.Zero()).Returns(0);
            int expectedResult = 0;
            int actualResult = questions.OneMinusOne();
            Assert.AreEqual(expectedResult, actualResult);
            mockAnswers.Verify();
        }

        [TestMethod] //done
        public void EnsureOnePlusOneReturnsTwo()
        {
            mockAnswers.Setup(a => a.Two()).Returns(2);
            int expectedResult = 2;
            int actualResult = questions.OnePlusOne();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureOnePlusTwoReturnsThree()
        {
            mockAnswers.Setup(a => a.Three()).Returns(3);
            int expectedResult = 3;
            int actualResult = questions.OnePlusTwo();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureThisReturnsTrue()
        {
            mockAnswers.Setup(a => a.True()).Returns(true);
            bool expectedResult = true;
            bool actualResult = questions.ReturnTrue();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureThisReturnsFalse()
        {
            mockAnswers.Setup(a => a.False()).Returns(false);
            bool expectedResult = false;
            bool actualResult = questions.ReturnFalse();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureSayNothingReturnsEmptyString()
        {
            mockAnswers.Setup(a => a.EmptyString()).Returns("");
            string expectedResult = "";
            string actualResult = questions.SayNothing();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureTwoPlusTwoReturnsFour()
        {
            mockAnswers.Setup(a => a.Four()).Returns(4);
            int expectedResult = 4;
            int actualResult = questions.TwoPlusTwo();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            mockAnswers.Setup(a => a.Three()).Returns(3);
            int expectedResult = 3;
            int actualResult = questions.FourMinusTwoPlusOne();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFourMinusTwoReturnsTwo()
        {
            mockAnswers.Setup(a => a.Two()).Returns(2);
            int expectedResult = 2;
            int actualResult = questions.FourMinusTwo();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            mockAnswers.Setup(a => a.ListOfNInts(It.Is<int>(i => i ==5))).Returns(new List<int> { 1, 2, 3, 4, 5 });
            List<int> expectedResult = new List<int> { 1, 2, 3, 4, 5};
            List<int> actualResult = questions.CountToFive();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            mockAnswers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 6))).Returns(new List<int> { 1, 2, 3, 4, 5, 6 });
            List<int> expectedResult = new List<int> { 2, 4, 6 };
            List<int> actualResult = questions.FirstThreeEvenInts();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            mockAnswers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 10))).Returns(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            List<int> expectedResult = new List<int> { 1, 3, 5 };
            List<int> actualResult = questions.FirstThreeOddInts();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureZeroPlusZeroReturnsZero()
        {
            mockAnswers.Setup(a => a.Zero()).Returns(0);
            int expectedResult = 0;
            int actualResult = questions.ZeroPlusZero();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureFourPlusZeroReturnsFour()
        {
            mockAnswers.Setup(a => a.Four()).Returns(4);
            int expectedResult = 4;
            int actualResult = questions.FourPlusZero();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod] //done
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            mockAnswers.Setup(a => a.Two()).Returns(2);
            int expectedResult = 2;
            int actualResult = questions.TwoMinusZero();
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
