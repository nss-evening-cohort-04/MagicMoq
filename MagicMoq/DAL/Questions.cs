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
            // Option 1:
            return Wand.Two();

            // Option 2:
            //return Wand.One() + Wand.One();
        }

        public int ZeroPlusZero()
        {
            throw new NotImplementedException();
        }

        public int FourPlusZero()
        {
            throw new NotImplementedException();
        }

        public int TwoMinusZero()
        {
            throw new NotImplementedException();
        }

        public int OnePlusTwo()
        {
            return Wand.Three();
        }

        public int OnePlusTwoV2()
        {
            return Wand.One() + Wand.Two();
        }

        public int TwoPlusTwo()
        {
            return Wand.Two() + Wand.Two();
        }

        public int OneMinusOne()
        {
            // Option 1:
            return Wand.Zero(); // Passes without Mocking b/c False Positive
            // int i; i is zero by default.

            // Option 2:
            //return Wand.One() - Wand.One();
        }

        public int FourMinusTwo()
        {
            return Wand.Two();
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

        public bool ReturnTrueV2()
        {
            return !Wand.False();
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
            List<int> numbers = Wand.ListOfNInts(10); // Pre sorted
            // Use numbers.Sort() if ListOfNInts doesn't return sorted items
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }

                if (result.Count == 3)
                {
                    break; // Exit loop
                }
            }
            return result;
        }

        public List<int> FirstThreeOddInts()
        {
            List<int> numbers = Wand.ListOfNInts(10); // Pre sorted
            // Use numbers.Sort() if ListOfNInts doesn't return sorted items
            List<int> result = new List<int>();
            foreach (var number in numbers)
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
        }
    }
}