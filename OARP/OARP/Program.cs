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
            //Personne e1 = new Personne("1");
            //Personne e2 = new Personne("2");
            //Personne e3 = new Personne("3");
            //Personne vide=new Personne("");

            //List<Personne> eleves = new List<Personne>();
            //eleves.Add(vide);eleves.Add(e1); eleves.Add(e2); eleves.Add(e3);

            //List<string> projets = new List<string>();
            //projets.Add("A"); projets.Add("B"); projets.Add("C"); projets.Add("D");
            //Repartition R = new Repartition(projets,eleves,1);
            //e1.Projets.Add("A");e1.Projets.Add("B");
            //e1.Voeux.Add(4);e1.Voeux.Add(3);

            //e2.Projets.Add("A"); e2.Projets.Add("C");
            //e2.Voeux.Add(4); e2.Voeux.Add(3);

            //e3.Projets.Add("A"); e3.Projets.Add("B"); e3.Projets.Add("C"); e3.Projets.Add("D");
            //e3.Voeux.Add(4); e3.Voeux.Add(4); e3.Voeux.Add(4); e3.Voeux.Add(3);
            //R.Repartir();
            List<string> roles = new List<string>();
            roles.Add("Lat"); roles.Add("Alte"); roles.Add("Shra"); roles.Add("Rash"); roles.Add("Velv"); roles.Add("Popo"); roles.Add("Tsi"); roles.Add("Barag"); roles.Add("Kip");
            roles.Add("Tzia"); roles.Add("Rosen"); roles.Add("Lish"); roles.Add("Angel"); roles.Add("Moine"); roles.Add("Psho");
            Personne Math = new Personne("Math");
            Personne Lea = new Personne("Lea");
            Personne Mc = new Personne("Mc");
            Personne Sacha = new Personne("Sacha");
            Personne Youri = new Personne("Youri");
            Personne Alexandre = new Personne("Alexandre");
            Personne Seb = new Personne("Seb");
            Personne Clara = new Personne("Clara");
            Personne Laetitia = new Personne("Laetitia");
            Personne Celine = new Personne("Celine");
            Personne Quentin = new Personne("Quentin");
            Personne Nico = new Personne("Nico");
            Personne Louis = new Personne("Louis");
            Personne Alizé = new Personne("Alizé");
            Personne Maïa = new Personne("Maïa");
            Personne vide = new Personne("");
            List<Personne> eleves = new List<Personne>();
            eleves.Add(Math); eleves.Add(Lea); eleves.Add(Mc); eleves.Add(Sacha); eleves.Add(Youri); eleves.Add(Alexandre); eleves.Add(Seb);
            eleves.Add(Clara); eleves.Add(Laetitia); eleves.Add(Celine); eleves.Add(Quentin); eleves.Add(Nico); eleves.Add(Louis); eleves.Add(Alizé);
            eleves.Add(Maïa);
            Repartition R = new Repartition(roles, eleves, 1);
            R.Voter();
            R.Repartir();
        }
    }
}
