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
        public Department(string nameDepartment)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(nameDepartment))
            {
                throw new ArgumentNullException("Название отдела не может быть пустым.", nameof(nameDepartment));
            }
            #endregion
            NameDepartment = nameDepartment;
        }

        public Department()
        {
            NameDepartment = "Название отдела";
        }

        public override string ToString()
        {
            return $"Название отдела:{NameDepartment}.\nКниги в отделе:{Books}.";
        }

        public void CreateNewDepartment(string nameDepartment, string nameBook, double priceBook, double discountBook)
        {
            Department department = new Department(nameDepartment);
            Book newBook = new Book(nameBook, priceBook, discountBook);
            Books.Add(newBook);
        }
    }
}
