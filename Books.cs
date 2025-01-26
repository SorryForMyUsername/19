using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1
{
    /// <summary>
    /// класс Книги
    /// </summary>
    internal class Books
    {
        /// <summary>
        /// Название книги
        /// </summary>
        public string name = "Бородино";

        /// <summary>
        /// Автор
        /// </summary>
        public string author = "Лермонтов";

        /// <summary>
        /// Год выпуска
        /// </summary>
        public int year = 2005;

        /// <summary>
        /// Объём в листах
        /// </summary>
        public int count = 120;

        /// <summary>
        /// Метод вывода информации о книге.
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Название книги: {name}\nАвтор книги: " +
                $"{author}\nГод выпуска: {year}\nОбъём в листах: {count}");
        }
    }
}
