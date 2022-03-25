using System;
using System.Windows.Data;
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
        Department department;
        string uri;
        public Form1()
        {
            InitializeComponent();
            bookStore = new BookStore();
            uri = @"BookStoreData.xml";
            dataGridAttribs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewTextBoxColumn collAttrValue = new DataGridViewTextBoxColumn();
            collAttrValue.HeaderText = "Значение";
            collAttrValue.Width = 200;
            dataGridAttribs.Columns.Add(collAttrValue);

        }
        /// <summary>
        /// Обновлять список отделов.
        /// </summary>
        private void RefreshListBoxDepartment()
        {
            listBoxDepartment.Items.Clear();
            listBoxDepartment.DisplayMember = "Name Department";
            foreach (Department department in bookStore.Departments)
            {
                listBoxDepartment.Items.Add(department);
            }

        }

        /// <summary>
        /// Отображение атрибуты выбранного отдела = DataGridAttribs
        /// </summary>
        private void ShowDepartmentAttributes()
        {
            dataGridAttribs.Rows.Clear();
            dataGridAttribs.Rows.Add(1);
            dataGridAttribs.Rows[0].HeaderCell.Value = "Название отдела";
            Department department = listBoxDepartment.SelectedItem as Department;
            if (department != null)
            {
                dataGridAttribs.Rows[0].Cells[0].Value = department.NameDepartment;
                RefreshListBoxDepartment();
            }
        }
        private void AddNewDepartment()
        {
            string nameDepartment = dataGridAttribs.Rows[0].Cells[0].Value.ToString();
            bookStore.AddNewDepartments(nameDepartment);

        }
        private void RemoveDepartment()
        {
            int index = listBoxDepartment.SelectedIndex;
            if (index >= 0 && index < bookStore.Departments.Count)
            {
                bookStore.RemoveDepartament(index);
                RefreshListBoxDepartment();
            }

        }

        private void RefreshListBoxBooks()
        {
            listBoxBook.Items.Clear();
            listBoxBook.DisplayMember = "Name Book";
            Department department = listBoxDepartment.SelectedItem as Department;
            if (department != null)
            {
                foreach (Book book in department.Books)
                {
                    listBoxBook.Items.Add(book);
                }
            }
        }
        private void ShowBookAttributes()
        {
            dataGridAttribs.Rows.Clear();
            dataGridAttribs.Rows.Add(3);
            dataGridAttribs.Rows[0].HeaderCell.Value = "Название";
            dataGridAttribs.Rows[1].HeaderCell.Value = "Цена";
            dataGridAttribs.Rows[2].HeaderCell.Value = "Скидка";

            Book book = listBoxDepartment.SelectedItem as Book;
            if (book != null)
            {
                dataGridAttribs.Rows[0].Cells[0].Value = book.NameBook;
                dataGridAttribs.Rows[1].Cells[0].Value = book.Price;
                dataGridAttribs.Rows[3].Cells[0].Value = book.Discount;
            }
        }
        private void AddNewBook()
        {
            string nameBook = dataGridAttribs.Rows[0].Cells[0].Value.ToString();
            int price = 0;
            int.TryParse(dataGridAttribs.Rows[1].Cells[0].Value.ToString(), out price);
            int discount = 0;
            int.TryParse(dataGridAttribs.Rows[2].Cells[0].Value.ToString(), out discount);

            Department department = listBoxDepartment.SelectedItem as Department;
            if (department != null)
            {
                department.AddNewBook(nameBook, price, discount);
            }
        }
        private void RemoveBook()
        {
            Department department = listBoxDepartment.SelectedItem as Department;
            if (department != null)
            {
                int index = listBoxBook.SelectedIndex;
                if (index >= 0 && index < department.Books.Count)
                {
                    department.RemoveBook(index);
                    RefreshListBoxBooks();
                }
            }
        }
        private void TotalSummBooks()
        {
            MessageBox.Show(string.Format($"{department.GetSumBook()} $."), "Общая сумма книг.");
        }


        private void ShowAdress()
        {
            MessageBox.Show(string.Format("Улица Мичурина57."));
        }
        private void SaveData()
        {
            // XmlDataProvider<BookStore>.SaveObject(uri, bookStore);
            MessageBox.Show("Данные сохранены!");
        }
        private void LoadData()
        {
            //bookStore = XmlDataProvider<BookStore>.LoadObject(uri);
            RefreshListBoxDepartment();
            MessageBox.Show("Данные Загружены!");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Книжный магазин";
            RefreshListBoxDepartment();
            textBoxSum.Text = "10";

        }

        private void listBoxDepartment_Click(object sender, EventArgs e)
        {
            ShowDepartmentAttributes();
            RefreshListBoxBooks();
        }

        private void listBoxBook_Click(object sender, EventArgs e)
        {
            ShowBookAttributes();
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            AddNewDepartment();
        }

        private void buttonRemoveDepartment_Click(object sender, EventArgs e)
        {
            RemoveDepartment();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddNewBook();
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            RemoveBook();
        }

        private void buttonTotalSum_Click(object sender, EventArgs e)
        {
            TotalSummBooks();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowAdress();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
