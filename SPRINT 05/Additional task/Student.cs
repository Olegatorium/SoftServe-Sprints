using System;
using System.Collections.Generic;
using System.Linq;

namespace SPRINT_05.Additional_task
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static HashSet<Student> GetCommonStudents(List<Student> list1, List<Student> list2)
        {
            var set1 = new HashSet<Student>(list1);
            var set2 = new HashSet<Student>(list2);
            set1.IntersectWith(set2);
            return set1;
        }

        public override string ToString()
        {
            return $"Student [Id={Id}, Name={Name}]";
        }


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
