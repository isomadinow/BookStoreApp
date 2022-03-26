using System;
using System.Windows.Forms;
using BookStoreApp.BL.Model;
using BookStoreApp.BL.Provaider;
namespace BookStoreApp.WFM
{
    public partial class Form1 : Form
    {
        BookStore bookStore;
        string uri;
        private void RefreshListBoxDepartment()
        {
            listBoxDepartment.Items.Clear();
            listBoxBook.Items.Clear();

            foreach (Department department in bookStore.Departments)
            {
                listBoxDepartment.Items.Add(department.ToString());
            }

        }
        private void RefreshListBoxBooks()
        {
            listBoxBook.Items.Clear();
            foreach (Book book in bookStore.Departments[listBoxDepartment.SelectedIndex].Books)
            {
                listBoxBook.Items.Add(book.ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
            bookStore = new BookStore();
            uri = @"BookStoreData.xml";
            bookStore.AddNewDepartment(new Department(""));
            RefreshListBoxDepartment();
            dataGridAttribs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewTextBoxColumn collAttrValue = new DataGridViewTextBoxColumn();
            collAttrValue.HeaderText = "Значение";
            collAttrValue.Width = 200;
            dataGridAttribs.Columns.Add(collAttrValue);

        }
        private void listBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListBoxBooks();
        }
        private void listBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBookAttributes();

        }
        private void ShowBookAttributes()
        {
            dataGridAttribs.Rows.Clear();
            dataGridAttribs.Rows.Add(4);
            dataGridAttribs.Rows[0].HeaderCell.Value = "Код";
            dataGridAttribs.Rows[1].HeaderCell.Value = "Название";
            dataGridAttribs.Rows[2].HeaderCell.Value = "Цена";
            dataGridAttribs.Rows[3].HeaderCell.Value = "Скидка";

            Book book = bookStore.Departments[listBoxDepartment.SelectedIndex].Books[listBoxBook.SelectedIndex];
            if (book != null)
            {
                dataGridAttribs.Rows[0].Cells[0].Value = book.ID;
                dataGridAttribs.Rows[1].Cells[0].Value = book.NameBook;
                dataGridAttribs.Rows[2].Cells[0].Value = book.Price;
                dataGridAttribs.Rows[3].Cells[0].Value = book.Discount;
            }
        }
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            bookStore.Departments[listBoxDepartment.SelectedIndex].AddNewBook(new Book(0, "", 2, 3));
            RefreshListBoxBooks();
        }
        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            int ID = listBoxBook.SelectedIndex;
            bookStore.Departments[listBoxDepartment.SelectedIndex].RemoveBook(ID);
            RefreshListBoxBooks();
        }


        private void buttonChek_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format($"{ bookStore.Departments[listBoxDepartment.SelectedIndex].Books[listBoxBook.SelectedIndex].Cost()} p."));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format($"{bookStore.Revenue} p."));
        }
    }
}
