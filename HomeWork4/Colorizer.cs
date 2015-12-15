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
            Type t = obj.GetType();            
            ConsoleColor color;
            const ConsoleColor stdColor = ConsoleColor.Gray; //стандарный цвет для консольки
            foreach (PropertyInfo p in t.GetProperties())
            {
                // Пытаемся получить значение атрибута
                try
                {
                    color = ((ColorInfoAttribute)p.GetCustomAttribute(typeof(ColorInfoAttribute))).Color;
                    //Если атрибут назначен, но цвет не указан, по-умолчанию ставится черный
                    //меняем его на стандартный серый чтобы видеть текст
                    if (color == ConsoleColor.Black)
                    {
                        color = stdColor;
                    }

                }
                // если атрибут не назначен - устанавливаем стандартный серый
                catch (Exception) 
                {
                    color = stdColor;                    
                }
                Console.ForegroundColor = color;
                Console.WriteLine(p.Name+": "+p.GetValue(obj));
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
