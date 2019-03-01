using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;
namespace OARP
{
    class RepartitionOld
    {
        public List<string> Projets { get; set; }
        public List<Personne> Eleves { get; set; }
        public int PlacesMax { get; set; }
        public int PlacesMin { get; set; }
        public List<Personne> Combinaison { get; set; }
        public List<List<Personne>> MeilleursCombiMoy;
        public List<List<Personne>> MeilleursCombiMax;
        public List<List<Personne>> MeilleursCombiSeuil;
        public int Seuil { get; set; }
        public int NbProjet { get; set; }
        public int N { get; set; }
        public double Max { get; set; }
        //CONSTRUCTEURS
        public RepartitionOld(List<string> p, List<Personne> e,  int max )
        {
            Personne vide = new Personne("");
            Eleves = new List<Personne>() { vide};
            Eleves.AddRange(e);
            PlacesMax =max;
            PlacesMin = max;
            Combinaison = new List<Personne>();
            NbProjet = p.Count();
            InitialiserProjets(p);
            Seuil = 0;
            N = 0;
            MeilleursCombiMoy = new List<List<Personne>>() ;
            MeilleursCombiMax = new List<List<Personne>>();
            MeilleursCombiSeuil = new List<List<Personne>>();
        }

        public RepartitionOld(List<string> p, List<Personne> e,  int max,  int min) : this(p, e, max)
        {
            PlacesMin = min;
        }

        public RepartitionOld(List<string> p, List<Personne> e, int max, int min,  int seuil) : this(p, e, max, min)
        {
            Seuil = seuil;
        }

        //INITIALISATION DES DONNEES
        public void InitialiserProjets(List<string>projets)
            //On crée une liste avec autant de projet qu'il n'y a de places.
        {
            for(int j =0;j<NbProjet;j++)
            {
                for (int i = 1; i < PlacesMax; i++)
                {
                    projets.Add(projets[j]);
                }
            }
            projets.Sort();
            Projets = projets;
            Console.WriteLine("Affichage des projets :");
            foreach (string p in Projets)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("======================================");
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


        //REPARTITION
        public void Repartir()
        {
            //On met un élève vide dans chaque espace que devra prendre un elève dans la combinaison
            //ça permet de voir si un elève a déjà été mis à la place en question 
            for(int i = 0; i<Projets.Count();i++)
            {
                Combinaison.Add(Eleves[0]);
            }
            //TesterCombinaison(Eleves[1]);           
        }

        

        public void ReinitialiserCombinaison()
        //Fonction permettant, quand on a fini une combinaison, de remettre un espace vide à chaque espace
        {
            for(int i = 0; i<Projets.Count();i++)
            {
                Combinaison[i]=Eleves[0];
            }
            
        }

    
        //EVALUATION DE LA COMBINAISON
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
        
        public void AfficherCombinaison(double note)
        {
            string affichage = "Note = " + note+"\n";
            int taille = Combinaison.Count();
            for (int i = 0; i < taille ; i++)
            {
                affichage += Projets[i] + " : ";
                if (Combinaison[i]!=Eleves[0])
                {
                 affichage += Combinaison[i].Nom + "(" + Combinaison[i].RecupererVoeux(Projets[i]) + ")" ;
                }
                affichage += "\n";


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
                                //Console.WriteLine("J'ai supprimé parce que des âmes soeurs étaient séparées");
                                return false;
                            }
                        }
                    }
                    

                    if(!Combinaison.Contains(eleve))
                    {
                        //Console.WriteLine("J'ai supprimé parce qu'un pauvre élève n'a pu être placé nul part");
                        return false;
                    }
                    return VerifierSeuil(eleve);
                }
            }
            //Verification que le projet est bel et bien complet
            int compteurEleve;
            for (int i = 0; i < Projets.Count() - 1;)
            {
                compteurEleve = 0;
                if (Combinaison[i] != Eleves[0])
                {
                    for (int k = 0; k < PlacesMax; k++)
                    {
                        //Console.WriteLine("eleve : " + i + k);
                        if (Combinaison[i + k] != Eleves[0])
                        {
                            compteurEleve++;
                        }
                    }
                }
                i += PlacesMax;
                //Console.WriteLine("Compteur=" + compteurEleve);
                if (compteurEleve < PlacesMin)
                {

                    return false;
                }
            }
            
            
            return true;
        }//A scinder
        public bool VerifierSeuil(Personne eleve)
        {

            int voeux = eleve.RecupererVoeux(Projets[Combinaison.IndexOf(eleve)]);
            if (voeux < Seuil)
            {
                //Console.WriteLine("J'ai supprimé parce que c'était en dessous du seuil" + Seuil);
                return false;
            }
            return true;
        }
    }
}
