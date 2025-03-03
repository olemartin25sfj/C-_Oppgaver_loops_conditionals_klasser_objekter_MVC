namespace C__Oppgaver_loops_conditionals_klasser_objekter_MVC;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller(model, view);

        controller.Run();
    }
}
