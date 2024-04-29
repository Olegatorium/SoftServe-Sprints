using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sprint_11.Task_1
{
    public class ReflectFields
    {
        public static string Name;
        public static int MeasureX;
        public static int MeasureY;
        public static int MeasureZ;

        public static void OutputFields()
        {
            Type t = typeof(ReflectFields);

            var fieldNames = t.GetFields();

            foreach (var item in fieldNames)
            {
                string fieldType = "";

                for (int i = 0; i < item.FieldType.Name.Length; i++)
                {
                    if (char.IsDigit(item.FieldType.Name[i]))
                        break;

                    fieldType += item.FieldType.Name[i];
                }

                object value = item.GetValue(null);

                Console.WriteLine($"{item.Name} ({fieldType.ToLower()}) = {value}");

            }
        }
    }
}

//Поэтому передача null в GetValue() говорит методу получить значение поля из самого класса, а не из конкретного экземпляра.

//Если бы мы работали с нестатическими полями и хотели получить их значения из конкретного объекта класса ReflectFields, мы бы передали этот объект вместо null.



    //вот пример:

//    using System;

//public class ReflectFields
//    {
//        public string Name;
//        public int MeasureX;
//        public int MeasureY;
//        public int MeasureZ;

//        public static void OutputFields(ReflectFields obj)
//        {
//            Type t = typeof(ReflectFields);
//            var fields = t.GetFields();

//            foreach (var field in fields)
//            {
//                string fieldType = "";

//                for (int i = 0; i < field.FieldType.Name.Length; i++)
//                {
//                    if (char.IsDigit(field.FieldType.Name[i]))
//                        break;

//                    fieldType += field.FieldType.Name[i];
//                }

//                object value = field.GetValue(obj); // Получаем значение поля из объекта

//                Console.WriteLine($"{field.Name} ({fieldType.ToLower()}) = {value}");
//            }
//        }

