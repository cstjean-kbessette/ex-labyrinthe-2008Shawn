namespace Labyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labyrinthe labyrinthe = new Labyrinthe();
            View vue = new View();
            Controller controller = new Controller(labyrinthe, vue); 
            controller.Run();
        }
    }
}
