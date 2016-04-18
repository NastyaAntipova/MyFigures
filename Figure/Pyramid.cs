using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{   
    /// <summary>
    /// Объем пирамиды
    /// </summary>
    public class Pyramid: IFigure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private int _h; // Высота пирамиды 
        
        private int _S; // Площадь основания

        public int h 
        {
            get
            {
                return _h;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _h = value;
            }
        }
        
        public int S
        {
            get
            {
                return _S;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _S = value;
            }
        }
        public double CalculateVolume()
        {
            return (1 / 3) * S * h;
        }
    }    
}
