using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq.Expressions;

namespace WindowsFormsApp3
{
    internal class logger
    {
        string path = "log.txt";
        bool isActive = false;

        public void logging(string warning) {
            if (!isActive)
            {
                Trace.Listeners.Add(new TextWriterTraceListener(path));
                Trace.AutoFlush = true;
                isActive = true;
            }
            Trace.WriteLine(warning);
        }
    }
}
