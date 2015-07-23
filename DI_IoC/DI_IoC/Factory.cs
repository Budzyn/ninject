using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_IoC
{
    class Factory
    {
        public IData Show(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    return new ConsoleOutput();
                case ConsoleKey.D2:
                    return new FileOutput();
                case ConsoleKey.D3:
                    return new MixedOutput();
                default:
                    return new ConsoleOutput();
            }
        }
    }
}
