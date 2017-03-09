using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicMoq.DAL
{
    // 1. Implement the IAnswers interface
    // 2. add 'virtual' to all the generated methods 
    // 3. Do NOT remove any lines that say: "throw new NotImplementedExeception();"
    public class Answers : IAnswers
    {
        public virtual string EmptyString()
        {
            throw new NotImplementedException();
        }

        public virtual bool False()
        {
            throw new NotImplementedException();
        }

        public virtual int Four()
        {
            throw new NotImplementedException();
        }

        public virtual string HelloWorld()
        {
            throw new NotImplementedException();
        }

        public virtual List<int> ListOfNInts(int n)
        {
            throw new NotImplementedException();
        }

        public virtual int One()
        {
            throw new NotImplementedException();
        }

        public virtual int Three()
        {
            throw new NotImplementedException();
        }

        public virtual bool True()
        {
            throw new NotImplementedException();
        }

        public virtual int Two()
        {
            throw new NotImplementedException();
        }

        public virtual int Zero()
        {
            throw new NotImplementedException();
        }
    }
}