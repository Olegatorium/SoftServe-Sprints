using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_05.Task_2._3
{
    class Method
    {
        public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (var item in phonesToNames)
            {
                if (item.Value == null)
                    phonesToNames[item.Key] = string.Empty;          
            }

            foreach (var item in phonesToNames) 
            {
                if (!result.ContainsKey(item.Value))
                    result.Add(item.Value, new List<string>());

                result[item.Value] = new List<string>();
            }

            foreach (var item in phonesToNames) 
                result[item.Value].Add(item.Key);

            return result;
        }



        //public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        //{
        //    if (phonesToNames == null)
        //        throw new ArgumentNullException(nameof(phonesToNames));

        //    var reversedNotebook = new Dictionary<string, List<string>>();

        //    foreach (var pair in phonesToNames)
        //    {
        //        var name = pair.Value ?? "";
        //        var phone = pair.Key;

        //        if (!reversedNotebook.ContainsKey(name))
        //        {
        //            reversedNotebook[name] = new List<string>();
        //        }

        //        reversedNotebook[name].Add(phone);
        //    }

        //    return reversedNotebook;
        //}
    }
}
