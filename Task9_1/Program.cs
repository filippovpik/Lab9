using System.Dynamic;

namespace Task9_1
{
    internal class Program
    {
        static void Main()
        {
            var book1 = new Book("Война и мир", "Л. Толстой", 1869, "1225 стр.");

            book1.GetInfo();

            Console.ReadLine();
        }

        class Book
        {
            // Поля
            private string _title;
            private string _author;

            // Автосвойства
            public int Year { get; set; }
            public string Pages { get; set; }

            // Конструктор
            public Book(string title, string author, int year, string pages)
            {
                _title = title;
                _author = author;
                Year = year;
                Pages = pages;
            }

            // Метод
            public void GetInfo()
            {
                Console.WriteLine($"{_title}, {_author}, {Year}, {Pages}");
            }
        }
    }
}
