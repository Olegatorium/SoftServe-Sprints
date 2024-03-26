using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SPRINT_02.Task1
{
    class Employee
    {
        internal string name;
        private DateTime hiringDate;

        public Employee(string name, DateTime hiringDate)
        {
            this.name = name;
            this.hiringDate = hiringDate;
        }

        public int Experience() 
        {
            int result = DateTime.Now.Year - hiringDate.Year;

            if (DateTime.Now.Month - hiringDate.Month < 0)
                result--;

            return result;
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"{name} has {Experience} years of experience");
        }
    }

    class Developer : Employee 
    {
        private string programmingLanguage;

        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
        {
            this.programmingLanguage = programmingLanguage;
        }
        public new void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"{name} is {programmingLanguage} programmer");
        }
    }

    class Tester: Employee 
    {
        private bool isAuthomation;

        public Tester(string name, DateTime hiringDate, bool isAuthomation) : base(name, hiringDate)
        {
            this.isAuthomation = isAuthomation;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();

            if (isAuthomation)
                Console.WriteLine($"{name} is authomated tester and has {Experience} year(s) of experience");
            else
                Console.WriteLine($"{name} is manual tester and has {Experience} year(s) of experience");
        }
    }
}
