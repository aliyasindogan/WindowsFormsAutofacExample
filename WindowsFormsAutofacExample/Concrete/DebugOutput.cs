using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAutofacExample.Abstract;

namespace WindowsFormsAutofacExample.Concrete
{
    internal class DebugOutput : IOutput
    {
        public void Write(string content)
        {
            Debug.WriteLine(content);
        }
    }
}