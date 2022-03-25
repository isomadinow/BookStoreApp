using System;
using System.Collections.Generic;

namespace BookStoreApp.BL.Model
{


    /// <summary>
    /// Книга
    /// </summary>
    public class Book
    {

        public string NameBook { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public Book()
        {
            NameBook = "Название книги";
            Price = (Price - ((Price * Discount) / 100));
            Discount = 1;
        }

        public override string ToString()
        {
            return $" Название книги:{NameBook}.\n Цена с учётом скидки:{Price}.\n Скидка:{Discount}%.";
        }



    }
}
