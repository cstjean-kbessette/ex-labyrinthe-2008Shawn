namespace Labyrinthe
{
    internal class Controller
    {
        private Labyrinthe labyrinthe;
        private View view;
        public Controller(Labyrinthe labyrinthe, View view)
        {
            this.labyrinthe = labyrinthe;
            this.view = view;
        }
        public void Run()
        {
            while (!labyrinthe.IsExit())
            {
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                Console.WriteLine("Haut, bas, gauche ou droite (W-S-A-D)");
                char choix;
                while (true)
                {
                    try
                    {
                        choix = Convert.ToChar(Console.ReadLine());
                        if (choix == 'W' || choix == 'A' || choix == 'S' || choix == 'D')
                            break;
                        throw new Exception();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Entrer 'W' 'S' 'A' ou 'D')");
                    }
                }
                switch (choix)
                {
                    case 'W':
                        labyrinthe.MoveUp();
                        break;
                    case 'A':
                        labyrinthe.MoveLeft();
                        break;
                    case 'S':
                        labyrinthe.MoveDown();
                        break;
                    default:
                        labyrinthe.MoveRight();
                        break;
                }
            }
            view.AfficherVictoire();
        }
    }
}
