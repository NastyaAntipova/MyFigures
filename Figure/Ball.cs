using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Ball : IFigure
   {

        public string Name
        {
            get
            {
                return "Шар";
            }
        }

       public int X { get; set; }
       public int Y { get; set; }
       public int Z { get; set; }

       /// <summary>
       /// Радиус шара
       /// </summary>
       private int _radius;

       public int radius
       {
           get
           {
               return _radius;
           }
           set
           {
               if (value < 0)
               throw new ArgumentException();   
               _radius = value;
           }
       }
       public double CalculateVolume()
       {
           radius = _radius;
           return (4 / 3) * Math.PI * (Math.Pow(radius, 3));
       }

       public Ball(int radius)
       {
           radius = _radius;
       }

       public Ball()
       {

       }

      
   }

}
