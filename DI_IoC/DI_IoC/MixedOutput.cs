using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI_IoC
{
    class MixedOutput:IData
    {
        private readonly ConsoleOutput _consoleOutput = new ConsoleOutput();
        private readonly FileOutput _fileOutput = new FileOutput();

        public void WriteData(string data)
        {
            _consoleOutput.WriteData(data);
            _fileOutput.WriteData(data);
        }
    }
}
