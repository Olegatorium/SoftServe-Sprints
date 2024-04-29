using Sprint_11.Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_11.Task_2
{
    public class ReflectMethod
    {
        public static class Methods
        {
            public static void Hello(string name)
            {
                Console.WriteLine($"Hello:parameter={name}");
            }

            public static void Welcome(string name)
            {
                Console.WriteLine($"Welcome:parameter={name}");
            }

            public static void Bye(string name)
            {
                Console.WriteLine($"Bye:parameter={name}");
            }
        }

        public static void InvokeMethod(string[]parameter) 
        {
            Type t = typeof(Methods);

            var methods = t.GetMethods();

            methods = methods.Where(x => x.DeclaringType == typeof(Methods)).ToArray();
            // var methods = t.GetMethods(BindingFlags.DeclaredOnly);
            // не працює, можливо це звязано і за того що клас вложений
            // якщо замынити тип на клас ReflectMethod, то воно тоже не працюэ, а тут напевно, томущо метод не бачить сам себе
            // треба протестити це в майбутньому коді

            foreach (var method in methods)
            {
                foreach (var array in parameter)
                {
                    method.Invoke(null, new string[] { array });
                }
            }
        }
    }
}
