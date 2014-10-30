using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_jt222ic_geometriska_figurer
{
    public abstract class Shape     //// abstract klass kan inte initieras utan måste ärvas av andra sub klasser
    {                               // Rectangle och Eclipse har override så de måste finnas för att kunna köras
                                     // krävs överskuggning
                                           //abstract ska inte kunna kalla på något.Inte köras sj
        //fält //
        private double _length;
        private double _width;



        public abstract double Area  // hämtas värden från Rectangle och Eclipse
        {                             // Abstract krävs överskuggning
            get;                          // kan inte räkna ut alla olika figurer därför är det abstract
        }
         public abstract double Perimeter  // hämtas värden från Rectangle och Eclipse
        {
            get;                             /// krävs överskuggning
        }
        public double Length          
        {                           //längd
            get{return _length;}   // returnera värden till fältet, annars om man vill sätta värden
                                   // så används set för att köra vidare

            set{

                if(value<=0)    // om värdet är lika eller mindre 0 kastas det ett undertag
                {throw new ArgumentException();}  // bestämma regler för värdet
                _length =value;   // koden lyckas sätts ingen undertag sätter _length till sitt nya värde
            }
        }
       
        public double Width    //bredd
        {
            get{ return _width;}


            set{

                if (value <= 0)                 /// samma princip
                {
                    throw new ArgumentException();}
                    _width = value;
                }
         }

        // konstruktor
             protected Shape(double length, double width)
            {

              Length = length;                //värden skickas till egenskaper, 
             Width=width;
            }                                    // överskugga basklassens ToString och skriv figurens former.
     public override string ToString()               /// varnighets detaljer override. om inte override finss. 
                                                     /// osynligt. SHAPE ÄRVER FRÅN DEN OSYNLIGA KLASSEN OBJECT
                                                     /// I DENNA KLASSEN SOM HAR EN METOD SOM HETER TO STRING
                                                     /// 
     {                                        /// 
            return String.Format("Längd   : {0}\nBredd   : {1}\nOmkrets : {2}\nArea    : {3}\n===========================",
                Length, Width, Perimeter, Area);
             }
    }

    }


    
   


      


