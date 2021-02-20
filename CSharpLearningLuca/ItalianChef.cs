using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    class ItalianChef : Chef
    {

        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta.");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm.");
        }

    }
}
