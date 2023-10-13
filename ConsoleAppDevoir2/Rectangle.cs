using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDevoir2
{
    //TODO: 6 - la classe Rectangle doit hériter de la classe abstraire et implémenter l'unique interface dans le projet
    internal class Rectangle : Forme, ICalculable
    {
        public double Largeur { get; set; }
        public double Langueur { get; set; }

        //TODO: 7 - Ajouter le ou les constructeurs nécessaires pour la suite de programme
        public Rectangle() 
        {
            Largeur = 0.0;
            Langueur = 0.0;
        }
        public Rectangle(double largeur, double langueur, double x, double y)
        {
            Largeur = largeur;
            Langueur = langueur;
            this.x = x;
            this.y = y;
        }

        public new string ToString()
        {
            return "Rectangle:"+base.ToString() + $", Largeur:{Largeur}, Langueur:{Langueur} ";
        }

        //TODO: 8 - Implémenter la seule méthode abstraite de la classe Forme
        public override void AfficherInfos()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"La surface: {Surface()} et le périmètre: {Perimetre()}");
        }


        public double Perimetre()
        {
            return (Largeur + Langueur) * 2;
        }

        public double Surface()
        {
            return Langueur*Largeur;
        }
    }
}
