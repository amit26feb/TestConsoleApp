using System;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CallConcreteProductA();
        public abstract AbstractProductB CallConcreteProductB();
    }

    public class ConcreteFactoryA : AbstractFactory
    {
        public override AbstractProductA CallConcreteProductA()
        {
            return new ConcreteProductA();
        }

        public override AbstractProductB CallConcreteProductB()
        {
            return new ConcreteProductB();
        }
    }

    public class ConcreteFactoryB : AbstractFactory
    {
        public override AbstractProductA CallConcreteProductA()
        {
            return new ConcreteProductA();
        }

        public override AbstractProductB CallConcreteProductB()
        {
            return new ConcreteProductB();
        }
    }

    public abstract class AbstractProductA
    {
        public abstract void WriteProductA();
    }

    public class ConcreteProductA : AbstractProductA
    {
        public override void WriteProductA()
        {
            Console.WriteLine("Written Product A");
        }
    }

    public abstract class AbstractProductB
    {
        public abstract void WriteProductB();
    }

    public class ConcreteProductB : AbstractProductB
    {
        public override void WriteProductB()
        {
            Console.WriteLine("Written Product B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory a1 = new ConcreteFactoryA();
            AbstractProductA productA1 = a1.CallConcreteProductA();
            AbstractProductB productB1 = a1.CallConcreteProductB();

            productA1.WriteProductA();
            productB1.WriteProductB();

            AbstractFactory a2 = new ConcreteFactoryB();
            AbstractProductA productA2 = a2.CallConcreteProductA();
            AbstractProductB productB2 = a2.CallConcreteProductB();

            productA2.WriteProductA();
            productB2.WriteProductB();

        }
    }
}
