using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_02.Task_2
{
    abstract class Car
    {
        internal string mark;

        internal int prodYear;

        protected Car(string mark, int prodYear)
        {
            this.mark = mark;
            this.prodYear = prodYear;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Mark : {mark},\nProducted in {prodYear}");
        }
    }

    class SportCar : Car 
    {
        private int maxSpeed;

        public SportCar(string mark, int prodYear, int maxSpeed) : base(mark, prodYear)
        {
            this.maxSpeed = maxSpeed;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"Maximum speed is {maxSpeed}");
        }
    }

    class Lory : Car 
    {
        private double loadCapacity;

        public Lory(string mark, int prodYear, double loadCapacity) : base(mark, prodYear)
        {
            this.loadCapacity = loadCapacity;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"The load capacity is {loadCapacity}");
        }
    }
}
