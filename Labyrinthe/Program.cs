namespace Labyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labyrinthe model = new Labyrinthe();
            View view = new View();
            Controller controller = new Controller(model, view); 
            controller.Run();
        }
    }
}
