using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.File;


namespace MyForms
{
    public partial class Form1 : Form
    {
        private DataTable _tablefigure;
        


        public Form1()
        {
            InitializeComponent();

           
            
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void TableFigure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _tablefigure = new DataTable();
            var column = new DataColumn("Name")
            {
                DataType = typeof(string)
            };
            _tablefigure.Columns.Add(column);
            TableFigure.DataSource = _tablefigure;

            {
                _tablefigure = new DataTable();
               column = new DataColumn("X")
                {
                    DataType = typeof(string)
                };
                _tablefigure.Columns.Add(column);
                TableFigure.DataSource = _tablefigure;

            }
            {
                _tablefigure = new DataTable();
                column = new DataColumn("Y")
                {
                    DataType = typeof(string)
                };
                _tablefigure.Columns.Add(column);
                TableFigure.DataSource = _tablefigure;

            }
            {
                _tablefigure = new DataTable();
                column = new DataColumn("Z")
                {
                    DataType = typeof(string)
                };
                _tablefigure.Columns.Add(column);
                TableFigure.DataSource = _tablefigure;

            }
            {
                _tablefigure = new DataTable();
                column = new DataColumn("Volume")
                {
                    DataType = typeof(string)
                };
                _tablefigure.Columns.Add(column);
                TableFigure.DataSource = _tablefigure;

            }

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var figureForm = new FigureForm();
            if (figureForm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {

        }
        

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newRow = _tablefigure.NewRow();
            newRow["X"] = 3.0;
            newRow["Y"] = 5.0;
            newRow["Name"] = "Шар";
            _tablefigure.Rows.Add(newRow);
            TableFigure.Update();
        }

       

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        // Команда Открыть
        protected void MMOpenClick(object who, EventArgs e)
        {
            MessageBox.Show("Неактивная команда", "Заглушка",
            MessageBoxButtons.OK);
        }

        // Команда Открыть
        protected void MMCloseClick(object who, EventArgs e)
        {
            MessageBox.Show("Неактивная команда", "Заглушка",
            MessageBoxButtons.OK);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            MainMenu Menu = new MainMenu();
            MenuItem m1 = new MenuItem("Меню"); // Элемент вехнего уровня
            Menu.MenuItems.Add(m1);
            MenuItem subm1 = new MenuItem("Открыть");
            m1.MenuItems.Add(subm1);
            MenuItem subm2 = new MenuItem("Закрыть");
            m1.MenuItems.Add(subm2);
            MenuItem subm3 = new MenuItem("Выйти");
            m1.MenuItems.Add(subm3);

            subm1.Click += new EventHandler(OpenItem_Click);
            subm2.Click += new EventHandler(CloseItem_Click);
            subm3.Click += new EventHandler(ExitItem_Click);
            
          
        }

        // Выход
        private void ExitItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Остановить программу?",
            "Завершение",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }

        // Открыть
        private void OpenItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Неактивная команда", "Заглушка",
            MessageBoxButtons.OK);
        }

        // Закрыть
        private void CloseItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неактивная команда", "Заглушка",
            MessageBoxButtons.OK);
        }
        
    }
}
