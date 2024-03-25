using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SPRINT_01.Task_5
{
    public class Person
    {
        private protected string childIDNumber;

        protected int yearOfBirth;

        protected string healthInfo;

        protected string name;

        public Person(int yearOfBirth, string healthInfo, string childIDNumber)
        {
            this.yearOfBirth = yearOfBirth;
            this.healthInfo = healthInfo;
            this.childIDNumber = childIDNumber;
        }

        public string GetHealthStatus() 
        {
            return name + ": " + yearOfBirth + ". " + healthInfo;
        }
    }

    public class Child : Person
    {
        private new string childIDNumber;

        public Child(int yearOfBirth, string name, string healthInfo, string childIDNumber) : base(yearOfBirth, healthInfo, childIDNumber)
        {
            this.yearOfBirth = yearOfBirth;
            this.name = name;
            this.healthInfo = healthInfo;
            this.childIDNumber = childIDNumber;
        }

        public override string? ToString()
        {
            return $"{name} {healthInfo}";
        }
    }

    public class Adult : Person
    {
        private string passportNumber;

        public Adult(int yearOfBirth, string name, string healthInfo, string passportNumber) : base(yearOfBirth, healthInfo, "")
        {
            this.yearOfBirth = yearOfBirth;
            this.name = name;
            this.healthInfo = healthInfo;
            this.passportNumber = passportNumber;      
        }

        public override string? ToString()
        {
            return $"{name} {passportNumber}";
        }
    }
}
