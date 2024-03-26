using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_02.Task_4
{
    abstract class ChessFigure
    {
        public abstract void Move();
    }

    class Bishop : ChessFigure
    {
        public override void Move() 
        {
            Console.WriteLine("Moves by a diagonal!");
        }
    }

    class Rook : ChessFigure
    {
        public override void Move() 
        {
            Console.WriteLine("Moves straight!");
        }
    }
}
