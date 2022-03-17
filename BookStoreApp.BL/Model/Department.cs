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
                throw new ArgumentNullException("Название отдела не может быть пустым.", nameof(books));
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
    }
}
