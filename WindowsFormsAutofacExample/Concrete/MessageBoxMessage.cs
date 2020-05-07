using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAutofacExample.Abstract;

namespace WindowsFormsAutofacExample.Concrete
{
    internal class MessageBoxMessage : IOutput
    {
        public void Write(string content)
        {
            MessageBox.Show(content);
        }
    }
}