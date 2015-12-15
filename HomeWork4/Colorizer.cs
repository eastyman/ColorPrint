using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HomeWork4
{
    public class Colorizer
    {
        public static void ColorPrint(object obj)
        {
            Type type = obj.GetType();
            ConsoleColor color;
            const ConsoleColor stdColor = ConsoleColor.Gray; //стандарный цвет для консольки
            System.Attribute colorAttr;
            foreach (PropertyInfo property in type.GetProperties())
            {
                // Получим значение атрибута
                colorAttr = property.GetCustomAttribute(typeof(ColorInfoAttribute));
                //если не пусто - вытащим значение свойства Color из аттрибута
                if (colorAttr != null)
                {
                    color = ((ColorInfoAttribute)colorAttr).Color;
                    //если в результате получили черный - сменим его на стандартный
                    if (color == ConsoleColor.Black)
                    {
                        color = stdColor;
                    }
                }
                //если пусто - запишем стандартный цвет
                else
                {
                    color = stdColor;
                }

                Console.ForegroundColor = color;
                Console.WriteLine(property.Name + ": " + property.GetValue(obj));
                Console.ForegroundColor = stdColor;
            }
        }
    }
}
