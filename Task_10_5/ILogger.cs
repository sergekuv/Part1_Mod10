using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_5
{
    interface ILogger
    {
        void WriteInfo(string message);
        void WriteError(string message);
    }
}
