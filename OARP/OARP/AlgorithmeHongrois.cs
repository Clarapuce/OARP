using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OARP
{
    class AlgorithmeHongrois
    {
        public int[][] Matrice { get; set; }
        public AlgorithmeHongrois(int[][] m)
        {
            Matrice = m;
            Afficher(Matrice);
        }
       public void Lancer()
        {
            ReduireMatrice(Matrice);
            int[][] inv = Inverser(Matrice);
            ReduireMatrice(inv);
            Matrice = Inverser(inv);
        }
        public void ReduireMatrice(int[][] m)
        {
            int min = 0;
            for (int i=0; i< m.Length ;i++)
            {
                min = m[i].Min();
                if(min>0)
                {
                    for (int j = 0; j < m[i].Length; j++)
                    {
                        m[i][j] -= min;
                    }
                }
            }
            
            
        }
        public int[][] Inverser(int[][] m)
        {
            int[][] inv = new int[m.Length][];
            int k = 0;
            for (int i = 0; i < m.Length; i++)
            {
                inv[i] = new int[m.Length];
                for (int j = 0; j < m[i].Length; j++)
                {
                    
                    k = m[j][i];
                    inv[i][j] = k;
                    
                }
            }

            return inv;
        }

        public void EncadrerBarrerZero()
        {

        }


        public void Afficher(int[][] m)
        {
            string ligne = "";
            for (int i =0; i< m.Length;i++)
            {
                ligne += "|";
                for (int j = 0; j < m[i].Length; j++)
                {
                    
                    ligne += " " + m[i][ j] + " ";
                }
                ligne += "|\n";
            }
            Console.WriteLine(ligne);
        }
    }
}
