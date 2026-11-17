List<Book> books = new List<Book>();

books.Add(new Book("Война и мир", 1225));
books.Add(new Book("Преступление и наказание", 671));
books.Add(new Book("Мастер и Маргарита", 480));

Console.WriteLine($"Книг: {books.Count}");

foreach (Book book in books)
{
    Console.WriteLine(book.GetInfo());
}

int CountTolstih = 0;
foreach (Book book in books)
{
    if (book.Pages >= 600)
    {
        CountTolstih++;
    }
}
Console.WriteLine($"Толстых книг (от 600 страниц): {CountTolstih}");