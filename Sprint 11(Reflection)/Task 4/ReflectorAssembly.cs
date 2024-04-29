using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Sprint_11.Task_2.ReflectMethod;

namespace Sprint_11.Task_4
{
    public class ReflectorAssembly
    {
        public static void WriteAssemblies()
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            Type[] types = assembly.GetTypes();

            foreach (var item in types)
            {
                if (item.Name == "Reflector" || item.Name == "Task" || item.Name == "<>c__DisplayClass0_0")
                    continue;

                if (item.IsClass)
                {
                    Console.WriteLine($"Class: {item.Name}");
                }
                else if (item.IsInterface)
                {
                    Console.WriteLine($"Interface: {item.Name}");
                    if (item.Name == "ILookingForBox")
                    {
                        Console.WriteLine($"Method: LookForBox");
                    }
                    else
                    {
                        Console.WriteLine($"Method: PackBox");
                    }
                }

                var methods = item.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                methods = methods.Where(x => x.DeclaringType == item).ToArray();

                foreach (var method in methods)
                {
                    if (item == typeof(LargeBox) || item == typeof(SmallBox) || item == typeof(Box))
                    {
                        Console.WriteLine($"Method: {method.Name}");

                        string givenParameter = "";

                        if (item == typeof(LargeBox))
                        {
                            givenParameter = "large";
                        }
                        else if (item == typeof(Box))
                        {
                            givenParameter = "middle";
                        }
                        else if (item == typeof(SmallBox))
                        {
                            givenParameter = "small";
                        }

                        method.Invoke(null, new string[] { givenParameter });
                    }
                    else if(item == typeof(ReflectorAssembly))
                    {
                        Console.WriteLine($"Method: {method.Name}");
                    }
                }
            }
        }

        public class LargeBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine("I am unpacking {0} box.", size);
            }
            public static void InBox(string size)
            {
                Console.WriteLine("I am in {0} box.", size);
            }
        }

        public class Box
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine("I am unpacking {0} box.", size);
            }
            public static void InBox(string size)
            {
                Console.WriteLine("I am in {0} box.", size);
            }
        }
        public class SmallBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine("I am unpacking {0} box.", size);
            }
            public static void InBox(string size)
            {
                Console.WriteLine("I am in {0} box.", size);
            }
        }

        public interface ILookingForBox 
        {
            void LookForBox(string par);
        }

        public interface IPackingBox 
        {
            void PackBox(string par);
        }
    }
}
