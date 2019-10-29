using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolopolyGame
{  //2.3Extend use of Interface classes in the project    
    public class ColoredMessage : IColoredMessage
    {

        public string ToColorMessage()
        {
            Console.WriteLine("hello world!");
            return "Lijing";
        }
    }
}
