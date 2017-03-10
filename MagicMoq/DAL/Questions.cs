﻿using System;
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
            //option 1
            return Wand.Two();

            //option 2
            //return Wand.One() + Wand.One();
        }

        public int ZeroPlusZero()
        {
            return Wand.Zero();
        }

        public int FourPlusZero()
        {
            return Wand.Four();
        }

        public int TwoMinusZero()
        {
            return Wand.Two();
        }

        public int OnePlusTwo()
        {
            return Wand.Three();
        }

        public int TwoPlusTwo()
        {
            return Wand.Four();
        }

        public int OneMinusOne()
        {
            //option 1
            return Wand.Zero();

            //option 2
            //return Wand.One() - Wand.One();
        }

        public int FourMinusTwo()
        {
            return Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            return Wand.Three();
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
            return Wand.ListOfNInts(3);
        }

        public List<int> FirstThreeOddInts()
        {
            return Wand.ListOfNInts(3);
        }
    }
}