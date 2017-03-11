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
            Wand = new Answers();
        }

        public Questions(Answers answers)
        {
            Wand = answers;
        }

        public int OnePlusOne()
        {
            // return Wand.Two();
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
            // option 1
            return Wand.Zero();
            // option 2
            // return Wand.One() - Wand.One();
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
            List<int> numbers = Wand.ListOfNInts(6); // List is pre sorted
            // Use numbers.Sort() if ListofNInts doesn't return sorted items
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if(number % 2 == 0)
                {
                    result.Add(number);
                }
                if (result.Count == 3)
                {
                    break; // Exit loop
                }
            }
            return result;

            // If it is not a pre sorted collection
            /*
            int[] temp = Wand.ListOfNInts(6).ToArray();
            List<int> result = new List<int>();
            for (int i = 0, count = 0; count < 3; i++)
            {
                if (temp[i] % 2 == 0)
                {
                    result.Add(temp[i]);
                    count++;
                }
            }
            return result;
            */
        }

        public List<int> FirstThreeOddInts()
        {
            List<int> numbers = Wand.ListOfNInts(6); // List is pre sorted
            // Use numbers.Sort() if ListofNInts doesn't return sorted items
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    result.Add(number);
                }
                if (result.Count == 3)
                {
                    break; // Exit loop
                }
            }
            return result;
            /*
            int[] temp = Wand.ListOfNInts(6).ToArray();
            List<int> result = new List<int>();
            for (int i = 0, count = 0; count < 3; i++)
            {
                if ((temp[i] + 1) % 2 == 0)
                {
                    result.Add(temp[i]);
                    count++;
                }
            }
            return result;
            */
        }
    }
}