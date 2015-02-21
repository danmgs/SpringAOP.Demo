using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringAOP.Demo.Business
{
    public interface IService
    {
        void DoSomething(DateTime date);

        int TrySomethingWithFailure();
    }
}
