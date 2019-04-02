using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.VisualBasic.FileIO;
namespace Execution
{

    class CreerMatrice
    {
        public int[,] Matrice { get; set; }
        public string[] Eleves { get; set; }
        public string[] Projets { get; set; }
        public int Row { set; get; }
        public int Col { set; get; }
        
        public CreerMatrice()
        {
            Row = 20;
            Col = 10;
            Matrice  = new int[Row, Col];
            
            Eleves = new string[Row];//Parametres(@"./eleves.csv", Row);
            Projets = new string[Col];//Parametres(@"./projets.csv", Col);

            Lecture(Matrice);
            Matrice = DupliquerVoeux(2, Matrice);
        }
        public string[] Parametres(string chemin,int i)
        {
            TextFieldParser parser = new TextFieldParser(chemin);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            string[] fields= new string[i];
            int j = 0;
            while (j<i)
            {
                //Processing row
                fields = parser.ReadFields();
                j++;
            }
            return fields;
        }
        public void Lecture(int[,] matrice)
        {
            int i = 0;
            int j = 0;
            TextFieldParser parser = new TextFieldParser(@"./voeux.csv");
            parser.TextFieldType = FieldType.Delimited;
             parser.SetDelimiters(",");
            bool projets = true;
            int c = 0;
            while (!parser.EndOfData) 
            {
                //Processing row
                string[] fields = parser.ReadFields();
               
                foreach (string field in fields) 
                {
                    if((projets == true))
                    {
                        if(i!=0)
                        {
                            Projets[i-1] = field;
                            Console.WriteLine(field + "=>Projet");
                        }
                        i ++;
                        if (i == Col+1) { projets = false; i = 0; }
                    }
                    else
                    {
                        if (field != "")
                        {
                            if (i <= 10)
                            {
                                if (j == 0) { Projets[c] = field; c++; Console.WriteLine(field + "=>Eleves"); }
                                else { matrice[i, j] = int.Parse(field); Console.WriteLine(field + "=>Voeux"); }
                                if (j == matrice.GetUpperBound(1)) { j = 0; i++; }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                    }
                    
                }
             }
        }
        public void Afficher(int[,] m)
        {
            string ligne = "";
            for (int i = 0; i < m.GetUpperBound(0)+1; i++)
            {
                ligne += "|";
                for (int j = 0; j < m.GetUpperBound(1)+1; j++)
                {

                    ligne += " " + m[i,j] + " ";
                }
                ligne += "|\n";
            }
            Console.WriteLine(ligne);
        }

        int[,] DupliquerVoeux(int nbMax, int[,] m)
        {
            int row = m.GetUpperBound(0) + 1;
            int col = m.GetUpperBound(1) + 1;
            int index = 0;
            int[,] r = new int[row, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    for (int k = 0; k < nbMax; k++)
                    {
                        if (m[i, j] == 0)
                            { r[i, index] = 1000; }
                        else
                            { r[i, index] = m[i, j]; }
                        index = index + 1;
                    }

                }
                index = 0;
            }
            return r;
        }

    }
}
