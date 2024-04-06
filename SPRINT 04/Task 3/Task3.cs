using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_03.Task_3
{
    enum ColourEnum 
    {
        Red, Green, Blue
    }

    interface IColoured
    {
        public ColourEnum Colour => ColourEnum.Red;
    }

    interface IDocument
    {
        static string defaultText = "Lorem ipsum";

        public int Pages { get; set; }

        public string Name { get; set; }

        public void AddPages(int number) 
        {
            Pages += number;
        }
        public void Rename(string newName) 
        {
           Name = newName;
        }
    }

    class ColouredDocument : IColoured, IDocument
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public ColourEnum Colour { get; set; }

        public void Rename(string newName)
        {
            Name = newName;
        }

        public ColouredDocument(ColourEnum color)
        {
            Colour = color;
        }

        public ColouredDocument()
        {
        }
    }

    public class Example
    {
        public static void Do()
        {
          ColouredDocument doc1 = new ColouredDocument();

            doc1.Name = "Document1";

            Console.WriteLine(doc1.Name);

            doc1.Rename("Document2");

            Console.WriteLine(doc1.Name);
        }
    }
}
