using System;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionTest
{

    public interface IDriver
    {
        public void Print(string message);
    }

    public class Helper
    {
        private readonly IDriver driver;

        public Helper( IDriver driver)
        {
            this.driver = driver;
        }

        public void SaySomething(string msg)
        {
            driver.Print(msg);
        }
    }

    public class Test
    {
        private readonly IDriver driver;

        public Test(IDriver driver)
        {
            this.driver = driver;
        }

        public void SaySomething(string msg)
        {
            driver.Print(msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case One");

            var _helperForDriverOne = new Helper( new DriverOne());
            var _helperForDriverTwo = new Helper(new DriverTwo());

            _helperForDriverOne.SaySomething("case 1");
            _helperForDriverTwo.SaySomething("case 2");



            Console.WriteLine("Case Two");

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDriver, DriverTwo>()
                .BuildServiceProvider(); 


            var _helperForAllDrivers = new Helper(serviceProvider.GetService<IDriver>());
            var _testForAllDrivers = new Test(serviceProvider.GetService<IDriver>());

            _helperForAllDrivers.SaySomething("case 2 - helper");
            _testForAllDrivers.SaySomething("case 2 - test");



        }
    }
}
