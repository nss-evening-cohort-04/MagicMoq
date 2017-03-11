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
        public Answers Wand { get; set; } // This is important. Do not delete this. Declared a variable.

        public Questions()
        {
            Wand = new Answers(); //set the variable. Set the type to Answers().
        }

        public Questions(Answers answers)
        {
            Wand = answers;
        }

        public int OnePlusOne()
        {
            //return Wand.Two();

            return Wand.One() + Wand.One();
        }

        public int ZeroPlusZero()
        {
            return Wand.Zero() + Wand.Zero();
        }

        public int FourPlusZero()
        {
            return Wand.Four() + Wand.Zero();
        }

        public int TwoMinusZero()
        {
            return Wand.Two() - Wand.Zero();
        }

        public int OnePlusTwo()
        {
            return Wand.One() + Wand.Two();
        }

        public int TwoPlusTwo()
        {
            return Wand.Two() + Wand.Two();
        }

        public int OneMinusOne()
        {
            //return Wand.Zero(); // Passes without Mocking because False Pos
            // int i; 

            return Wand.One() - Wand.One();
        }

        public int FourMinusTwo()
        {
            return Wand.Four() - Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            return Wand.Four() - Wand.Two() + Wand.One();
        }

        public string SayNothing()
        {
            return Wand.EmptyString();
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

        public List<int> CountToFive()
        {
            return Wand.ListOfNInts(5);
        }

        public List<int> FirstThreeEvenInts()
        {
            //return Wand.ListOfNInts(3);

            List<int> numbers = Wand.ListOfNInts(6); //Pre sorted
            // Use numbers.Sort() if ListOfInts doesn't return sorted items
            List<int> result = new List<int>();
            
            foreach (var number in numbers)
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
            //return Wand.ListOfNInts(3);

            List<int> numbers = Wand.ListOfNInts(6); //Pre sorted
            // Use numbers.Sort() if ListOfInts doesn't return sorted items
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 1)
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}