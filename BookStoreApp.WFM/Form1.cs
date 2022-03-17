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
        string uri;
        public Form1()
        {
            InitializeComponent();
            // uri =@""
            dataGridAttribs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewTextBoxColumn collAttrValue = new DataGridViewTextBoxColumn();
            collAttrValue.HeaderText = "Значение";
            collAttrValue.Width = 200;
            dataGridAttribs.Columns.Add(collAttrValue);

        }

        private void RefreshListBoxBookStores()
        {
            listBoxBookStore.Items.Clear();
            listBoxBookStore.DisplayMember = "nameBookStore";

        }

        private void AddBookStore()
        {

        }
        private void RemoveBookStore()
        {

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
