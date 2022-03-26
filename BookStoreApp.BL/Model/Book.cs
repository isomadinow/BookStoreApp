using System;
using System.Xml;
using System.Xml.Serialization;

namespace BookStoreApp.BL.Model
{
    [Serializable]


    /// <summary>
    /// Книга
    /// </summary>
    public class Book
    {
        [XmlAttribute]

        public int ID { get; set; }
        public string NameBook { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }


        /// <summary>
        /// Добавить новую книгу.
        /// </summary>
        /// <param name="id"> Индекс. </param>
        /// <param name="nameBook"> Название книги.</param>
        /// <param name="price"> Цена Книги. </param>
        /// <param name="discount"> Скидка на книгу.</param>
        public Book(int id, string nameBook, double price, double discount)
        {
            ID = id;
            NameBook = nameBook;
            Price = price;
            Discount = discount;
        }

        public override string ToString()
        {
            return $" Название книги:{NameBook}.\n Цена:{Price}.";
        }

        /// <summary>
        /// Стоимость со скидкой.
        /// </summary>
        /// <returns> Цена </returns>
        public double Cost()
        {
            double cost = Price - (Price * Discount / 100);
            return cost;
        }


    }
}
