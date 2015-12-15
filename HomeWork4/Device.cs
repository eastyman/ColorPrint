using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork4
{
    public class Device
    {
        //[ColorInfo()]
        public string Name { get; set; }
        [ColorInfo(ConsoleColor.DarkRed)]
        public string Mode { get; set; }
    }
}
