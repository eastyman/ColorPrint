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
            object o = Activator.CreateInstance(t);
            o = obj;
            ConsoleColor color;
            foreach (PropertyInfo p in t.GetProperties())
            {
                // Пытаемся получить значение атрибута
                try
                {
                    color = ((ColorInfoAttribute)p.GetCustomAttribute(typeof(ColorInfoAttribute))).Color;
                    //Если атрибут назначен, но цвет не указан, устанавливаем белый цвет
                    if (color == ConsoleColor.Black)
                    {
                        color = ConsoleColor.White;
                    }

                }
                // если атрибут не назначен - устанавливаем белый цвет
                catch (Exception) 
                {                    
                    color = ConsoleColor.White;                    
                }
                Console.ForegroundColor = color;
                Console.WriteLine(p.GetValue(o));
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
