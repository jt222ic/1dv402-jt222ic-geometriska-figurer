using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_jt222ic_geometriska_figurer
{
    public class Rectangle : Shape
    {
        public override double Area   // vi skapar en override eftersom vi har skapat en Abstract metod vid Shape
        {                             // så kräver det att man överskuggar för att metoden ska kunna ininiteras.
            get { return Length * Width; }
        }
        public override double Perimeter  // samma princip som ovanstående text.
        {
            get { return 2 * Length + 2 * Width; } // returnera Perimeter till Shape.
        }                                                                         // hämtas värden från klassen,egenskaper
                                                                                  // base konstruktor använder
        public Rectangle(double length, double width) :base(length, width)    //tom konstruktor för att ta emot värden length och width. o skickas till Shapes
        {
            // tom kropp
        }
    }
}
