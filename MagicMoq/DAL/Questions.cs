using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicMoq.DAL
{
    // 1. Implement the IQuestions Interface
    // 2. Use the methods in your Answers class to address tasks/questions posed by this class
    // 3. Access an instance of your Answers class using the "Wand"
    public class Questions :IQuestions
    {
        public Answers Wand { get; set; } // This is important. Do not delete this.

        public Questions()
        {
            Wand = new Answers();
        }

        // Constructor
        public Questions(Answers answers)
        {
            Wand = answers;
        }

        public List<int> CountToFive()
        {
            return Wand.ListOfNInts(5);
        }

        public List<int> FirstThreeEvenInts()
        {
            return new List<int> { Wand.Zero(), Wand.Two(), Wand.Four() };
        }

        public List<int> FirstThreeOddInts()
        {
            return new List<int> { Wand.One(), Wand.Three(), (Wand.Two() + Wand.Three()) };
        }

        public int FourMinusTwo()
        {
            return Wand.Four() - Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            return (Wand.Four() - Wand.Two()) + Wand.One();
        }

        public int FourPlusZero()
        {
            return Wand.Four() + Wand.Zero();
        }

        public int OneMinusOne()
        {
            return Wand.One() - Wand.One();
        }

        public int OnePlusOne()
        {
            return Wand.One() + Wand.One();
        }

        public int OnePlusTwo()
        {
            return Wand.One() + Wand.Two();
        }

        public bool ReturnFalse()
        {
            return Wand.False();
        }

        public bool ReturnTrue()
        {
            return Wand.True();
        }

        public string SayHelloWorld()
        {
            return Wand.HelloWorld();
        }

        public string SayNothing()
        {
            return Wand.EmptyString();
        }

        public int TwoMinusZero()
        {
            return Wand.Two() - Wand.Zero();
        }

        public int TwoPlusTwo()
        {
            return Wand.Two() + Wand.Two();
        }

        public int ZeroPlusZero()
        {
            return Wand.Zero() + Wand.Zero();
        }
    }
}