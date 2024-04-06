using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_03.Task_2
{
    interface IAnimal
    {
        public string Name { get; set; }

        public void Voice();

        public void Feed();
    }

    class Cat : IAnimal
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Feed()
        {
            Console.WriteLine("I eat mice");
        }

        public void Voice()
        {
            Console.WriteLine("Mew");
        }
    }

    class Dog : IAnimal
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Feed()
        {
            Console.WriteLine("I eat meat");
        }

        public void Voice()
        {
            Console.WriteLine("Woof");
        }
    }
}
