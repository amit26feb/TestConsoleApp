using System;

namespace OneInterfaceTowImpl
{
    public class AreaService : IService
    {
        public void DoSomething()
        {
            Console.WriteLine("I am Area");
        }
    }
}
