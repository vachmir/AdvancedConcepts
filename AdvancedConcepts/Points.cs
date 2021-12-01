using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    class Points
    {
        public int A { get; set; }
        public int B { get; set; }

        public Points(int a)
        {
            //B = a;
        }
        public Points(int a, int b)
        {
            A = a;
            B = b;
        }
        public override string ToString() => $"[{this.A}, {this.B}]";        
        public static Points operator -(Points point1, Points point2) => new Points(point1.A- point2.A, point1.B - point2.B);



    }
}
