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

            List<Personne> eleves = new List<Personne>();
            eleves.Add(e1); eleves.Add(e2); eleves.Add(e3);

            List<string> projets = new List<string>();
            projets.Add("A"); projets.Add("B"); projets.Add("C"); projets.Add("D");
            Repartition R = new Repartition(projets,eleves);


            R.Voter();
        }
    }
}
