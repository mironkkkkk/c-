using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq.Expressions;

namespace WindowsFormsApp3
{
    enum ErrorType { 
        Message, 
        Warning,
        FatalError
    }
    internal class logger
    {
        DateTime date = DateTime.Now;
        string path = "log.txt";
        bool isActive = false;

        public void logging(string warning, ErrorType ErrorType)
        {
            if (!isActive)
            {
                Trace.Listeners.Add(new TextWriterTraceListener(path));
                Trace.AutoFlush = true;
                isActive = true;
            }
            Trace.WriteLine($"{date} {warning}.{ErrorType}"); 
        }
    }
}