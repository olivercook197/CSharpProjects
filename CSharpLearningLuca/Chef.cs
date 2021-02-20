using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    class Chef
    {

        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad.");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs.");
        }

    }
}
