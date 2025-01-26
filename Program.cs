using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-й вариант
            Books books = new Books();
            books.Print();
            Console.WriteLine();

            //2-й вариант
            string nameBooks = books.name;
            string authorBooks = books.author;
            int yearBooks = books.year;
            int countBooks = books.count;
            Console.WriteLine($"Название книги: {nameBooks}\nАвтор книги: " +
                $"{authorBooks}\nГод выпуска: {yearBooks}\nОбъём в листах: {countBooks}");
            Console.WriteLine();

            //3-й вариант
            books.name = "Преступление и наказание";
            books.author = "Достоевский";
            books.year = 2023;
            books.count = 400;
            books.Print();
            Console.WriteLine();

            //4-й вариант
            Console.Write("Название книги: ");
            books.name = Console.ReadLine();
            Console.Write("Автор книги: ");
            books.author = Console.ReadLine();
            Console.Write("Год выпуска: ");
            books.year = int.Parse(Console.ReadLine());
            Console.Write("Объём в листах: ");
            books.count = int.Parse(Console.ReadLine());
            books.Print();

            Console.ReadKey();
        }
    }
}
