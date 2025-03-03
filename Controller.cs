using System.ComponentModel;
using System.ComponentModel.Design;

public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nVelg et alternativ:");
            Console.WriteLine("1. Vis alle bøker");
            Console.WriteLine("2. Legg til en ny bok");
            Console.WriteLine("3. Avslutt");
            Console.Write("Ditt valg: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _view.Display(_model);
                    break;

                case "2":
                    AddBook();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen.");
                    break;

            }
        }
    }

    private void AddBook()
    {
        Console.Write("Tittel: ");
        string title = Console.ReadLine();

        Console.Write("År: ");
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("Ugyldig årstall.");
            return;
        }

        Console.Write("Sjanger: ");
        string genre = Console.ReadLine();

        _model.Books.Add(new Book { Title = title, Year = year, Genre = genre });
        Console.WriteLine("Boken er lagt til!");
    }
}
