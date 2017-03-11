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

        public Questions()
        {
            Wand = new Answers(); // the '=' SETS a new instance of Wand
        }

        public Questions(Answers answer)
        {
            Wand = answer;
        }

        public List<int> CountToFive()
        {
            return Wand.ListOfNInts(5);
        }

        public List<int> FirstThreeEvenInts()
        {
            List<int> numbers = Wand.ListOfNInts(6); //Pre-sorted
            // Use numbers.Sort() if ListofNInts doesn't return sorted items
            List<int> result = new List<int>();

            foreach(var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }

                if (result.Count == 3)
                {
                    break;
                }
            }
            return result;
        }

        public List<int> FirstThreeOddInts()
        {
            List<int> numbers = Wand.ListOfNInts(6);
            List<int> result = new List<int>();

            foreach(var number in numbers)
            {
                if (number %2 != 0)
                {
                    result.Add(number);
                }
                // this i called after the first If statement
                if (result.Count == 3) // only returns the first 3 numbers, makes it restrictive
                {
                    break; // Exit Loop
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
            // Option 1
            return Wand.Zero();

            // Option 2
            // return Wand.One() - Wand.One();
        }

        public int OnePlusOne()
        {
            return Wand.One() + Wand.One();
        }

        public int OnePlusTwo()
        {
            return Wand.Three();
        }

        public int OnePlusTwoV2()
        {
            return Wand.One() + Wand.Two();  //should use this way, will help
        }

        public bool ReturnFalse()
        {
            return false;
        }

        public bool ReturnTrue()
        {
            return true;
        }

        public string SayHelloWorld()
        {
            return Wand.HelloWorld(); // using HelloWorld from the Answers Class
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