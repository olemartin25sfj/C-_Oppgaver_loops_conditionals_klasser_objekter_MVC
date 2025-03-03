public class View
{

    public void Display(Model model)
    {
        if (model.Books.Count == 0)
        {
            Console.WriteLine("Ingen bøker i samlingen.");
            return;
        }

        Console.WriteLine("\nBokliste:");
        foreach (var book in model.Books)
        {
            Console.WriteLine($"\n📖 {book.Title} ({book.Year}) - {book.Genre}");
            Console.WriteLine($"   {book.Description}");
        }
    }



}