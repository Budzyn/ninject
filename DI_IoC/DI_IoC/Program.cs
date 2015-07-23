using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Ninject;
using System.Threading;


namespace DI_IoC
{
    class Program
    {
        private static readonly CheckAccess chk = new CheckAccess();
        static void Main(string[] args)
        {
            iocInit();

            var factory = Ioc.Get<Factory>();
            var result = chk.Ping("http://www.dou.ua");

            // If 1 - write to console
            // If 2 - write to file
            // If 3 - both
            // If Esc - exit
            while (true)
            {
                var key = Console.ReadKey();
                if (ConsoleKey.Escape == key.Key)
                {
                    return;
                }
                var outputer = factory.Show(key.Key);
                outputer.WriteData(result);
            }
        }

        private static void iocInit()
        {
            Ioc.Init((kernel) =>
            {
                kernel.Bind<IData>().To<ConsoleOutput>().InThreadScope();
                kernel.Bind<ConsoleOutput>().ToSelf();
                kernel.Bind<ICheck>().To<CheckAccess>();
            });
        }
    }
}
