using System;
using System.Collections.Generic;

namespace BookStoreApp.BL.Model
{
    /// <summary>
    /// Отдел.
    /// </summary>
    public class Department
    {
        #region Свойства
        public string NameDepartment { get; set; }

        public List<Book> Books { get; set; }
        #endregion

        /// <summary>
        /// Создать новый отдел.
        /// </summary>
        /// <param name="nameDepartment"> Название отдела. </param>
        public Department(string nameDepartment, List<Book> books)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(nameDepartment))
            {
                throw new ArgumentNullException("Название отдела не может быть пустым.", nameof(nameDepartment));
            }
            if (books == null)
            {
                throw new ArgumentNullException("Где мои Книгиииии!!", nameof(books));
            }

            #endregion
            NameDepartment = nameDepartment;
            Books = books;
        }

        public Department()
        {
            NameDepartment = "Название отдела";
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return $"Название отдела:{NameDepartment}.\nКниги в отделе:{Books}.";
        }


        /// <summary>
        /// Добавляем новую книгу.
        /// </summary>
        /// <param name="nameBook"> Название книги. </param>
        /// <param name="priceBook"> Цена книги. </param>
        /// <param name="discountBook"> Скидки. </param>
        public void AddNewBook(string nameBook, double priceBook, double discountBook)
        {
            Book newBook = new Book(nameBook, priceBook, discountBook);
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

        //TODO: Где создать метод, чтобы определить общую сумму всех книг!!!
        ///// <summary>
        ///// Сумма всех книг.
        ///// </summary>
        //public double GetSumBook()
        //{
        //    Book sumBook = new Book();
        //    double sum = sumBook.Price;
        //    foreach (Book c in Books)
        //    {
        //        sum += c.Price;
        //    }
        //    return sum;

        //}
    }
}
