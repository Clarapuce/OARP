using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OARP
{
    class Repartition
    {
        public List<string> Projets { get; set; }
        public List<Personne> Eleves { get; set; }
        public int NbPlaces{ get; set; }
        public List<Personne> Combinaison { get; set; }

        public Repartition(List<string> p, List<Personne> e,int nbplace)
        {
            Projets = p;
            Eleves = e;
            NbPlaces=nbplace;
            Combinaison = new List<Personne>();
        }
        
        public void Voter()
        {
            int voeux = 0;
            foreach(Personne p in Eleves)
            {
                Console.WriteLine(p.Nom + " : ");
                foreach (string projet in Projets)
                {
                    Console.Write("Classer le projet " + projet + " (0 si vous ne le voulez pas): ");
                    voeux = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    if(voeux !=0)
                    {
                        p.Projets.Add(projet);
                        p.Voeux.Add(voeux);
                        
                    }
                }
                p.AfficherVoeux();
            }
           
        }

        public void Repartir()
        {
            //On met un élève vide dans chaque espace que devra prendre un elève dans la combinaison
            //ça permet de voir si un elève a déjà été mis à la place en question 
            for(int i = 0; i<Projets.Count();i++)
            {
                Combinaison.Add(Eleves[0]);
            }
            CalculerNote();
            TesterCombinaison(Eleves[1]);           
        }

        public void ReinitialiserCombinaison()
        //Fonction permettant, quand on a fini une combinaison, de remettre un espace vide à chaque espace
        {
            for(int i = 0; i<Projets.Count();i++)
            {
                Combinaison[i]=Eleves[0];
            }
            
        }

        public void TesterCombinaison(Personne eleve)
        //Fonction recursive permettant de tester toutes les possibilités
        {
            int index = Eleves.IndexOf(eleve);
            foreach(string p in eleve.Projets)
            {
                int indexP= Projets.IndexOf(p);
                if(Combinaison[indexP]==Eleves[0])
                {
                    Combinaison[indexP]=eleve;
                }

                //Condition d'arret de la recursivité : Si on a plus d'élèves à traiter en stock
                if(index+1>=Eleves.Count())
                {
                    CalculerNote();
                    ReinitialiserCombinaison();
                    Console.WriteLine("===================");
                }
                else
                {
                    TesterCombinaison(Eleves[index + 1]);
                }
                

            }
        }
        
        public void CalculerNote()
        {
            AfficherCombinaison();
        }

        public void AfficherCombinaison()
        {
            string affichage = "";
            for(int i =0; i<Combinaison.Count();i++)
            {
                affichage += "Place " + i+" : "+Combinaison[i].Nom + "\n";
            }
            Console.WriteLine(affichage);
        }
    }
}
