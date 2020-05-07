using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAutofacExample.Abstract;
using WindowsFormsAutofacExample.Concrete;
using WindowsFormsAutofacExample.DependencyResolvers.Autofac;

namespace WindowsFormsAutofacExample
{
    public partial class Form1 : Form
    {
        private IDateWriter _dateWriter;

        public Form1()
        {
            InitializeComponent();

            _dateWriter = InstanceFactory.GetInstance<IDateWriter>();
            _dateWriter.WriteDate();
        }
    }
}