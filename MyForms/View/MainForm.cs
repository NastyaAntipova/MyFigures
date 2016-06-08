using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Figure;
using Newtonsoft;


namespace View
{
    public partial class MainForm : Form
    {
        private DataTable _tablefigure;

        public IFigure Figures { get; set; }

        public MainForm(string[] args)
        {
                InitializeComponent();
                CreateColumns();
        }

        private void CreateColumns()
        {
            _tablefigure = new DataTable();
            var column0 = new DataColumn("Name")
            {
                Caption = "Figure",
                DataType = typeof(string),
                ReadOnly = true
            };
            var column1 = new DataColumn("Volume")
            {
                Caption = "Volume",
                ReadOnly = true,
                DataType = typeof(double)
            };
            var column2 = new DataColumn("X")
            {
                Caption = "X",
                ReadOnly = true,
                DataType = typeof(double)

            };
            var column3 = new DataColumn("Y")
            {
                Caption = "Y",
                ReadOnly = true,
                DataType = typeof(double)

            };
            var column4 = new DataColumn("Z")
            {
                Caption = "Z",
                ReadOnly = true,
                DataType = typeof(double)

            };

            _tablefigure.Columns.Add(column0);
            _tablefigure.Columns.Add(column1);
            _tablefigure.Columns.Add(column2);
            _tablefigure.Columns.Add(column3);
            _tablefigure.Columns.Add(column4);
            TableFigure.DataSource = _tablefigure;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void TableFigure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                //добавить фигуру в таблицу
            {
                var figure = figureForm.Figures;
                ListFigure.List.Add(figure);
                var row = _tablefigure.NewRow();
                row[0] = figure.Name;
                row[1] = figure.CalculateVolume();
                row[2] = figure.X;
                row[3] = figure.Y;
                row[4] = figure.Z;
                _tablefigure.Rows.Add(row);
                TableFigure.Update();

            }

        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Изменить обьект?", "Изменение обьекта", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 if (TableFigure.CurrentRow != null)
                 {
                     foreach (DataGridViewCell cell in TableFigure.SelectedCells)
                     {

                         FigureForm f = new FigureForm();
                         var a = TableFigure.SelectedCells[0].RowIndex;
                         IFigure figure = ListFigure.List[a];
                         f.ShowDialog();
                         if (f.DialogResult == DialogResult.OK)
                         {
                             TableFigure.Rows.RemoveAt(cell.RowIndex);

                             figure = f.Figures;
                             ListFigure.List.Add(figure);
                             var row = _tablefigure.NewRow();
                             row[0] = figure.Name;
                             row[1] = figure.CalculateVolume();

                             _tablefigure.Rows.Add(row);
                             TableFigure.Update();
                         }
                     }
                 }
             }
        }

        /// <summary>
        /// Кнопка удалить
        /// </summary>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (TableFigure.CurrentRow == null)
                return;
            _tablefigure.Rows.RemoveAt(TableFigure.CurrentRow.Index);
        }


        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        /// <summary>
        /// Кнопка Выход
        /// </summary>
        private void ExitItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Остановить программу?",
                "Завершение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }

        /// <summary>
        /// Кнопка Открыть
        /// </summary>
        private void OpenItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Figure |*.myfile";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = openFileDialog.FileName;
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                using (Newtonsoft.Json.JsonReader jreader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    ListFigure.List = serializer.Deserialize<List<IFigure>>(jreader);
                }
                for (int i = 0; i < ListFigure.List.Count; i++)
                {
                    var figure = ListFigure.List[i];
                    var row = _tablefigure.NewRow();
                    row[0] = figure.ToString();
                    row[1] = figure.CalculateVolume();
                    row[2] = figure.X;
                    row[3] = figure.Y;
                    row[4] = figure.Z;
                    _tablefigure.Rows.Add(row);
                }
                TableFigure.Update();

            }

        }

        /// <summary>
        /// Закрыть
        /// </summary>
        private void CloseItem_Click(object sender, EventArgs e)
        {
            System.Environment.FailFast("Exit");
            MessageBox.Show("Вы хотите выйти?", "Выход",
                MessageBoxButtons.OK);
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        private void SaveItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Figure |@*.myfile";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = saveFileDialog.FileName;
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                using (Newtonsoft.Json.JsonWriter jwriter = new Newtonsoft.Json.JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jwriter, ListFigure.List);
                }
                MessageBox.Show("Сохранено!");
            }
        }

        /// <summary>
        /// Обработчик кнопки "Заполнить таблицу" 
        /// </summary>
        public IFigure Figure { get; set; }

        private int _figure;



        /// <summary>
        /// Обработчик кнопки "Изменить данные" 
        /// </summary>
        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Изменить обьект?", "Изменение обьекта", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (TableFigure.CurrentRow != null)
                {
                    foreach (DataGridViewCell cell in TableFigure.SelectedCells)
                    {

                        var figureForm = new FigureForm();
                        var a = TableFigure.SelectedCells[0].RowIndex;
                        IFigure figure = ListFigure.List[a];
                        if (figureForm.ShowDialog() == DialogResult.OK)
                        {
                            TableFigure.Rows.RemoveAt(cell.RowIndex);
                            
                            ListFigure.List.Add(figure);
                            var row = _tablefigure.NewRow();
                            row[0] = figure.ToString();
                            row[1] = figure.CalculateVolume();
                            row[2] = figure.X;
                            row[3] = figure.Y;
                            row[4] = figure.Z;

                            _tablefigure.Rows.Add(row);
                            TableFigure.Update();
                        }
                    }
                }

            }
        }
    }
}
