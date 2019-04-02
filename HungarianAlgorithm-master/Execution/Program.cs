using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungarianAlgorithm;
namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Choix = new List<String>() { "Pommes", "Pommes", "Pommes", "Pommes", "Crepes", "Crepes", "Crepes", "Crepes",
                "Chocolat","Chocolat","Chocolat","Chocolat", "Carot","Carot","Carot","Carot", "Coco","Coco","Coco", "Coco", "Cookie", "Cookie", "Cookie", "Cookie" };
            List<String> Eleves = new List<string>() { "Marianne Bouhet",
                                                     "Antoine Conqui",
                                                     "Cecilia Montaut",
                                                     "Martin Filosa",
                                                     "Nicolas Narcisse",
                                                     "Eva Beziau",
                                                     "Adrien Metge",
                                                     "Enzo Constant",
                                                     "Lylia Fauvel",
                                                     "Juliette Sta",
                                                     "Nicolas Delcombel",
                                                     "Eugenie Saget",
                                                     "Quentin Perie",
                                                     "Maeva Andriantsoamberomanga",
                                                     "Celia Cavaillole",
                                                     "Andrea Toniutti",
                                                     "Maud Zak",
                                                     "Dorine Henry",
                                                     "Maurine Jouault",
                                                     "Nathan Trouvain",
                                                     "Luc Olivo",
                                                     "Pierrick Coissant",
                                                     "Marie Gibert",
                                                     "Clifford Christophe"};
            int[,]Matrice = new int[24,6] {  { 2, 4, 3, 1, 0, 3 },  { 4, 4, 3, 0, 1, 2 },  { 4, 1, 3, 4, 0, 2 },  { 4, 3, 2, 4, 0, 1 },  { 0, 1, 2, 0, 0, 1 }
                            ,  { 0, 1, 1, 0, 0, 2 },  { 1, 2, 1, 3, 3, 1 },   { 0, 1, 0, 4, 2, 3 },  { 3, 2, 2, 0, 1,0 },  { 3, 1, 1, 0, 2, 2 },   { 0, 1, 1, 0, 2, 3 }
                            ,  { 2, 1, 2, 1, 1, 1 },  { 0, 1, 1, 0, 0, 1 },  { 1, 2, 1, 3, 2 ,0},  { 4, 2, 3, 4, 1, 1 },  { 2, 1, 2, 1, 1,0 },  { 2, 1, 2, 0, 0 ,0}
                            ,  { 4, 1, 2, 0, 0, 3 },  { 1, 2, 3, 0, 0, 1 },  { 4, 3, 3, 1, 2, 2 },  { 4, 1, 3, 0, 0, 2 },  { 4, 3, 1, 4, 2,0 },  { 2, 2, 0, 1, 0, 0 }
                            ,  { 1,2,3,4,5,6 }};
            int NbMax = 4;
            int[,] costs=DupliquerVoeux(NbMax, Matrice);
            Matrice= DupliquerVoeux(NbMax, Matrice);

            int[] result = HungarianAlgorithm.HungarianAlgorithm.FindAssignments(costs);
            AfficherResultats(Choix, Eleves, result,Matrice);
            void AfficherResultats(List<string> c , List<string> e, int[] r,int[,] m)
            {
                string ligne = "";
                for (int i = 0; i < r.Length; i++)
                {
                    ligne += e[i] + " : ";
                    int index = r[i];
                    ligne += c[index] + " (";
                    ligne +=  m[i, r[i]]+")\n";
                }
                Console.WriteLine(ligne);
            }

            int[,] DupliquerVoeux(int nbMax, int[,] m)
            {
                int row = m.GetUpperBound(0)+1;
                int col = m.GetUpperBound(1)+1;
                int index = 0;
                int[,] r= new int[row,row];
                for(int i=0;i<row;i++)
                {
                    for(int j=0;j< col;j++)
                    {
                        for(int k =0;k<nbMax;k++)
                        {
                            if (m[i, j] == 0)
                            { r[i, index] = 1000; }
                            else { r[i, index] = m[i, j]; }
                            index = index + 1;
                        }
                        
                    }
                    index = 0;
                }
                return r;
            }
        }
    }
}
