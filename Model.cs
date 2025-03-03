public class Book
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }

    public string Description { get; set; }
}

public class Model
{
    public List<Book> Books { get; set; }

    public Model()
    {
        Books = new List<Book>
    {
        new Book { Title = "Hvordan debugge uten å gråte", Year = 2023, Genre = "Selvhjelp",
                   Description = "En overlevelsesguide for utviklere som stadig finner bugs." },
        new Book { Title = "1001 unnskyldninger for å utsette koding", Year = 2024, Genre = "Humor",
                   Description = "Perfekt for deg som alltid finner noe annet å gjøre enn å kode." },
        new Book { Title = "Try/Catch – En kjærlighetshistorie", Year = 2022, Genre = "Romantikk",
                   Description = "En historie om et par som prøver å håndtere sine unntak." },
        new Book { Title = "Den magiske nullreferansen", Year = 2021, Genre = "Skrekk",
                   Description = "En programmerers verste mareritt blir til virkelighet." },
        new Book { Title = "Console.WriteLine: Mitt liv som utvikler", Year = 2025, Genre = "Biografi",
                   Description = "Historien om en utvikler som levde sitt liv én linje av gangen." },
        new Book { Title = "Objekter og andre mysterier", Year = 2020, Genre = "Krim",
                   Description = "En detektivroman hvor objekter forsvinner sporløst fra heapen." },
        new Book { Title = "Fra Hello World til burnout", Year = 2023, Genre = "Dokumentar",
                   Description = "En reise gjennom kode, kaos og utbrenthet." },
        new Book { Title = "MVC: My Very Confusing journey", Year = 2024, Genre = "Eventyr",
                   Description = "En episk fortelling om en student som prøver å forstå MVC." }
    };
    }

}