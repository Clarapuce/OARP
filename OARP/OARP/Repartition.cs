using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using M=MathNet.Numerics.SpecialFunctions;

namespace OARP
{
    class Repartition
    {
        //Paramètres de la répartition
        public int PlacesMax { get; set; }
        public int PlacesMin { get; set; }
        public int NbProjet { get; set; }
        public int Seuil { get; set; }
        public List<string> Projets { get; set; }
        public List<string> ListeProjets { get; set; }
        public List<List<int>> VoeuxEleves { get; set; }
        public List<string> Eleves { get; set; }
        public List<List<string>> Affinite { get; set; }
        //Liste des meilleurs combinaisons selon les modalités d'évaluation
        public List<List<int>> MeilleursCombiMoy { get; set; }
        public double MeilleureNoteMoy { get; set; }
        public List<List<int>> MeilleursCombiMax { get; set; }
        public double MeilleureNoteMax { get; set; }

        //Compteur et combinaison en cours
        public List<int> Combinaison { get; set; }
        public int N { get; set; }
        public double NbCombi {get;set;}

        //CONSTRUCTEURS
        public Repartition(Preference p)
        {
            Console.WriteLine("Initialisation de la répartition");
            PlacesMax = p.NbMax;
            PlacesMin = p.NbMin;
            NbProjet = p.Choix.Count();
            ListeProjets = p.Choix;
            Projets = new List<string>();
            Eleves = p.Eleves;
            Affinite = p.Affinite;
            VoeuxEleves = p.VoeuEleves;
            InitialiserProjets();

            Seuil = 0;

            MeilleursCombiMoy = new List<List<int>>();
            MeilleureNoteMoy = -1000;
            MeilleursCombiMax = new List<List<int>>();
            MeilleureNoteMax = -1000;

            N = 0;
            Combinaison = new List<int>();
            NbCombi =Math.Pow(6,Eleves.Count()/3);
            Console.WriteLine(NbCombi);
        }

        //INITIALISATION DES DONNEES
        public void InitialiserProjets()
        //On crée une liste avec autant de projet qu'il n'y a de places.
        {
           
            foreach (string p in ListeProjets)
            {
                for (int i = 0; i < PlacesMax; i++)
                {
                    Projets.Add(p);
                }
            }
            Projets.Sort();
            Console.WriteLine("Affichage des projets :");
            foreach (string p in Projets)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("======================================");
        }
        public void InitialiserCombinaison()
        //Fonction permettant, quand on a fini une combinaison, de remettre un espace vide à chaque espace
        {
            Combinaison.Clear();
            for (int i = 0; i < Projets.Count(); i++)
            {
                Combinaison.Add(-1);
            }

        }


        //ALGORITHME DE REPARTITION
        public void Commencer()
        {
            DateTime start = DateTime.Now;
            do
            {
                Seuil++;
                InitialiserCombinaison();
                TesterCombinaison(0);
                
            }
            while (MeilleursCombiMax.Count() == 0);
            
           
            //SupprimerDoublons();
            Console.WriteLine("=============MAX=============");
            foreach(List<int> combi in MeilleursCombiMax)
            {
                Console.WriteLine("Note : " + MeilleureNoteMax);
                AfficherCombinaison(combi);
                Console.WriteLine();
            }
            Console.WriteLine("=============MOY=============");
            foreach (List<int> combi in MeilleursCombiMoy)
            {
                Console.WriteLine("Note : " + MeilleureNoteMoy);
                AfficherCombinaison(combi);
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de combinaisons testées : "+N);
            Console.WriteLine("Seuil : " + Seuil);
            TimeSpan dur = DateTime.Now - start;
            Console.WriteLine("Temps : " + dur);
        }
        public void TesterCombinaison(int i)
        //Fonction recursive permettant de tester toutes les possibilités
        {
            
            
            foreach (string p in ListeProjets)
            {
                if (VoeuxEleves[i][ListeProjets.IndexOf(p)]!=0)
                {
                    //AfficherCombinaison(Combinaison);
                    int indexP = TrouverProjet(Projets.IndexOf(p));
                    if ((VerifierSeuil(i, p)) && (VerifierAffinite(i, p, indexP)))
                    {
                        if (indexP != -1)
                        {
                            Combinaison[indexP] = i;

                            if (VerifierEleves())
                            //Condition d'arret de la recursivité : Si on a plus d'élèves à traiter en stock
                            {
                                Chargement();
                                N++;
                                //Console.WriteLine("Tentative n° " + N);
                                if (VerifierProjetComplet())
                                {
                                    //AfficherCombinaison(Combinaison);
                                    ComparerNotes(Combinaison);
                                }
                                Combinaison[indexP] = -1;
                            }
                            else
                            {
                                TesterCombinaison(i+1);
                                Combinaison[indexP] = -1;
                            }
                        }
                    }
                

                }
            }
        }

        //EVALUATION
        public double CalculerNote(List<int> combinaison,int nature)
        {
            //0 pour moy, 1 pour max
            int somme = 0;
            List<double> notes = new List<double>();
            for(int i =0;i<Eleves.Count();i++)
            {
                if (combinaison[i] != -1)
                {
                    int place = combinaison.IndexOf(i);
                    string projet = Projets[place];
                    int j = ListeProjets.IndexOf(projet);
                    int voeux = VoeuxEleves[i][j];
                    somme += NbProjet - voeux;
                    notes.Add(voeux);
                }

            }
            double moyenne = Convert.ToDouble(somme) / (Eleves.Count() - 1);
            double s = CalculerEcartType(moyenne, notes);
            if(nature==0){ return somme / s; }
            else { return somme - s; }
        }
        public void ComparerNotes(List<int> c)
        {
            List<int> combinaison = new List<int>(c);
            double noteMoy = CalculerNote(combinaison, 0);
            double noteMax = CalculerNote(combinaison, 1);
            //Test si la note de la combinaison actuelle est plus grande que celles qu'on a déjà
            if (noteMoy >= MeilleureNoteMoy)
            {
                if (noteMoy != MeilleureNoteMoy)
                {
                    MeilleursCombiMoy.Clear();
                    MeilleureNoteMoy = noteMoy;
                }
                MeilleursCombiMoy.Add(combinaison);
            }
            if (noteMax >= MeilleureNoteMax)
            {
                
                if (noteMax != MeilleureNoteMax)
                {
                    MeilleursCombiMax.Clear();
                    
                    MeilleureNoteMax = noteMax;
                }
                MeilleursCombiMax.Add(combinaison);
            }
        }
        public double CalculerEcartType(double moyenne, List<double> donnees)
        {
            double s = 0;
            foreach (int d in donnees)
            {
                s += Math.Pow((d - moyenne), 2);
            }
            double n = donnees.Count();
            s = s / n;
            s = Math.Sqrt((n / (n - 1)) * s);
            s = Math.Round(s, 3);
            return s;
        }

        //IDENTIFICATIONS
        public int TrouverProjet(int indexP)
        {
            //Cherche l'emplacement nous interessant pour le projet concerné
            if(indexP!=-1)
            {
                if (Combinaison[indexP] != -1)
                {
                    int i = 0;
                    while ((i < PlacesMax) && (indexP + i < Projets.Count() - 1))
                    {
                        i++;
                        if ((Projets[indexP] == Projets[indexP + i]) && (Combinaison[indexP + i] == -1))
                        {

                            return indexP + i;
                        }
                    }
                }
                else { return indexP; }
            }
            return -1;
        }
        public string ProjetAssocie(int eleve)
        {
            return Projets[Combinaison.IndexOf(eleve)];
        }

        //VERIFICATIONS
        public bool VerifierEleves()
        {
            for(int i =0; i<Eleves.Count();i++)
            {
                if (!Combinaison.Contains(i))
                    {
                        return false;
                    }
            }
            return true;
        }

        public bool VerifierSeuil(int i, string voeu)
        {

            int niveauVoeu = VoeuxEleves[i][ListeProjets.IndexOf(voeu)];
            if (niveauVoeu > Seuil)
            {
                 return false;
            }
            return true;
        }

        public bool VerifierProjetComplet()
        { 
        //Verification que le projet, s'il n'est pas vide, est bel et bien complet
        int compteurEleve;
            for (int i = 0; i < Projets.Count() - 1;)
            {
                compteurEleve = 0;
                if (Combinaison[i] != -1)
                {
                    for (int k = 0; k < PlacesMax; k++)
                    {
                        if (Combinaison[i + k] != -1)
                        {
                            compteurEleve++;
                        }
                    }
                }
                i += PlacesMax;
                if ((compteurEleve < PlacesMin)&&(compteurEleve != 0))
                {
                    Console.WriteLine("ERREUR!PROJET NON VIDE INCOMPLET!");
                    return false;
                }
            }


            return true;
        }

        public bool VerifierAffinite(int i, string voeu,int index)
        {
            if(Affinite.Count!=0)
            {
                string eleve = Eleves[i];
                List<string> amis = new List<string>();
                int j = 0;
                while (amis.Count() == 0)
                {
                    if (Affinite[j].IndexOf(eleve) != -1)
                    {
                        amis = new List<string>(Affinite[j]);

                        j++;
                    }
                }
                foreach (string e in amis)
                {
                    int indexAmi = Eleves.IndexOf(e);

                    if (VoeuxEleves[indexAmi][index] == 0)
                    {

                        //Console.WriteLine("FAUX! LE VOEU EN QUESTION N'EST PAS RECIPROQUE");
                        return false;
                    }
                    else
                    {
                        if (TrouverProjet(index) == -1)
                        {
                            // Console.WriteLine("NUL! PLUS DE PLACE POUR LES AMIS DANS LE PROJET !!!");
                            return false;
                        }
                        else
                        {
                            if (Combinaison.Contains(i))
                            {
                                if (ProjetAssocie(indexAmi) != voeu)
                                { return false; }
                            }
                        }
                    }
                }
            }
            
            //Console.WriteLine("Ami : CHECK");
            return true;
        }

        //AFFICHAGE
        public void AfficherCombinaison(List<int> combi)
        {
            string affichage ="";
            int taille = combi.Count();
            for (int i = 0; i < taille; i++)
            {
                affichage += Projets[i] + " : ";
                if (combi[i] != -1)
                {
                    int indexProjet = ListeProjets.IndexOf(Projets[i]);
                    affichage += Eleves[combi[i]] + "(" + VoeuxEleves[combi[i]][indexProjet] + ")";
                }
                affichage += "\n";


            }
            affichage += "====================================";
            Console.WriteLine(affichage);
            /*
            string path = "C:/Users/Clarapuce/Desktop/ENSC/Transpromo/Resultats.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(affichage);
            }*/

        }

        //PRESENTATION DES RESULTATS
        public void SupprimerDoublons()

        {
            foreach(List<int> lMax in MeilleursCombiMax)
            {
               if(MeilleursCombiMoy.Contains(lMax))
                {
                    MeilleursCombiMoy.Remove(lMax);
                }
            }
        }

        public void Chargement()
        {
            double ratioFait = Math.Ceiling(N * 100 / NbCombi);
            double ratioPrecedent= Math.Ceiling((N-1) * 100 / NbCombi);
            if ((ratioFait>ratioPrecedent)||(N==1)||ratioFait<=100)
            {
                Console.Clear();
                Console.Write("Chargement : " + ratioFait + "%");

            }

        }
    }
}
