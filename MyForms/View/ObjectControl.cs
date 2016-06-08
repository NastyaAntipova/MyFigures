using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Figure;


namespace Model_View
{
    public partial class ObjectControl : UserControl
    {


        public IFigure Figure { get; set; }

        public ObjectControl()
        {
            InitializeComponent();
        }

        private void ObjectControl_Load(object sender, EventArgs e)
        {

        }

        public IFigure figure
        {
            get
            {
                Figure.IFigure figureModel = null;

                if (Spere_RadioButton.Checked)
                {
                    figureModel = ballControll1.Value;

                    figureModel.X = Convert.ToInt32(XBox.Text);
                    figureModel.Y = Convert.ToInt32(YBox.Text);
                    figureModel.Z = Convert.ToInt32(ZBox.Text);

                }

                else if (Piramid_RadioButton.Checked) 
                {
                    figureModel = piramidControll1.Value;

                    figureModel.X = Convert.ToInt32(XBox.Text);
                    figureModel.Y = Convert.ToInt32(YBox.Text);
                    figureModel.Z = Convert.ToInt32(ZBox.Text);

                }

                else if (Parallelepiped_RadioButton.Checked)
                {
                    figureModel = parallelepipedContrloll1.Value;

                    figureModel.X = Convert.ToInt32(XBox.Text);
                    figureModel.Y = Convert.ToInt32(YBox.Text);
                    figureModel.Z = Convert.ToInt32(ZBox.Text);
                }

                return figureModel;

            }

            set 
            {
                if (value is Ball) 
                {
                    parallelepipedContrloll1.Visible = false;
                    piramidControll1.Visible = false;

                    ballControll1.Visible = true;
                    ballControll1.Value = (Ball)value;
                }

                else if (value is Parallelepiped)
                {
                    piramidControll1.Visible = false;
                    ballControll1.Visible = true;

                    parallelepipedContrloll1.Visible = true;
                    parallelepipedContrloll1.Value = (Parallelepiped)value;

                }


                else if (value is Pyramid)
                {
                    parallelepipedContrloll1.Visible = false;
                    ballControll1.Visible = false;

                    piramidControll1.Visible = true;
                    piramidControll1.Value = (Pyramid)value;
                }

            }
        }
        /// <summary>
        /// Если нажата кнопка "Шар"
        /// </summary>
        private void Spere_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            ballControll1.Visible = true;
            parallelepipedContrloll1.Visible = false;
            piramidControll1.Visible = false;
        }


        /// <summary>
        /// Если нажата кнопка "Параллелепипед"
        /// </summary>
        private void Parallelepiped_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            piramidControll1.Visible = false;
            ballControll1.Visible = false;
            parallelepipedContrloll1.Visible = true;
        }

        /// <summary>
        /// Если нажата кнопка "Пирамида"
        /// </summary>
        private void Piramid_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            ballControll1.Visible = false;
            parallelepipedContrloll1.Visible = false;
            piramidControll1.Visible = true;
        }

        private void parallelepipedContrloll1_Load(object sender, EventArgs e)
        {

        }

    }
}
