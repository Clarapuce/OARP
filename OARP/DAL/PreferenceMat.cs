using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PreferenceMat
    {
        public int[][] Matrice { get; set; }
        public List<List<string>> Affinite { get; set; }
        public int NbMax { get; set; }
        public int NbMin { get; set; }
        public List<string> Eleves { get; set; }
        public List<String> Choix { get; set; }

        public PreferenceMat(int niveau)
        {
            Affinite = new List<List<string>>();
            if (niveau == 1)
            {
                Choix = new List<String>() { "Pommes", "Crepes", "Chocolat" };
                Console.Write("=");
                Eleves = new List<string>() { "Marianne Bouhet", "Antoine Conqui", "Cecilia Montaut" };
                Matrice = new int[3][] { new int[3]{ 1, 2, 3 }, new int[3] { 1, 3, 2 }, new int[3] { 2, 3, 1 } };
                Console.Write("=");
                Console.Write("Liste chargée : Trois élèves pour trois places");
                NbMax = 1;
                NbMin = 1;
            }
            else
            {
                if (niveau == 2)
                {
                    Choix = new List<String>() { "Pommes", "Crepes", "Chocolat" };
                    Console.Write("=");
                    Eleves = new List<string>() { "Marianne Bouhet",
                                                  "Antoine Conqui",
                                                  "Cecilia Montaut",
                                                  "Martin Filosa",
                                                  "Nicolas Narcisse",
                                                  "Eva Beziau",   };

                    Matrice = new int[6][] { new int[] { 2,2, 1,1, 3,3 }, new int[] { 3,3,2, 2,1,1 }, new int[] { 2,2, 1,1, 3,3 }, new int[] { 1,1,3, 3,2, 2 },
                        new int[]{ 1,1, 2,2, 1,1 }, new int[]{ 1,1,1, 1, 2,2 } };

                    Console.Write("=");
                    Console.Write("Liste chargée : Six élèves pour deux places");
                    NbMax = 2;
                    NbMin = 2;
                }

                else
                {
                    if (niveau == 3)
                    {
                        Choix = new List<String>() { "Pommes", "Crepes", "Chocolat", "Carot", "Coco" };
                        Console.Write("=");
                        Eleves = new List<string>() { "Marianne Bouhet",
                                                     "Antoine Conqui",
                                                     "Cecilia Montaut",
                                                     "Martin Filosa",
                                                     "Nicolas Narcisse",
                                                     "Eva Beziau",
                                                     "Adrien Metge",
                                                     "Enzo Constant",
                                                     "Lylia Fauvel",
                                                     "Juliette Sta"
                                                                  };
                        Matrice = new int[10][ ] {  new int[] { 2, 4, 3, 1, 0, },new int[] { 4, 4, 3, 0, 1,  },new int[] { 4, 1, 3, 4, 0,  },new int[]  { 4, 3, 2, 4, 0,  }, new int[]{ 0, 1, 2, 0, 0,  }
                         ,new int[] {  0, 1, 1, 0, 0,  }, new int[] { 1, 2, 1, 3, 3,  }, new int[] { 0, 1, 0, 4, 2,  },new int[]  { 3, 2, 2, 0, 1,  } ,new int[]  { 3, 1, 1, 0, 2,  }};

                        Console.Write("=");
                        Console.Write("Liste chargée : 10 élèves pour deux places");
                        NbMax = 2;
                        NbMin = 2;
                    }
                    else
                    {
                        if (niveau == 4)
                        {
                            Choix = new List<String>() { "Pommes", "Crepes", "Chocolat", "Carot", "Coco", "Cookie" };
                            Console.Write("=");
                            Eleves = new List<string>() { "Marianne Bouhet",
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
                            Matrice = new int[24][ ] {new int[] { 2, 4, 3, 1, 0, 3 },new int[] { 4, 4, 3, 0, 1, 2 },new int[] { 4, 1, 3, 4, 0, 2 },new int[] { 4, 3, 2, 4, 0, 1 },new int[] { 0, 1, 2, 0, 0, 1 }
                            ,new int[] { 0, 1, 1, 0, 0, 2 },new int[] { 1, 2, 1, 3, 3, 1 }, new int[] { 0, 1, 0, 4, 2, 3 },new int[] { 3, 2, 2, 0, 1,0 },new int[] { 3, 1, 1, 0, 2, 2 }, new int[] { 0, 1, 1, 0, 2, 3 }
                            ,new int[] { 2, 1, 2, 1, 1, 1 },new int[] { 0, 1, 1, 0, 0, 1 },new int[] { 1, 2, 1, 3, 2 ,0},new int[] { 4, 2, 3, 4, 1, 1 },new int[] { 2, 1, 2, 1, 1,0 },new int[] { 2, 1, 2, 0, 0 ,0}
                            ,new int[] { 4, 1, 2, 0, 0, 3 },new int[] { 1, 2, 3, 0, 0, 1 },new int[] { 4, 3, 3, 1, 2, 2 },new int[] { 4, 1, 3, 0, 0, 2 },new int[] { 4, 3, 1, 4, 2,0 },new int[] { 2, 2, 0, 1, 0, 0 }
                            ,new int[] { 1,2,3,4,5,6 }};

                            Console.Write("=");
                            Console.Write("Liste chargée : 24 élèves pour quatre places");
                            NbMax = 4;
                            NbMin = 4;
                        }
                        else
                        {
                            Choix = new List<String>() { "Pommes", "Crepes", "Chocolat", "Carot", "Coco", "Cookie" };
                            Console.Write("=");
                            Eleves = new List<string>() {"Marianne Bouhet",
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
                                                     "Clifford Christophe",
                                                     "Nin Franiatte"               };
                            Matrice = new int[25][] {new int[] { 2, 4, 3, 1,0, 3 },new int[] { 4, 4, 3,0, 1, 2 }, new int[] { 4, 1, 3, 4,0, 2 },new int[] { 4, 3, 2, 4,0, 1 }
                             ,new int[] {0, 1, 2,0,0, 1 },new int[] {0, 1, 1, 0,0,2 },new int[] { 1, 2, 1, 3, 3, 1 },new int[] {0, 1,0, 4, 2, 3 }, new int[] { 3, 2, 2,0, 1,0 },new int[] { 3, 1, 1,0, 2, 2 }
                            ,new int[] {0, 1, 1,0, 2, 3 },new int[] { 2, 1, 2, 1, 1, 1 },new int[] { 0,1, 1,0,0, 1 },new int[]  { 1, 2, 1, 3, 2 ,0},new int[] { 4, 2, 3, 4, 1, 1 },new int[] { 2, 1, 2, 1, 1 ,0}
                            ,new int[] { 2, 1, 2 ,0,0,0},new int[] { 4, 1, 2,0,0, 3 },new int[] { 1, 2, 3,0,0, 1 },new int[] { 4, 3, 3, 1, 2, 2 },new int[] { 4, 1, 3, 0,0,2 },new int[] { 4, 3, 1, 4, 2 ,0}
                            ,new int[] { 2, 2,0, 1,0,0 },new int[] { 0, 0, 0, 0, 0 ,0},new int[] { 2, 1, 1, 3, 2, 1 } };
                            Affinite.Add(new List<string>() { "Antoine Conqui", "Nicolas Narcisse" });
                            Console.Write("=");
                            Console.Write("Liste chargée : 25 élèves pour trois à cinq places");
                            NbMax = 5;
                            NbMin = 3;
                        }

                    }

                }
            }
            Console.WriteLine("");
        }
    }
}
