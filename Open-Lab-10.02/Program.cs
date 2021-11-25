using System;

namespace Open_Lab_10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.title = "Peter Marcin";
            Console.WriteLine(LOTR.title);
        }
        class Book
        {
            public string title;
            private int pages;
        }
    }
}
