using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DI_IoC
{
    class FileOutput:IData
    {
        public void WriteData(string data)
        {
            string curFile = @"c:\temp\test.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            Console.ReadKey();
        }
    }
}
