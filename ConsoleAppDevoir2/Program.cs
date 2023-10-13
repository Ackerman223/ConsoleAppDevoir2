using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDevoir2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: 9 - Déclarer une liste de formes
            List<Forme> listeFormes = new List<Forme>();


            Rectangle r1 = new Rectangle(5,10,12.5,12.5);
            Rectangle r2 = new Rectangle(7, 7, 0.5, 0.5);
            Losange l1=new Losange(6,3,8,5.25,10.75);
            Losange l2 = new Losange(6, 3, 8, 5.25, 10.75);

            //TODO: 10 - Ajouter ces objets à la  liste
            listeFormes.Add(r1);
            listeFormes.Add(r2);
            listeFormes.Add(l1);
            listeFormes.Add(l2);

            //TODO: 11 - Faire une boucle pour afficher toutes les informations par la méthode AfficherInfos
            foreach (Forme forme in listeFormes) 
            {
                forme.AfficherInfos();
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
