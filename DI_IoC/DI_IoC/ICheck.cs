using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DI_IoC
{
    interface ICheck
    {
        string Ping(string url);
    }
}
