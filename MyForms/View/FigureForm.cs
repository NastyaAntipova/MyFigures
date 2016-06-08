using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figure;

namespace View
{
    public partial class FigureForm : Form
    {

        public IFigure Figures { get; set; }

        public FigureForm()
        {
            InitializeComponent();
     
        }

        // Кнопка открыть
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Figures = objectControl1.figure;
                DialogResult = DialogResult.OK;
                Close();
            }

            catch (Exception)
            {
                {
                    MessageBox.Show("Введены не все значения!");
                }
            }

        }
        // Кнопка закрыть
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FigureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
