using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device();
            device.Name = "TVSet";
            device.Mode = "Working";
            device.Manufacturer = "Sony";
            Console.WriteLine("\tDevice:");
            Colorizer.ColorPrint(device);
            Worker worker = new Worker();
            worker.Name = "Vasiliy Petrovich";
            worker.Company = "HTZ";
            worker.Age = 45;
            Console.WriteLine("\tWorker:");
            Colorizer.ColorPrint(worker);
        }
    }
}
