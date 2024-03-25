using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_01
{
    class MyAccessModifiers
    {
        private int birthYear;

        protected string personalInfo;

        private protected string IdNumber;
        public MyAccessModifiers(int birthYear, string idNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.IdNumber = idNumber;
            this.personalInfo = personalInfo;
        }
        public int Age
        {
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - birthYear;
            }
        }
        private byte averageMiddleAge = 50;

        internal string Name { get; set; }

        public string NickName { get; internal set; }

        protected internal void HasLivedHalfOfLife() { }

        public override bool Equals(object? obj)
        {
            return obj is MyAccessModifiers modifiers &&
                   personalInfo == modifiers.personalInfo &&
                   Age == modifiers.Age &&
                   Name == modifiers.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(personalInfo, Age, Name);
        }

        public static bool operator ==(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            if (ReferenceEquals(obj1, obj2))
            {
                return true;
            }
            if (obj1 is null || obj2 is null)
            {
                return false;
            }
            return obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo;
        }

        public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
