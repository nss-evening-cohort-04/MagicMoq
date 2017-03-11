using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicMoq.DAL
{
    // 1. Implement the IQuestions Interface
    // 2. Use the methods in your Answers class to address tasks/questions posed by this class
    // 3. Access an instance of your Answers class using the "Wand"
    public class Questions : IQuestions
    {
        public Answers Wand { get; set; } // This is important. Do not delete this.

        public Questions ()
        {
            Wand = new Answers();
        }

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
            List<int> numbers = Wand.ListOfNInts(6);

            List<int> result = new List<int>();

            foreach ( var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }
                return result;
        }

        public List<int> FirstThreeOddInts()
        {
            List<int> numbers = Wand.ListOfNInts(6);

            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public int FourMinusTwo()
        {
            return Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            return Wand.Three();
        }

        public int FourPlusZero()
        {
            return Wand.Four();
        }

        public int OneMinusOne()
        {
            //option one
            return Wand.Zero();

            //option two
            //return Wand.One() - Wand.One();
        }

        public int OnePlusOne()
        {
            //option one: 
            return Wand.Two();
           //option two: return Wand.One() + Wand.One();
        }

        public int OnePlusTwo()
        {
            return Wand.Three();
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
            return Wand.Two();
        }

        public int TwoPlusTwo()
        {
            return Wand.Four();
        }

        public int ZeroPlusZero()
        {
            return Wand.Zero();
        }
    }
}