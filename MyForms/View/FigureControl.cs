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

namespace View
{
    public partial class FigureControl : UserControl
    {
        private IFigure _figure;

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
                Figure.IFigure figureModel = null;

                if (BallButton.Checked)
                {
                    var ball = new Ball();
                    ball.radius = Convert.ToInt32(BallBox.Text);
                    ball.X = Convert.ToInt32(XBox.Text);
                    ball.Y = Convert.ToInt32(YBox.Text);
                    ball.Z = Convert.ToInt32(ZBox.Text);
                    figureModel = ball;
                }
                else if (PyrButton.Checked)
                {
                    var pyramid = new Pyramid();
                    pyramid.h = Convert.ToInt32(PyrBox.Text);
                    pyramid.S = Convert.ToInt32(PyrBox2.Text);
                    pyramid.X = Convert.ToInt32(XBox.Text);
                    pyramid.Y = Convert.ToInt32(YBox.Text);
                    pyramid.Z = Convert.ToInt32(ZBox.Text);
                    figureModel = pyramid;
                }
                else if (ParalButton.Checked)
                {
                    var parallelepiped = new Parallelepiped();
                    parallelepiped.a = Convert.ToInt32(ABox.Text);
                    parallelepiped.b = Convert.ToInt32(BBox.Text);
                    parallelepiped.c = Convert.ToInt32(CBox.Text);
                    parallelepiped.X = Convert.ToInt32(XBox.Text);
                    parallelepiped.Y = Convert.ToInt32(YBox.Text);
                    parallelepiped.Z = Convert.ToInt32(ZBox.Text);
                    figureModel = parallelepiped;
                }

                return figureModel;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BallButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BallButton.Checked)
            {
                BallBox.Visible = true;
                XBox.Visible = true;
                YBox.Visible = true;
                ZBox.Visible = true;
                PyrBox.Visible = false;
                PyrBox2.Visible = false;
                ABox.Visible = false;
                BBox.Visible = false;
                CBox.Visible = false;
                
            }
        }

        private void PyrButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PyrButton.Checked)
            {
                BallBox.Visible = false;
                PyrBox.Visible = true;
                PyrBox2.Visible = true;
                ABox.Visible = false;
                BBox.Visible = false;
                CBox.Visible = false;
                XBox.Visible = true;
                YBox.Visible = true;
                ZBox.Visible = true;
            }
        }

        private void ParalButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ParalButton.Checked)
            {
                BallBox.Visible = false;
                PyrBox.Visible = false;
                PyrBox2.Visible = false;
                ABox.Visible = true;
                BBox.Visible = true;
                CBox.Visible = true;
                XBox.Visible = true;
                YBox.Visible = true;
                ZBox.Visible = true;
            }
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            
        //    View.IFigure figureModel = null;
        //    switch(_figure)
        //    {
        //        case 0 :
        //            figureModel = new Ball(Convert.ToInt32(BallBox.Text));
        //            break;
        //        case 1:
        //            figureModel = new Parallelogrem(Convert.ToInt32(ABox.Text), Convert.ToInt32(BBox.Text), Convert.ToInt32(CBox.Text));
        //            break;
        //        case 2:
        //            figureModel = new Pyramid(Convert.ToInt32(PyrBox.Text), Convert.ToInt32(PyrBox2.Text));
        //            break;
        //    }
        //    Figure = figureModel;
        }

        private void PyrBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}

  
