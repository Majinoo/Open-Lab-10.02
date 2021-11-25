using System;
namespace Open_Lab_10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title("Petrov Život");
            LOTR.Pages(69);
            LOTR.Cathegory("Funny");
            LOTR.Author("Ján Kábel");
            LOTR.RelaseDate(2020);
            LOTR.Write();
        }
        class Book
        {
            private string title;
            private int pages;
            private string cathegory;
            private string author;
            private int relaseDate;
            public void Title(string newTitle) { title = newTitle; }
            public void Pages(int newPages) { pages = newPages; }
            public void Cathegory(string newCathegory) { cathegory = newCathegory; }
            public void Author(string newAuthor) { author = newAuthor; }
            public void RelaseDate(int newRelaseDate) { relaseDate = newRelaseDate; }
            public void Write()
            {
                Console.WriteLine("Názov: " + title);
                Console.WriteLine("Počet strán: " + pages);
                Console.WriteLine("Žáner: " + cathegory);
                Console.WriteLine("Autor: " + author);
                Console.WriteLine("Dátum vydania: " + relaseDate);
                
            }
        }
    }
}
