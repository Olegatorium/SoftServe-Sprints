using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_03.Task1
{
    public interface ISwimmable
    {
        void Swim()
        {
            Console.WriteLine("I can swim!");
        }
    }

    public interface IFlyable
    {
        int MaxHeight { get; }

        void Fly()
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }
    }

    public interface IRunnable
    {
        int MaxSpeed { get; }

        void Run()
        {
            Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }
    }

    public interface IAnimal
    {
        int LifeDuration { get; }

        void Voice()
        {
            Console.WriteLine("No voice!");
        }

        void ShowInfo()
        {
            Console.WriteLine($"I am a {this.GetType().FullName} and I live approximately {LifeDuration} years.");
        }
    }

    public class Cat : IAnimal, IRunnable
    {
        public int LifeDuration { get; set; } = 15;
        public int MaxSpeed { get; set; } = 48;

        public void Voice()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Eagle : IAnimal, IFlyable
    {
        public int LifeDuration { get; set; } = 20;
        public int MaxHeight { get; set; } = 10000;

        public void Voice()
        {
            Console.WriteLine("No voice!");
        }
    }

    public class Shark : IAnimal, ISwimmable
    {
        public int LifeDuration { get; set; } = 25;

        public void Voice()
        {
            Console.WriteLine("No voice!");
        }
    }

}
