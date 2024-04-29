using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Sprint_11.Task_2.ReflectMethod;

namespace Sprint_11.Task_5
{
    public class ReflectFullClass
    {
        public static void WriteAllInClass(Type type) 
        {

            var fields = type.GetFields();
            var properties = type.GetProperties();
            var methods = type.GetMethods();
            var interfaces = type.GetInterfaces();

            methods = methods.Where(x => x.DeclaringType == type).ToArray();


            Console.WriteLine($"Hello, {type.Name}!");
            Console.WriteLine($"There are {fields.Length} fields");
            for (int i = 0; i < fields.Length; i++)
            {
                Console.Write(fields[i].Name + ", ");
            }

            if (fields.Length > 0)
            {
                Console.WriteLine();
            }
            
            Console.WriteLine($"There are {properties.Length} properties");
            for (int i = 0; i < properties.Length; i++)
            {
                Console.Write(properties[i].Name + ", ");
            }

            if (properties.Length > 0)
            {
                Console.WriteLine();
            }

            Console.WriteLine($"There are {methods.Length} methods");
            for (int i = 0; i < methods.Length; i++)
            {
                Console.Write(methods[i].Name + ", ");
            }

            if (methods.Length > 0)
            {
                Console.WriteLine();
            }

            Console.WriteLine($"There are {interfaces.Length} interfaces");
            for (int i = 0; i < interfaces.Length; i++)
            {
                Console.Write(interfaces[i].Name + ", ");
            }

        }
    }
}
