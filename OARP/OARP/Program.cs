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

            List<string> plat = new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" };
        
            Personne lylfauvel= new Personne("lylfauvel", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 2, 3, 1, 1 });
            Personne mabadie= new Personne("mabadie", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 3, 2, 4, 1 });
            Personne lolivo= new Personne("lolivo", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 1, 2, 3 });
            Personne nnarcisse= new Personne("nnarcisse", new List<string>() { "Tartiflette", "Bolo", }, new List<int>() { 1, 1 });
            Personne ndelcombel= new Personne("ndelcombel", new List<string>() { "Tartiflette", "Bolo", }, new List<int>() { 1, 2 });
            Personne chugot= new Personne("chugot", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 2, 4, 3 });
            Personne mcloarec= new Personne("mcloarec", new List<string>() { "Tartiflette", "Bolo", "Salade", }, new List<int>() { 1, 2, 3, });
            Personne ebeziau= new Personne("ebeziau", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 2, 2, 3 });
            Personne hfournier= new Personne("hfournier", new List<string>() { "Tartiflette", "Bolo" }, new List<int>() { 1, 2, });
            Personne ycoussemacke= new Personne("ycoussemacke", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 3, 4, 2 });
            Personne dhenry= new Personne("dhenry", new List<string>() { "Tartiflette", "Curry" }, new List<int>() { 1, 2 });
            Personne mzak= new Personne("mzak", new List<string>() { "Tartiflette", "Curry" }, new List<int>() { 1, 2 });
            Personne aconquihell= new Personne("aconquihell", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 3, 4, 2 });
            Personne pcroissant= new Personne("pcroissant", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 3, 1, 2, 3 });
            Personne lvillette= new Personne("lvillette", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 2, 4, 3 });
            Personne msevilla= new Personne("msevilla", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 3, 4, 2 });

            List<Personne> eleves = new List<Personne>() { lylfauvel, mabadie, lolivo, nnarcisse, ndelcombel, chugot, mcloarec, ebeziau, hfournier, ycoussemacke, dhenry, mzak, aconquihell, pcroissant, lvillette, msevilla };
            //Affinités
            nnarcisse.Affinite.Add(lolivo);
            dhenry.Affinite.Add(mzak);
            Repartition R = new Repartition(plat, eleves, 4);
            R.Repartir();
        }
    }
}
