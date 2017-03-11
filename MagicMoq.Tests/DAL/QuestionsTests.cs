﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MagicMoq.DAL;
using Moq;
using System.Collections.Generic;

namespace MagicMoq.Tests.DAL
{
    [TestClass]
    public class QuestionsTests
    {
        public Mock<Answers> mock_answers { get; set; } //accessibility level doesn't matter because its inside of the QuestionsTest Class
        private Questions questions { get; set; }

        [TestInitialize]
        public void Setup() //Name of this does not matter
        {
            //Runs before EVERY Test
            mock_answers = new Mock<Answers>();
            questions = new Questions(mock_answers.Object);
        }

        private void MyHelperMethod()
        {
            // do some stuff. global function inside of Questiontests Class
        }

        [TestCleanup]
        public void Cleanup()
        {
            //Runs after EVERY test
            mock_answers = null;
            questions = null;
        }

        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            Questions a_questions = new Questions();
            Assert.IsNotNull(a_questions);
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
            Questions a_questions = new Questions();

            Assert.IsNotNull(a_questions.Wand);
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
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World"); // How to highjack the method call
            
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

            // Add code that mocks the "Three" method response
            mock_answers.Setup(a => a.Two()).Returns(2);
            mock_answers.Setup(a => a.One()).Returns(1);

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
            // Arrange
            mock_answers.Setup(a => a.Two()).Returns(2);

            // Act
            int expected_result = 4;
            int actual_result = questions.TwoPlusTwo();
            // Assert

            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            // Arrange
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Two()).Returns(2);
            mock_answers.Setup(a => a.One()).Returns(1);

            // Act
            int expected_result = 3;
            int actual_result = questions.FourMinusTwoPlusOne();
            // Assert

            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            // Arrange
            mock_answers.Setup(a => a.Two()).Returns(2);
            mock_answers.Setup(a => a.Four()).Returns(4);
            // Act
            int expected_result = 2;
            int actual_result = questions.FourMinusTwo();
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5 });

            List<int> expected_result = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actual_result = questions.CountToFive();

            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 2, 4, 6 });

            List<int> expected_result = new List<int> { 2, 4, 6 };
            List<int> actual_result = questions.FirstThreeEvenInts();

            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 6))).Returns(new List<int> { 1, 2, 3, 4, 5, 6 });

            List<int> expected_result = new List<int> { 1, 3, 5};
            List<int> actual_result = questions.FirstThreeOddInts();

            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            // Arrange
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
            // Arrange
            mock_answers.Setup(a => a.Zero()).Returns(0);
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
            // Arrange
            mock_answers.Setup(a => a.Zero()).Returns(0);
            mock_answers.Setup(a => a.Two()).Returns(2);
            // Act
            int expected_result = 2;
            int actual_result = questions.TwoMinusZero();
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

    }
}
