using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork4
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColorInfoAttribute:System.Attribute
    {
        public ConsoleColor Color { get; set; }
        public ColorInfoAttribute()
        { }
        public ColorInfoAttribute(ConsoleColor color)
        {
            Color = color;
        }
        public override string ToString()
        {
            return Color.ToString();
        }
    }
}
