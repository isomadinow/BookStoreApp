using System;
using System.Collections.Generic;

namespace BookStoreApp.BL.Model
{


    /// <summary>
    /// Книга
    /// </summary>
    public class Book
    {
        #region Свойства
        public string NameBook { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        #endregion
        /// <summary>
        /// Добавить новую книгу.
        /// </summary>
        /// <param name="name"> Название книги. </param>
        /// <param name="price"> Цена книги. </param>
        /// <param name="discount"> Скидка на книгу. </param>

        public Book(string nameBook, double price, double discount)
        {
            #region Проверка условий

            if (string.IsNullOrWhiteSpace(nameBook))
            {
                throw new ArgumentNullException("Название книги не может быть пустым.", nameof(nameBook));
            }

            if (price <= 0)
            {
                throw new ArgumentException("Цена не может быть меньше либо равен нулю.", nameof(price));
            }
            if (discount < 0)
            {
                throw new ArgumentException("Скидка не может быть меньше либо равен нулю.", nameof(discount));
            }

            #endregion

            NameBook = nameBook;
            Price = (price - ((price * discount) / 100));
            Discount = discount;

        }
        public Book()
        {
            NameBook = "Название книги";
            Price = 1;
            Discount = 1;
        }

        public override string ToString()
        {
            return $" Название книги:{NameBook}.\n Цена с учётом скидки:{Price}.\n Скидка:{Discount}%.";
        }



    }
}
