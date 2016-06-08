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
    public partial class ParallelepipedContrloll : UserControl
    {
        public ParallelepipedContrloll()
        {
            InitializeComponent();
        }

        public Parallelepiped Value
        {
            get { return new Parallelepiped() { a = Convert.ToInt32(ASide_TextBox.Text), b = Convert.ToInt32(BSide_TextBox.Text), c = Convert.ToInt32(CSide_TextBox.Text) }; }
            set
            {
               ASide_TextBox.Text = value.a.ToString();
               BSide_TextBox.Text = value.b.ToString();
               CSide_TextBox.Text = value.c.ToString();
            }
        }



        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void ASide_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void BSide_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        /// <summary>
        /// Ограничение ввода в textbox
        /// </summary>
        private void CSide_TextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
