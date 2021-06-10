using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{


    class DriverOne : IDriver
    {
        public void Print(string message)
        {
            Console.WriteLine($"Driver nr one say: {message}");
        }
    }
}
