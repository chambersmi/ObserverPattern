using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal interface IDisplayElement
    {
        //Call when the display element needs to be displayed
        public void Display();
    }
}
