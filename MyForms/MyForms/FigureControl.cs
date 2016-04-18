using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figure;

namespace MyForms
{
    public partial class FigureControl : UserControl
    {
        //private Figure _figure;

        public FigureControl()
        {
            InitializeComponent();
        }

        private void FifureControl_Load(object sender, EventArgs e)
        {

        }

        public IFigure Figure
        {
            get
            {
                var figure = new Parallelogrem();
                figure.a = 5;
                figure.b = 6;
                figure.c = 7;
                //figure.Name = NameFigure.Text;
                //figure.X = NumericX.Value;
                //figure.Y = NumericY.Value;
                //figure.Z = NumericZ.Value;
                //figure.Volume = NameVolume.Text;
                return figure;
            }
            set 
            {
                //NameFigure.Text = Value.Name;
                //NumericX.Value = Value.X;
                //NumericY.Value = Value.Y;
                //NumericZ.Value = Value.Z;
                //NameVolume.Text = Value.Volume;
            }
        }
        
    }
}

    //public class Figure
    //{
    //    public string Name { get; set; }
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Z { get; set; }
    //    public string Volume { get; set; }
    //}

