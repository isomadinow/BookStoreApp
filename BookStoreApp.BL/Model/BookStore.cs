using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BookStoreApp.BL.Model
{

    [Serializable]


    /// <summary>
    /// Книжный магазин.
    /// </summary>

    public class BookStore
    {
        #region Свойства
        [XmlElement]
        public string NameBookStore { get; set; }
        public string Adress { get; set; }
        public List<Book> Books { get; set; }


        #endregion

        /// <summary>
        /// Создаётся новый книжный магазин.
        /// </summary>
        /// <param name="nameBookStore"> Название книжного магазина. </param>
        /// <param name="adress"> Адрес книжного магазина. </param>
        /// <param name="informationsBook"> Информация о книге. </param>

        public BookStore(string nameBookStore, string adress, List<Book> books)
        {
            #region Проверка условий

            if (string.IsNullOrWhiteSpace(nameBookStore))
            {
                throw new ArgumentNullException("Название магазина не может быть пустым.", nameof(nameBookStore));
            }
            if (string.IsNullOrWhiteSpace(adress))
            {
                throw new ArgumentNullException("Адрес не должен быть пустым.", nameof(adress));
            }
            if (books == null)
            {
                throw new ArgumentNullException("Информации о книги не может быть пустым.", nameof(books));
            }


            #endregion

            NameBookStore = nameBookStore;
            Adress = adress;
            Books = books;

        }
        public BookStore()
        {
            NameBookStore = "Книжный магазин";
            Adress = "Адрес магазина";
            Books = new List<Book>();
        }
        public override string ToString()
        {
            return $"Название книжного магазина:{NameBookStore}.\nАдрес:{Adress}.\nИнформации о книге:{Books}.";
        }

        /// <summary>
        /// Сумма всех книг.
        /// </summary>
        public double GetSumBook()
        {
            Book sumBook = new Book();
            double sum = sumBook.Price;
            foreach (Book c in Books)
            {
                sum += c.Price;
            }
            return sum;

        }

        /// <summary>
        /// Добавление книги.
        /// </summary>
        /// <param name="nameBook"> название книги. </param>
        /// <param name="price"> Цена книги. </param>
        /// <param name="discount"> Скидка книги. </param>
        /// <param name="department"> Отдел книги. </param>
        public void AddNewBook(string nameBook, double price, double discount, Department department)
        {
            Book newBook = new Book(nameBook, price, discount);

            Books.Add(newBook);
        }
        public void BuyBook(int index)
        {
            Books.RemoveAt(index);
        }





    }
}
