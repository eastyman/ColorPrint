using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork4
{
    public class Worker
    {
        [ColorInfo(ConsoleColor.DarkGreen)]
        public string Name { get; set; }
        [ColorInfo(ConsoleColor.DarkYellow)]
        public string Company { get; set; }
    }
}
