using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne e1 = new Personne("1");
            Personne e2 = new Personne("2");
            Personne e3 = new Personne("3");
            Personne vide=new Personne("");

            List<Personne> eleves = new List<Personne>();
            eleves.Add(vide);eleves.Add(e1); eleves.Add(e2); eleves.Add(e3);

            List<string> projets = new List<string>();
            projets.Add("A"); projets.Add("B"); projets.Add("C"); projets.Add("D");
            Repartition R = new Repartition(projets,eleves,1);
            e1.Projets.Add("A"); e1.Projets.Add("B");
            e1.Voeux.Add(4);e1.Voeux.Add(3);

            e2.Projets.Add("A"); e2.Projets.Add("C");
            e2.Voeux.Add(4); e2.Voeux.Add(3);

            e3.Projets.Add("A"); e3.Projets.Add("C"); e3.Projets.Add("B"); e3.Projets.Add("D");
            e3.Voeux.Add(4); e3.Voeux.Add(4); e3.Voeux.Add(4); e3.Voeux.Add(3);
            R.Repartir();
        }
    }
}
