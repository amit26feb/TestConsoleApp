using System;

namespace OneInterfaceTowImpl
{
    public class WeatherService : IService
    {
        public WeatherService()
        { }
        public void DoSomething()
        {
            Console.WriteLine("i am weather");
        }
    }
}
