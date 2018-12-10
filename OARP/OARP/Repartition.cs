using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OARP
{
    class Repartition
    {
        public List<string> Projets { get; set; }
        public List<Personne> Eleves { get; set; }
        public int NbPlaces { get; set; }
        public List<Personne> Combinaison { get; set; }
        public double Max { get; set; }
        public int Seuil { get; set; }
        public int NbProjet { get; set; }

        public Repartition(List<string> p, List<Personne> e, int nbplace, int nbprojet)
        {
            Personne vide = new Personne("");
            Eleves = new List<Personne>() { vide};
            Eleves.AddRange(e);
            NbPlaces = nbplace;
            Combinaison = new List<Personne>();
            NbProjet = nbprojet;
            InitialiserProjets(p);
            Seuil = 0;
        }

        public Repartition(List<string> p, List<Personne> e, int nbplace, int np, int seuil) : this(p, e, nbplace, np)
        {
            Seuil = seuil;
        }

        public void InitialiserProjets(List<string>projets)
        {
            for(int j =0;j<NbProjet+1;j++)
            {
                for (int i = 1; i < NbPlaces; i++)
                {
                    projets.Add(projets[j]);
                }
            }
            projets.Sort();
            Projets = projets;
            
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
                

                int indexP = Projets.IndexOf(p);
                //Comme va être automatiquement pris seulement le premier projet de la liste quand plusieurs projet sont en fait le même, on regarde si les autres sont libre
                if(Combinaison[indexP] != Eleves[0])
                {
                    
                    bool present = false;
                    int i=0;
                    while((present==false)&&(i<NbPlaces) && (indexP+i < Projets.Count()-1))
                    {
                        i++;
                        if ((Projets[indexP]==Projets[indexP+i])&&(Combinaison[indexP + i]==Eleves[0]))
                        {
                            
                            present = true;
                            indexP += i;
                        }
                    }
                }

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
                    somme += NbProjet - voeux;
                    notes.Add(voeux);
                }
                
            }
            double moyenne = Convert.ToDouble(somme) / (Eleves.Count() - 1);
            double s = CalculerEcartType(moyenne, notes);
            double note = somme -  s;
            
            if(note >= Max)
            {

                
                AfficherCombinaison(note);
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

        public void AfficherCombinaison(double note)
        {
            string affichage = "Note = " + note+"\n";
            int taille = Combinaison.Count();
            for (int i = 0; i < taille -1; i++)
            {
                if (Combinaison[i]!=Eleves[0])
                {
                   affichage +=Projets[i] + " : " + Combinaison[i].Nom + "(" + Combinaison[i].RecupererVoeux(Projets[i]) + ")" + "\n";
                }
                
                
            }
            affichage += "====================================";
            string path = "C:/Users/Clarapuce/Desktop/ENSC/Transpromo/Resultats.txt";
            Console.WriteLine(affichage);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(affichage);
            }

        }
        public bool VerifierComplet()
        {
            foreach (Personne eleve in Eleves)
            {
                if(eleve!=Eleves[0])
                {
                    if (eleve.Affinite.Count() != 0)
                    {
                        foreach(Personne e in eleve.Affinite)
                        {
                            if(Projets[Combinaison.IndexOf(e)]!=Projets[Combinaison.IndexOf(eleve)])
                            {
                                return false;
                            }
                        }
                    }
                    int voeux = eleve.RecupererVoeux(Projets[Combinaison.IndexOf(eleve)]);
                    if (voeux<Seuil)
                    {
                        
                        return false;
                    }

                    if (!Combinaison.Contains(eleve))
                    {
                        return false;
                    }
                }
            }
            //Attention à séparer mieux les tâches dans le prochain code
            for (int i = 0; i < Projets.Count() - 1; i++)
            {
                //Console.WriteLine(i);
                if (Combinaison[i] != Eleves[0])
                {
                    for (int k = 0; k < NbPlaces; k++)
                    {
                        if (Combinaison[i + k] == Eleves[0])
                        {
                            return false;
                        }
                    }
                }
                i += 3;

            }
            return true;
        }
    }
}
