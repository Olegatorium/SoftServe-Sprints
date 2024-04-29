using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_11.Task_3
{
    public class ReflectProperties
    {
        public class TestProperties 
        {
            public string FirstName { get; set; }
            internal string LastName { get; set; }
            protected int Age { get; set; }
            public string PhoneNumber { private get; set; }
        }

        public static void WriteProperties()
        {
            Type t = typeof(TestProperties);

            PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            
            foreach (var property in properties) 
            {
                Console.WriteLine($"Property Name: {property.Name}");
                Console.WriteLine($"Property type: {property.PropertyType.FullName}");
                Console.WriteLine($"Read-Write:    {CanReadWrite(property)}");
                Console.WriteLine($"Accessibility: {GetAccessibility(property)}");

                Console.WriteLine();
            }
        }

        static bool CanReadWrite(PropertyInfo property) 
        {
           if ( property.CanWrite && property.CanRead)
                return true;

           return false;
        }

        static string GetAccessibility(PropertyInfo property)
        {
            string accessibility;

            if (property.GetGetMethod(true).IsPublic)
                accessibility = "Public";
            else if (property.GetGetMethod(true).IsPrivate)
                accessibility = "Private";
            else if (property.GetGetMethod(true).IsFamily)
                accessibility = "Protected";
            else if (property.GetGetMethod(true).IsAssembly)
                accessibility = "Internal";
            else if (property.GetGetMethod(true).IsFamilyOrAssembly)
                accessibility = "Protected internal";
            else
                accessibility = "Unknown";

            return accessibility;
        }
    }
}
