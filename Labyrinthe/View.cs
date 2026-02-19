using System.Data;

namespace Labyrinthe
{
    internal class View
    {
        public void AfficherLabyrinthe(Labyrinthe labyrinthe)
        {
            char[,] row = labyrinthe.Map;
            for (int i=0; i < labyrinthe.Map.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinthe.Map.GetLength(1); j++)
                { 
                    if (labyrinthe.posX == j && labyrinthe.posY  == i)
                        Console.Write('P');
                    else
                        Console.Write(row[i, j]);
                }
                    Console.WriteLine();
            }
                
        }
        public void AfficherEntete()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Bienvenue dans le Labyrinthe !");
            Console.WriteLine("Utilisez les flèches pour vous déplacer.");
            Console.WriteLine("Atteignez la sortie 'E' pour gagner !");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");
        }

        public void AfficherVictoire()
        {
            Console.Clear();
            Console.WriteLine("Félicitations ! Vous avez trouvé la sortie !");
            Console.WriteLine("Merci d'avoir joué !");
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
