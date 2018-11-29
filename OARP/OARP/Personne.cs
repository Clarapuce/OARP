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

        //CONSTRUCTEUR
        public Personne(string nom)
        {
            Nom = nom;
            Projets = new List<string>();
            Voeux = new List<int>();
        }

        public Personne(string nom, List<string> projet, List<int> voeux):this(nom)
        {
            Projets = projet;
            Voeux = voeux;
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
        
        public void AjouterVoeux(string projet, int rang)
        {
            Projets.Add(projet);Voeux.Add(rang);
        }
        public int RecupererVoeux(string projet)
        {
            int index = Projets.IndexOf(projet);
            return Voeux[index];
        }
    }
}
