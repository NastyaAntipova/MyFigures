using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    /// <summary>
    /// Геометрическая фигура.
    /// </summary>
    public interface IFigure
    {
        int X { get; set; }
        int Y { get; set; }
        int Z { get; set; }

        double CalculateVolume();
        //int Count { get; set; }
    }
}
