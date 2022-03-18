using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BookStoreApp.BL.Model
{



    /// <summary>
    /// Книжный магазин.
    /// </summary>
    [Serializable]
    public class BookStore
    {
        #region Свойства
        public string NameBookStore { get; set; }
        public string Adress { get; set; }
        public List<Department> Departments { get; set; }


        #endregion

        /// <summary>
        /// Создаётся новый книжный магазин.
        /// </summary>
        /// <param name="nameBookStore"> Название книжного магазина. </param>
        /// <param name="adress"> Адрес книжного магазина. </param>
        /// <param name="departments"> отдел магазина. </param>

        public BookStore(string nameBookStore, string adress, List<Department> departments)
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
            if (departments == null)
            {
                throw new ArgumentNullException("Информации о книги не может быть пустым.", nameof(departments));
            }


            #endregion

            NameBookStore = nameBookStore;
            Adress = adress;
            Departments = departments;

        }
        public BookStore()
        {
            NameBookStore = "Книжный магазин";
            Adress = "Адрес магазина";
            Departments = new List<Department>();
        }
        public override string ToString()
        {
            return $"Название книжного магазина:{NameBookStore}.\nАдрес:{Adress}.\nИнформации о книге:{Departments}.";
        }
        /// <summary>
        /// Добавление нового отдела. 
        /// </summary>
        /// <param name="nameDepartment"> Название в отделе. </param>
        /// <param name="books"> Создаём список для добавление книг. </param>
        public void AddNewDepartments(string nameDepartment, List<Book> books)
        {
            Department newDepartment = new Department(nameDepartment, books);
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







    }
}
