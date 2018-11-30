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
            //List<string> roles = new List<string>() {"Lat"  ,"Alte"  ,"Shra"  ,"Rash"  ,"Velv"  ,"Popo"  ,"Tsi"  ,"Barag"  ,"Kip"
            //,"Tzia"  ,"Rosen"  ,"Lish"  ,"Angel"  ,"Moine"  ,"Psho" };

            //Personne Math = new Personne("Math", new List<string>() {"Kip","Lat","Moine" } ,new List<int>() { 15,14,13});
            //Personne Lea = new Personne("Lea", new List<string>() {"Tsi","Shra","Angel","Moine" }, new List<int>() {15,14,13,12 });
            //Personne Mc = new Personne("Mc", new List<string>() {"Shra","Tsi","Tzia","Lish"}, new List<int>() { 15,14,13,12});
            //Personne Sacha = new Personne("Sacha", new List<string>() {"Lish","Rosen","Psho","Angel" }, new List<int>() {15,14,13,12 });
            //Personne Youri = new Personne("Youri", roles, new List<int>() {15,14,14,14,14,14,14,14,14,14,14,14,14,14,14 });
            //Personne Alexandre = new Personne("Alexandre", roles, new List<int>() {15,15,15,15,15,15,15,15,15,15,15,15,15,15,15 });
            //Personne Seb = new Personne("Seb", roles, new List<int>() { 10, 10, 10, 10, 10, 10, 10, 11, 14, 10, 15, 14, 10, 13, 10 });

            //Personne Clara = new Personne("Clara", new List<string>() {"Lat"  ,"Alte" ,"Kip","Tzia"  ,"Rosen"  ,"Lish"  ,"Angel" }, new List<int>() {15,14,13,15,15,15,15 });
            //Personne Laetitia = new Personne("Laetitia", new List<string>() {"Rash","Barag","Psho","Popo","Velv","Angel" }, new List<int>() { 15, 14, 13, 12, 11, 10 });
            //Personne Celine = new Personne("Celine", new List<string>() {"Tzia","Kip","Lish","Psho","Alte" }, new List<int>() { 15,14,14,13,12});
            //Personne Quentin = new Personne("Quentin", new List<string>() { "Rosen","Lish","Angel","Popo"}, new List<int>() { 15,14,13,12});
            //Personne Nico = new Personne("Nico", new List<string>() {"Velv","Popo" }, new List<int>() { 15,15});
            //Personne Louis = new Personne("Louis", new List<string>() { "Lat", "Barag", "Moine", "Kip", "Rash", "Angel", "Alte", "Velv", "Popo", "Tsi", "Tzia", "Shra", "Rosen", "Lish", "Psho" }, new List<int>() {15,14,13,12,11,10,9,9,9,9,9,9,9,9,9 });
            //Personne Alize = new Personne("Alizé", new List<string>() {"Rash","Kip","Alte","Angel" }, new List<int>() {15,14,14,13 });
            //Personne Maia = new Personne("Maïa", new List<string>() {"Tsi","Tzia","Rosen","Lat","Lish","Kip","Shra" }, new List<int>() {15,15,15,15,15,14,4});
            //Personne vide = new Personne("");
            //List<Personne> eleves = new List<Personne>() {vide,Math,Lea,Mc,Sacha,Youri,Alexandre,Seb,Clara,Laetitia,Celine,Quentin,Nico,Louis,Alize,Maia};
            //Repartition R = new Repartition(roles, eleves, 1);

            ////Repartition plats
            //List<string> plats = new List<string>() { "Tartiflette","Tartiflette","Tartiflette","Tartiflette","Bolo","Bolo" ,"Bolo","Bolo","Salade","Salade","Salade","Salade","Curry","Curry","Curry","Curry"};
            //Personne Ribeiro = new Personne("Ribeiro", new List<string>() { "Tartiflette" ,"Bolo","Salade","Curry"}, new List<int>() { 3,3,2,4});
            //Personne Cavel = new Personne("Cavel", new List<string>() { "Tartiflette", "Bolo","Curry" }, new List<int>() { 4,3,2 });
            //Personne Marlier = new Personne("Marlier", new List<string>() { "Tartiflette", "Bolo", "Salade" }, new List<int>() { 3,4,2 });
            //Personne Montaut = new Personne("Montaut", new List<string>() { "Tartiflette", "Bolo" }, new List<int>() { 3, 4});
            //Personne Guidicelli = new Personne("Guidicelli", new List<string>() { "Tartiflette", "Bolo", "Salade","Curry" }, new List<int>() {4,3,2,1 });
            //Personne Perie = new Personne("Perie", new List<string>() { "Tartiflette", "Bolo", "Curry" }, new List<int>() { 4,2,3 });
            //Personne Randria = new Personne("Randria", new List<string>() { "Tartiflette", "Bolo", "Salade" }, new List<int>() { 3,2,4 });
            //Personne Cliff = new Personne("Cliff", new List<string>() { "Tartiflette", "Bolo",  "Curry" }, new List<int>() {4,4,3 });
            //Personne Math = new Personne("Math", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 3,2,4,1 });
            //Personne Emma = new Personne("Emma", new List<string>() {  "Bolo", "Salade", "Curry" }, new List<int>() { 2,4,3 });
            //Personne Katell = new Personne("Katell", new List<string>() { "Tartiflette", "Bolo" }, new List<int>() { 4,3 });
            //Personne Andrea = new Personne("Andrea", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 4, 2,1,3});
            //Personne Andriantso= new Personne("Andriantso", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 4, 3, 2, 1 });
            //Personne Morelle = new Personne("Morelle", new List<string>() { "Tartiflette", "Bolo", "Curry" }, new List<int>() { 4, 2,3 });
            //Personne Dut = new Personne("Dut", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 3, 2, 1 ,4});
            //Personne Loizel = new Personne("Loizel", new List<string>() { "Salade", "Curry" }, new List<int>() { 3,4});
            //Personne vide = new Personne("");
            //List<Personne> eleves = new List<Personne>() { vide, Ribeiro, Cavel, Marlier, Montaut, Guidicelli, Perie,Randria,Cliff,Math,Emma,Katell,Andrea,Andriantso,Morelle,Dut,Loizel };
            //Repartition R = new Repartition(plats, eleves, 4);

            ////Affinités
            //Katell.Affinite.Add(Emma);
            //Marlier.Affinite.Add(Cavel);
            //Ribeiro.Affinite.Add(Randria);
            //Cliff.Affinite.Add(Andrea);
            //R.Repartir();

            //Repartition desserts
            List<string> desserts = new List<string>() { "Tiramisu","Tiramisu","Tiramisu","Tiramisu","Browni", "Browni", "Browni", "Browni" ,"Carotte", "Carotte", "Carotte", "Carotte","Salade", "Salade", "Salade" ,"Salade" ,"Coco", "Coco", "Coco", "Coco" };
            Personne Ribeiro = new Personne("Ribeiro", new List<string>() { "Tiramisu", "Carotte", "Salade", "Coco" }, new List<int>() { 5,2,4,3 });
            Personne Cavel = new Personne("Cavel", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() { 4,5,3,2,5 });
            Personne Marlier = new Personne("Marlier", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade" }, new List<int>() { 3,5,4,2});
            Personne Montaut = new Personne("Montaut", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade" }, new List<int>() { 5,4,2,3});
            Personne Guidicelli = new Personne("Guidicelli", new List<string>() { "Tiramisu", "Browni", "Carotte", "Coco" }, new List<int>() { 5,2,4,3});
            Personne Perie = new Personne("Perie", new List<string>() {  "Browni", "Carotte" }, new List<int>() { 4, 5 });
            Personne Randria = new Personne("Randria", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() { 5,1,3,2,4 });
            Personne Cliff = new Personne("Cliff", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() { 5,5,4,4,5 });
            Personne Math = new Personne("Math", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() {5,4,3,2,1 });
            Personne Emma = new Personne("Emma", new List<string>() { "Tiramisu", "Browni",  "Salade", "Coco" }, new List<int>() { 2,3,5,4 });
            Personne Katell = new Personne("Katell", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade" }, new List<int>() { 5,4,5,4});
            Personne Andrea = new Personne("Andrea", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() {4,5,1,2,3});
            Personne Andriantso = new Personne("Andriantso", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() {5,4,1,3,2 });
            Personne Morelle = new Personne("Morelle", new List<string>() { "Tiramisu", "Browni",  "Salade", "Coco" }, new List<int>() {5,3,4,2 });
            Personne Dut = new Personne("Dut", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() { 4,5,3,2,1});
            Personne Loizel = new Personne("Loizel", new List<string>() { "Tiramisu", "Browni", "Carotte", "Salade", "Coco" }, new List<int>() { 4,3,5,1,2 });
            Personne vide = new Personne("");
            List<Personne> eleves = new List<Personne>() { vide, Ribeiro, Cavel, Marlier, Montaut, Guidicelli, Perie, Randria, Cliff, Math, Emma, Katell, Andrea, Andriantso, Morelle, Dut, Loizel };
            Repartition R = new Repartition(desserts, eleves, 4);

            //Affinités
            Katell.Affinite.Add(Emma);
            Marlier.Affinite.Add(Cavel);
            Ribeiro.Affinite.Add(Randria);
            Cliff.Affinite.Add(Andrea);
            R.Repartir();
        }
    }
}
