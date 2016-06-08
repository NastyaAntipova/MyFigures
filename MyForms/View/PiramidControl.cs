using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Figure;

namespace Model_View
{
    public partial class PiramidControll : UserControl
    {
        public PiramidControll()
        {
            InitializeComponent();
        }


        public Pyramid Value
        {
            get { return new Pyramid() { S = Convert.ToInt32(S_TextBox.Text), h = Convert.ToInt32(H_TextBox.Text)}; }
            set
            {
                H_TextBox.Text = value.h.ToString();
                S_TextBox.Text = value.S.ToString();

            }
        }


        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>

        private void S_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }


        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void H_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
