using System.Collections.Generic;

namespace SPRINT_05.Task_2
{
    class MyUtils
    {
        public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> dictionary)
        {
            if (list.Count == 0 && dictionary.Count == 0)
                return true;

            foreach (var item in list)
            {
                if (!dictionary.ContainsValue(item))
                    return false;
            }

            foreach (var item in dictionary)
            {
                if (!list.Contains(item.Value))
                    return false;
            }

            return true;
        }
    }
}
