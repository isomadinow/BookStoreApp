using System;
using System.Collections.Generic;


namespace BookStoreApp.BL.Model
{



    /// <summary>
    /// Книжный магазин.
    /// </summary>
    [Serializable]
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
        public double Revenue { get; set; }

        /// <summary>
        /// Список Отделов.
        /// </summary>
        public List<Department> Departments { get; set; }

        #endregion

        public void AddNewDepartment(Department department)
        {
            Departments.Add(department);
        }




        public override string ToString()
        {
            return $"Название книжного магазина:{NameBookStore}.\nАдрес:{Adress}.";
        }






    }
}
