using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    class DriverTwo : IDriver
    {
        public void Print(string message)
        {
            Console.WriteLine($"Driver nr two say: {message}");
        }
    }
}
