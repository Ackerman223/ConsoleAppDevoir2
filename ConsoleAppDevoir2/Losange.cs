using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDevoir2
{
    //TODO: 2 - la classe Losange doit hériter de la classe abstraite et implémenter l'unique interface dans le projet
    internal class Losange : Forme, ICalculable
    {
        public double Cote { get; set; }
        public double PDiagonale {  get; set; }// Petite diagonale
        public double GDiagonale { get; set; }// Grande diagonale

        //TODO: 3 - Ajouter le ou les constructeurs nécessaires pour la suite de ce programme
        public Losange() 
        {
            Cote = 0;
            PDiagonale = 0;
            GDiagonale = 0;
        }
        public Losange (double cote, double pDiagonale, double gdiagonale, double x, double y)
        {
            Cote = cote;
            PDiagonale = pDiagonale;
            GDiagonale = gdiagonale;
            this.x = x;
            this.y = y;
        }


        //TODO: 4 - Redéfinir la méthode ToString pour qu'elle retourne les informations de cette classe
        public override string ToString()
        {
            return $"Losange: Côté({Cote}), Petite diagonale({PDiagonale}), Grande diagonale({GDiagonale}), Point central({x},{y})";
        }


        //TODO: 5 - Implémenter la méthode Périmètre. La formule est le côté fois quatre
        public double Perimetre() 
        {
            return 4 * Cote;
        }

        public double Surface()
        {
            return PDiagonale * GDiagonale / 2;
        }

        public override void AfficherInfos()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"La surface:{Surface()} et le périmètre:{Perimetre()}");

        }

        
    }
}
