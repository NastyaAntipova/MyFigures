using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{   /// <summary>
    /// Параллелепипед
    /// </summary>
    public class Parallelepiped: IFigure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private int _a;

        private int _b;

        private int _c;

        public int a
        {
            get
            {
                return _a;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _a = value;
            }
        }
        public int b
        {
            get
            {
                return _b;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _b = value;
            }
        }
        public int c
        {
            get
            {
                return _c;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _c = value;
            }
        }

        public double CalculateVolume()
        {
            return a*b*c;
        }
    }
}
