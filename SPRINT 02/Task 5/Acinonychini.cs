using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SPRINT_02.Task_5
{
    public class Acinonychini
    {
        public string FamilyName { get; set; }
        public string Habitat { get; set; }
        public bool IsEndangered { get; set; }

        public Acinonychini(string familyName, string habitat, bool isEndangered)
        {
            FamilyName = familyName;
            Habitat = habitat;
            IsEndangered = isEndangered;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Family: {FamilyName}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Endangered: {(IsEndangered ? "Yes" : "No")}");
        }
    }

    public sealed class Acinonyx : Acinonychini
    {
        public string Species { get; set; }
        public int Speed { get; set; }

        public Acinonyx(string familyName, string habitat, bool isEndangered, string species, int speed)
            : base(familyName, habitat, isEndangered)
        {
            Species = species;
            Speed = speed;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Speed: {Speed} mph");
        }
    }

    public class Puma : Acinonychini
    {
        public string Subspecies { get; set; }
        public bool HasCamouflage { get; set; }

        public Puma(string familyName, string habitat, bool isEndangered, string subspecies, bool hasCamouflage)
            : base(familyName, habitat, isEndangered)
        {
            Subspecies = subspecies;
            HasCamouflage = hasCamouflage;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Subspecies: {Subspecies}");
            Console.WriteLine($"Camouflage: {(HasCamouflage ? "Yes" : "No")}");
        }
    }
}
