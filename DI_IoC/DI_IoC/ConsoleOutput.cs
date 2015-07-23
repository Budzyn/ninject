using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DI_IoC
{
    class ConsoleOutput:IData
    {
        public void WriteData(string data)
        {
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
