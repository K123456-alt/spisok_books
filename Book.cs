public class Book
{
    public string Title;
    public int Pages;

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public string GetInfo()
    {
        return $"{Title} - {Pages} страниц";
    }
}