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
        public Department(string nameDepartment)
        {
            NameDepartment = nameDepartment;
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
        public void AddNewBook(Book newBook)
        {
            Books.Add(newBook);
        }

        /// <summary>
        /// Удаляем книгу.
        /// </summary>
        /// <param name="nameBook"> Название книги. </param>
        public void RemoveBook(int ID)
        {
            Books.RemoveAt(ID);
        }

        /// <summary>
        /// Сумма книг.
        /// </summary>
        /// <returns> Сумма.</returns>
        public double GetSumBook()
        {
            double sum = 0;
            foreach (Book b in Books)
            {
                sum += b.Price;
            }
            return sum;

        }
    }
}
