using System;
using System.Collections.Generic;

namespace BookStoreApp.BL.Model
{
    /// <summary>
    /// Отдел.
    /// </summary>
    public class Department
    {
        /// <summary>
        ///  Название отдела.
        /// </summary>
        public string NameDepartment { get; set; }

        /// <summary>
        /// Список книг.
        /// </summary>
        public List<Book> Books { get; set; }


        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Department()
        {
            NameDepartment = "Название отдела";
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return $"Название отдела:{NameDepartment}.";
        }


        /// <summary>
        /// Добавляем новую книгу.
        /// </summary>
        /// <param name="nameBook"> Название книги. </param>
        /// <param name="priceBook"> Цена книги. </param>
        /// <param name="discountBook"> Скидки. </param>
        public void AddNewBook(string nameBook, double priceBook, double discountBook)
        {
            Book newBook = new Book()
            {
                NameBook = nameBook,
                Price = priceBook,
                Discount = discountBook
            };
            Books.Add(newBook);
        }

        /// <summary>
        /// Удаляем книгу.
        /// </summary>
        /// <param name="nameBook"> Название книги. </param>
        public void RemoveBook(int index)
        {
            Books.RemoveAt(index);
        }

        /// <summary>
        /// Сумма книг с учётом скидки.
        /// </summary>
        /// <returns> Сумма.</returns>
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
    }
}
