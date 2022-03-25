using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BookStoreApp.BL.Model
{



    /// <summary>
    /// Книжный магазин.
    /// </summary>

    public class BookStore
    {
        #region Свойства

        /// <summary>
        /// Название книжного магазина.
        /// </summary>
        public string NameBookStore { get; set; }

        /// <summary>
        /// Адрес книжного магазина.
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Список Отделов.
        /// </summary>
        public List<Department> Departments { get; set; }

        #endregion


        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public BookStore()
        {
            NameBookStore = "Книжный магазин";
            Adress = "Адрес магазина";
            Departments = new List<Department>();
        }


        public override string ToString()
        {
            return $"Название книжного магазина:{NameBookStore}.\nАдрес:{Adress}.";
        }


        /// <summary>
        /// Добавление нового отдела. 
        /// </summary>
        /// <param name="nameDepartment"> Название в отделе. </param>
        /// <param name="bookList"> Создаём список для добавление книг. </param>
        /// 
        public void AddNewDepartments(string nameDepartment)
        {
            Department newDepartment = new Department()
            {
                NameDepartment = nameDepartment,
                Books = new List<Book>()
            };
            Departments.Add(newDepartment);
        }

        /// <summary>
        /// Удаление отдела.
        /// </summary>
        /// <param name="index"> индекс.</param>
        public void RemoveDepartament(int index)
        {
            Departments.RemoveAt(index);
        }

        // TODO: Где создать метод, чтобы определить общую сумму всех книг!!!
        /// <summary>
        /// Сумма всех книг.
        /// </summary>






    }
}
