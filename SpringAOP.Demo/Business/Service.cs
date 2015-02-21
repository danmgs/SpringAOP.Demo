using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringAOP.Demo.Business
{
    public class Service : IService
    {
        public Service()
        {
        }

        public virtual void DoSomething(DateTime date)
        {
            Console.WriteLine(string.Format("I am doing something at {0}", date));
        }

        public virtual int TrySomethingWithFailure()
        {
            Random r = new Random();
            var rNum = r.Next();

            if (rNum % 2 == 0)
            {
                Console.WriteLine(string.Format("ERROR TrySomethingWithFailure returns {0}", rNum));
                throw new NotImplementedException();
            }

            Console.WriteLine(string.Format("SUCCESS TrySomethingWithFailure returns {0}", rNum));
            return rNum;
        }
    }
}
