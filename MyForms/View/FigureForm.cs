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
        private FigureControl FigureControl = new FigureControl();

        public FigureForm()
        {
            InitializeComponent();
            this.Controls.Add(FigureControl);
        }

        public IFigure Figure { get { return FigureControl.Figure; } }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

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
