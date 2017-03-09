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
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World"); // Look for call to HelloWorld, then return
            // Add code that mocks the "HelloWorld" method response

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
            mock_answers.Setup(a => a.Zero()).Returns(0);
            // Add code that mocks the "Zero" method response

            Questions questions = new Questions(mock_answers.Object);

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
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.One()).Returns(1);
            // Add code that mocks the "Two" method response

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
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.One()).Returns(1);
            mock_answers.Setup(a => a.Two()).Returns(2);
            // Add code that mocks the "Three" method response
            Questions questions = new Questions(mock_answers.Object);

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
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.True()).Returns(true);
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
            mock_answers.Setup(a => a.False()).Returns(false);
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
            mock_answers.Setup(a => a.EmptyString()).Returns("");
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
            mock_answers.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mock_answers.Object);
            int expected = 4;
            int actual = questions.TwoPlusTwo();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Two()).Returns(2);
            mock_answers.Setup(a => a.One()).Returns(1);
            Questions questions = new Questions(mock_answers.Object);
            int expected = 3;
            int actual = questions.FourMinusTwoPlusOne();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mock_answers.Object);
            int expected = 2;
            int actual = questions.FourMinusTwoPlusOne();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>()))
                .Returns(new List<int>{ 1, 2, 3, 4, 5});
            Questions questions = new Questions(mock_answers.Object);
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actual = questions.CountToFive();
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>()))
                .Returns(new List<int> { 1, 2, 3, 4, 5, 6 });
            Questions questions = new Questions(mock_answers.Object);
            List<int> expected = new List<int> { 2, 4, 6 };
            List<int> actual = questions.FirstThreeEvenInts();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>()))
                .Returns(new List<int> { 1, 2, 3, 4, 5, 6 });
            Questions questions = new Questions(mock_answers.Object);
            List<int> expected = new List<int> { 1, 3, 5 };
            List<int> actual = questions.FirstThreeOddInts();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Zero()).Returns(0);
            Questions questions = new Questions(mock_answers.Object);
            int expected = 0;
            int actual = questions.ZeroPlusZero();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(a => a.Zero()).Returns(0);
            Questions questions = new Questions(mock_answers.Object);
            int expected = 4;
            int actual = questions.FourPlusZero();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Zero()).Returns(0);
            mock_answers.Setup(a => a.Two()).Returns(2);
            Questions questions = new Questions(mock_answers.Object);
            int expected = 2;
            int actual = questions.TwoMinusZero();
            Assert.AreEqual(expected, actual);
        }

    }
}
