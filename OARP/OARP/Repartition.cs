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
        public double Max { get; set; }
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
                    
                    //Condition d'arret de la recursivité : Si on a plus d'élèves à traiter en stock
                    Combinaison[indexP]=eleve;
                    if (index + 1 >= Eleves.Count())
                    {
                        
                        if (VerifierComplet())
                        {
                            CalculerNote();
                        }
                        Combinaison[indexP] = Eleves[0];
                    }
                    else
                    {
                        TesterCombinaison(Eleves[index + 1]);
                        Combinaison[indexP] = Eleves[0];
                    }
                }
                
            }

        }
        
        public void CalculerNote()
        {
            int somme = 0;
            List<double> notes = new List<double>();
            foreach(Personne e in Combinaison)
            {
                if(e!=Eleves[0])
                {
                    int place = Combinaison.IndexOf(e);
                    string projet = Projets[place];
                    int voeux = e.RecupererVoeux(projet);
                    somme += voeux;
                    notes.Add(voeux);
                }
                
            }
            double moyenne = Convert.ToDouble(somme) / (Eleves.Count() - 1);
            double s = CalculerEcartType(moyenne, notes);
            double note = somme -  s;
            
            if(note >= Max)
            {
                Console.WriteLine("Note = " + note);
                AfficherCombinaison();
                Max = note;
            }
            
            
        }
        
        public double CalculerEcartType(double moyenne,List<double> donnees)
        {
            double s = 0;
            foreach(int d in donnees)
            {
                s += Math.Pow((d - moyenne),2);
            }
            double n = donnees.Count();
            s = s / n;
            s = Math.Sqrt((n/(n-1))*s);
            s = Math.Round(s, 3);
            return s;
        }
        /*
         *double moyenne = Moyenne(t);
   double somme =0.0;
   for (int i=0; i<t.Length; i++) 
   {
    double delta = t[i] - moyenne;
    somme += delta*delta;
   }
   return Math.Sqrt(somme/(t.Length-1));
         */

        public void AfficherCombinaison()
        {
            string affichage = "";
            for(int i =0; i<Combinaison.Count();i++)
            {
                affichage += Projets[i]+" : "+Combinaison[i].Nom + "\n";
            }
            affichage += "====================================";
            Console.WriteLine(affichage);
        }

        public bool VerifierComplet()
        {
            foreach(Personne eleve in Eleves)
            {
                if(eleve!=Eleves[0])
                {

                    if (!Combinaison.Contains(eleve))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
