using System;
using System.Windows.Forms;
using BookStoreApp.BL.Model;
namespace BookStoreApp.WFM
{
    /*

Книжный магазин (название, адрес).
Отдел (название).
Книга (название, цена, скидка). 

Знать:
• Какие книги имеются в отделе магазина.
• Выручку от продажи.

Делать:
• Добавить книгу.
• Продать книгу.
• Определить стоимость книги с учётом скидки.
• Найти суммарную стоимость книг

*/
    public partial class Form1 : Form
    {
        BookStore bookStore;
        string uri;
        public Form1()
        {
            InitializeComponent();
            uri = @"Xml.File";
            dataGridAttribs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewTextBoxColumn collAttrValue = new DataGridViewTextBoxColumn();
            collAttrValue.HeaderText = "Значение";
            collAttrValue.Width = 200;
            dataGridAttribs.Columns.Add(collAttrValue);

        }

        private void RefreshListBoxDepartment()
        {
            listBoxBookStore.Items.Clear();
            listBoxBookStore.DisplayMember = "Name Department";
            foreach (Department department in bookStore.Departments)
            {
                listBoxDepartment.Items.Add(department);
            }

        }
        private void showDepartmentAttributes()
        {
            dataGridAttribs.Rows.Clear();
            dataGridAttribs.Rows.Add(1);
            dataGridAttribs.Rows[0].HeaderCell.Value = "Название отдела";
            Department department = listBoxDepartment.SelectedItem as Department;
            if (department != null)
            {
                dataGridAttribs.Rows[0].Cells[0].Value = department.NameDepartment;

            }


        }

        private void AddNewDepartment()
        {
            string nameDepartment = dataGridAttribs.Rows[0].Cells[0].Value.ToString();
            bookStore.AddNewDepartments(nameDepartment);

        }
        private void RemoveBookStore()
        {
            int index = listBoxDepartment.SelectedIndex;
            if (index >= 0 && index < bookStore.Departments.Count)
            {
                bookStore.RemoveDepartament(index);
                RefreshListBoxDepartment();
            }

        }

        private void RefreshListBoxBookStore()
        {
            listBoxBookStore.Items.Clear();
            listBoxBookStore.DisplayMember = "Name BookStore";
            Department department = listBoxDepartment.SelectedItem as Department;
            if(department != null)
            {
                foreach(BookStore bookStore in )
            }
        }
        private void AddBook()
        {

        }
        private void RemoveBook()
        {

        }
        private void TotalSummBooks()
        {

        }


        private void buttonRemoveBookStore_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBookStore_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonTotalSum_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
