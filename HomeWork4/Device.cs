using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork4
{
    public class Device
    {
        [ColorInfo(ConsoleColor.Magenta)]
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        [ColorInfo(ConsoleColor.DarkRed)]
        public string Mode { get; set; }
    }
}
