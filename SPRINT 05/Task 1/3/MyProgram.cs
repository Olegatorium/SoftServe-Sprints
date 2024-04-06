using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_05.Task_1._3
{
    public class MyProgram
    {
        public static void SearchKeys(Dictionary<string, string> persons) 
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.Key);
            }
        }

        public static void SearchValues(Dictionary<string, string> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.Value);
            }
        }

        public static void SearchAdmin(Dictionary<string, string> persons) 
        {
            foreach (var person in persons)
            {
                if (person.Value == "Admin")
                {
                    Console.WriteLine(person.Key + " " + person.Value);
                }
            }
        }
    }
}
