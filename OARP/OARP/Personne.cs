using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OARP
{
    class Personne
    {
        //PROPRIETE
        public string Nom { get; set; }
        public List<string> Projets { get; set; }
        public List<int> Voeux { get; set; }
        List<Personne> Affinite { get; set; }
        string ProjetAssocie { get; set; }

        //CONSTRUCTEUR
        public Personne(string nom)
        {
            Nom = nom;
            Projets = new List<string>();
            Voeux = new List<int>();
        }

        //METHODES
        public void AfficherVoeux()
        {
            string affichage = "";
            foreach(string p in Projets)
            {
                affichage += "Projet : " + p+ " -- "+Voeux[Projets.IndexOf(p)]+"\n";
            }
            Console.WriteLine(affichage);
        }
        
    }
}
