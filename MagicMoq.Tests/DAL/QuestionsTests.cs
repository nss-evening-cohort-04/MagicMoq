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
        private Questions questions { get; set; }

        private Answers answers { get; set; }

        [TestInitialize]
        public void testInit()
        {
            //List<int>
             questions = new Questions();
             answers = new Answers();
            //Questions questions = new Questions(answers);
        }

        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            // Write this test
            //Questions questions = new Questions();

            Assert.IsNotNull(questions);
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
            Questions questions = new Questions();

            Assert.IsNotNull(questions.Wand);
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
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World");//How to hijack the method call
                //a => a.something()
                //function(a) {
                //return a.something();
                //}
            
            // Add code that mocks the "HelloWorld" method response

            Questions questions = new Questions(mock_answers.Object);//inject the "fake" answers instance into questions class

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
            mock_answers.Verify(a => a.Zero());
        }

        [TestMethod]
        public void EnsureOnePlusOneReturnsTwo()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            

            //Add code that mocks the two method response
            mock_answers.Setup(a => a.Two()).Returns(2);

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

            mock_answers.Setup(a => a.Three()).Returns(3);

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

            // Add code that mocks the "True" method response
            mock_answers.Setup(a => a.True()).Returns(true);


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

            //Add code that mocks the two method response
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
            // Write this test
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            // Write this test
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> {1,2,3,4,5});

            Questions questions = new Questions(mock_answers.Object);

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
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 2,4,6 });

            Questions questions = new Questions(mock_answers.Object);

            // Act
            List<int> expected_result = new List<int> { 2,4,6 };
            List<int> actual_result = questions.CountToFive();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            // Write this test
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1,3,5 });

            Questions questions = new Questions(mock_answers.Object);

            // Act
            List<int> expected_result = new List<int> { 1,3,5};
            List<int> actual_result = questions.CountToFive();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Zero()).Returns(0);

            Questions questions = new Questions(mock_answers.Object);

            // Act
            int expected_result = 0;
            int actual_result = questions.ZeroPlusZero();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Four()).Returns(4);

            Questions questions = new Questions(mock_answers.Object);

            // Act
            int expected_result = 4;
            int actual_result = questions.FourPlusZero();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Two()).Returns(2);

            Questions questions = new Questions(mock_answers.Object);

            // Act
            int expected_result = 2;
            int actual_result = questions.TwoMinusZero();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

    }
}
