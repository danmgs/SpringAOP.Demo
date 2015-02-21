using Spring.Context;
using Spring.Context.Support;
using SpringAOP.Demo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringAOP.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Get Spring Context
            IApplicationContext ctx = ContextRegistry.GetContext();
            IService service = (IService)ctx.GetObject("MyServiceWithAdvice");

            service.DoSomething(DateTime.Now);

            try
            {
                var rNum = service.TrySomethingWithFailure();
                Console.WriteLine(string.Format("TrySomethingWithFailure in success returns {0}", rNum));
            }
            catch (Exception e)
            {
                Console.WriteLine("TrySomethingWithFailure in error after n attempts : " + e.Message);
            }

            // Programmatic way to inject an advice ..
            //ProxyFactory factory = new ProxyFactory(new Service());
            //factory.AddAdvice(new ConsoleLoggingAroundAdvice());
            //IService service = (IService)factory.GetProxy();
            //service.DoSomething(DateTime.Now);

            Console.ReadKey();
        }
    }
}
