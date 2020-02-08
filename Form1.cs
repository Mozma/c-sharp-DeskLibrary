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
        BinaryFormatter binFormatter = new BinaryFormatter();
        List<Book> books = new List<Book>();
        List<Book> reading = new List<Book>();
     
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


            foreach (var book in books)
            {  
                libraryDataGridView.Rows.Add(book.Name, book.Author, book.Id);
            }


            foreach (var book in reading)
            {
                if(book.Status.ToLower().Equals("reading"))
                    readingDataGridView.Rows.Add(book.Name, book.Author, book.Id);
            }

            readingDataGridView.ClearSelection();
            libraryDataGridView.ClearSelection();
        }
        
        /// <summary>
        /// Сохраняет все данные.
        /// </summary>
        public void SaveData()
        {
            using (var file = new FileStream("books.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, books);

            }
            using (var file = new FileStream("reading.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, reading);
            }
           
        }
        private void LoadData()
        {
            try
            {
                using (var file = new FileStream("books.bin", FileMode.OpenOrCreate))
                {
                    var newBooks = binFormatter.Deserialize(file) as List<Book>;
                    if (newBooks != null)
                    {
                        books = newBooks;
                        fillTable();
                    }

                }
                using (var file = new FileStream("reading.bin", FileMode.OpenOrCreate))
                {
                    var newBooks = binFormatter.Deserialize(file) as List<Book>;
                    if (newBooks != null)
                    {
                        reading = newBooks;
                        fillTable();
                    }
                }
            }
            catch (Exception) { }
        }




        private void addButton_Click(object sender, EventArgs e)
        {
            //проверки 
            if (nameTextBox.TextLength > 2 && authorTextBox.TextLength > 2) {
                books.Add(new Book(nameTextBox.Text, authorTextBox.Text));
              
            }

            fillTable();
           // Console.WriteLine();
        }

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

      

        private void readingButton_Click(object sender, EventArgs e)
        {
            var book = books[libraryDataGridView.CurrentCell.RowIndex];
            book.Status = "reading";
            reading.Add(book);

            fillTable();
        }
    }
}
