using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    static class ExtensionMethodClass
    {
        public static void Print(this Points points) 
        {
            Console.WriteLine("From Extension method");
        }

    }
}
