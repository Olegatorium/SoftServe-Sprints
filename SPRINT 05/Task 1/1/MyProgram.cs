using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_05.Task_1._1
{
    class MyProgram
    {
        public static void Position(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 5)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }

        public static void Remove(List<int> numbers)
        {
            numbers = numbers.Where(x => x <= 20).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void Insert(List<int> numbers)
        {
            numbers.Insert(2, -5);
            numbers.Insert(5, -6);
            numbers.Insert(7, -7);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void Sort(List<int> numbers)
        {
            numbers = numbers.OrderBy(x => x).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

    }
}
