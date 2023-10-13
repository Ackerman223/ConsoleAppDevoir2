using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDevoir2
{
    internal abstract class Forme
    {
        protected double x;
        protected double y;

        //TODO: 1 - Ajouter le ou les constructeurs nécessaires pour la suite de ce programme
        public Forme() 
        {
            x = 0.0;
            y = 0.0;
        }

        public Forme(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public new string ToString()
        {
            return $"Point central({x},{y})";
        }

        public abstract void AfficherInfos();

    }
}
