using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_02.Task_3
{
    class Science
    {
        public virtual void Awards()
        {
            Console.WriteLine("We can obtain The Nobel Prize");
        }
    }

    class Mathematics : Science
    {
        public override void Awards()
        {
            Console.WriteLine("We don't need any awards, but we still can obtain The Abel Prize that nobody else can!");
        }
    }

    class Physics : Science
    {

    }

}
