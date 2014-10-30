using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_jt222ic_geometriska_figurer
{
    public class Eclipse : Shape
    {





        //räkna ut Eclipse Area
        


        public override double Area
        {
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }
        // räkna ut Eclipse Omkrets
        public override double Perimeter
        {

            get { return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2)); }
        }

        public Eclipse(double length, double width)  :base(length, width)  // tom konstruktor för att ta emot värden 
        {
            //Tom kropp
        }
    }
}
