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

        public Repartition(List<string> p, List<Personne> e)
        {
            Projets = p;
            Eleves = e;
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
            List<Personne> combinaison = new List<Personne>(Eleves);
            
        }
        
        public void CalculerNote(List<Personne> configuration)
        {

        }
    }
}
