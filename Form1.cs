using c_sharp_DeskLibrary.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace c_sharp_DeskLibrary
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

            LoadData();

        }
        
        #region Дополнительные перменные
        
        BinaryFormatter binFormatter = new BinaryFormatter();

        //List<Profile> users = new List<Profile>();
        //User user = new User("Admin");
        UserController userCtrl = new UserController("Admin");
        
        List<Book> books = new List<Book>();
        List<Book> reading = new List<Book>();
        List<Book> alreadyRead = new List<Book>();

        #endregion

        #region Настройка таблиц
        public void setUpDataGrid(DataGridView dg)
        {

            dg.ColumnCount = 3;
            dg.RowCount = 0;


            dg.Columns[0].HeaderText = "Название";
            dg.Columns[1].HeaderText = "Автор";
            dg.Columns[2].HeaderText = "Id";
            dg.Columns[2].Visible = false;

        
        }
        private void fillTable()
        {
            setUpDataGrid(libraryDataGridView);
            setUpDataGrid(readingDataGridView);
            setUpDataGrid(alreadyReadDataGridView);


            foreach (var book in books)
            {
                libraryDataGridView.Rows.Add(book.Name, book.Author, book.Id);
            }

            foreach (var book in reading)
            {
                readingDataGridView.Rows.Add(book.Name, book.Author, book.Id);
            }

            foreach (var book in alreadyRead)
            {
                alreadyReadDataGridView.Rows.Add(book.Name, book.Author, book.Id);
            }

            readingDataGridView.ClearSelection();
            libraryDataGridView.ClearSelection();
            alreadyReadDataGridView.ClearSelection();
        }

        #endregion

        #region Save/Load
        /// <summary>
        /// Сохраняет все данные.
        /// </summary>
        public void SaveData()
        {
            var path = userCtrl.CurrentUser.DirectoryPath;
            serializeIt(books,       path + @"\books.bin");
            serializeIt(reading,     path + @"\reading.bin");
            serializeIt(alreadyRead, path + @"\alreadyRead.bin");
            
        }

        private void serializeIt(List<Book> tmp, string nameBin)
        {
            using (var file = new FileStream(nameBin, FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, tmp);
            }
        }

        private void LoadData()
        {
            try
            {
                var path = userCtrl.CurrentUser.DirectoryPath;

                using (var file = new FileStream(path + @"\books.bin", FileMode.OpenOrCreate))
                {
                    var newBooks = binFormatter.Deserialize(file) as List<Book>;
                    if (newBooks != null)
                    {
                        books = newBooks;                        
                    }

                }

                using (var file = new FileStream(path + @"\reading.bin", FileMode.OpenOrCreate))
                {
                    var newBooks = binFormatter.Deserialize(file) as List<Book>;
                    if (newBooks != null)
                    {
                        reading = newBooks;                       
                    }
                }

                using (var file = new FileStream(path + @"\alreadyRead.bin", FileMode.OpenOrCreate))
                {
                    var newBooks = binFormatter.Deserialize(file) as List<Book>;
                    if (newBooks != null)
                    {
                        alreadyRead = newBooks;
            
                    }
                }

                fillTable();
            }
            catch (Exception) { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        #endregion

        #region Кнопки
        private void addButton_Click(object sender, EventArgs e)
        {
            //проверки 
            if (nameTextBox.TextLength > 2 && authorTextBox.TextLength > 2) {
                books.Add(new Book(nameTextBox.Text, authorTextBox.Text));
              
            }

            fillTable();
      
        }

        /// <summary>
        /// Удаление выбранного элемента из books.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delButton_Click(object sender, EventArgs e)
        {
            try
            {
                var index = libraryDataGridView[2, libraryDataGridView.CurrentRow.Index].Value.ToString();

                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Id.Equals(index))
                    {
                        books.RemoveAt(i);
                        break;
                    }
                }
                fillTable();
            }
            catch (NullReferenceException)
            {
                
            }
        }

        /// <summary>
        /// Кнопка контекстного меню "Добавить в "Читаю" ".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readingButton_Click(object sender, EventArgs e)
        {
            var book = books[libraryDataGridView.CurrentCell.RowIndex];

            reading.Add(book);

            fillTable();
        }

        /// <summary>
        /// Кнопка - Убрать из Читаю.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tmp = readingDataGridView[2, readingDataGridView.CurrentCell.RowIndex].Value;

            for (int i = 0; i < reading.Count; i++)
            {
                if (reading[i].Id.Equals(tmp))
                    reading.RemoveAt(i);
            }

            fillTable();

        }

        private void alreadyReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var book = reading[readingDataGridView.CurrentCell.RowIndex];

            var tmp = readingDataGridView[2, readingDataGridView.CurrentCell.RowIndex].Value;
            alreadyRead.Add(book);
            for (int i = 0; i < reading.Count; i++)
            {
                if (reading[i].Id.Equals(tmp))
                    reading.RemoveAt(i);
            }

            fillTable();
        }

#endregion

        /// <summary>
        ///  Method for drawing items of tabControl on the left side
        /// </summary>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
               _textBrush = new SolidBrush(Color.Black);
               // g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Segoe UI", (float)16.0, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

          
        }

        private void ChangeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // User pr = new User("ss");
        }
    }
}
