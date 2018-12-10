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

            
            Personne lylfauvel = new Personne("lylfauvel", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 2, 3, 1, 1 });
            Personne mabadie = new Personne("mabadie", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 3, 2, 4, 1 });
            Personne lolivo = new Personne("lolivo", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 1, 2, 3 });
            Personne nnarcisse = new Personne("nnarcisse", new List<string>() { "Tartiflette", "Bolo", }, new List<int>() { 1, 1 });
            Personne ndelcombel = new Personne("ndelcombel", new List<string>() { "Tartiflette", "Bolo", }, new List<int>() { 1, 2 });
            Personne chugot = new Personne("chugot", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 2, 4, 3 });
            Personne mcloarec = new Personne("mcloarec", new List<string>() { "Tartiflette", "Bolo", "Salade", }, new List<int>() { 1, 2, 3, });
            Personne ebeziau = new Personne("ebeziau", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 2, 2, 3 });
            Personne hfournier = new Personne("hfournier", new List<string>() { "Tartiflette", "Bolo" }, new List<int>() { 1, 2, });
            Personne ycoussemacke = new Personne("ycoussemacke", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 3, 4, 2 });
            Personne dhenry = new Personne("dhenry", new List<string>() { "Tartiflette", "Curry" }, new List<int>() { 1, 2 });
            Personne mzak = new Personne("mzak", new List<string>() { "Tartiflette", "Curry" }, new List<int>() { 1, 2 });
            Personne aconquihell = new Personne("aconquihell", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 3, 4, 2 });
            Personne pcroissant = new Personne("pcroissant", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 3, 1, 2, 3 });
            Personne lvillette = new Personne("lvillette", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 2, 4, 3 });
            Personne msevilla = new Personne("msevilla", new List<string>() { "Tartiflette", "Bolo", "Salade", "Curry" }, new List<int>() { 1, 3, 4, 2 });

            List<Personne> eleves = new List<Personne>() {  lylfauvel, mabadie, lolivo, nnarcisse, ndelcombel, chugot, mcloarec, ebeziau, hfournier, ycoussemacke, dhenry, mzak, aconquihell, pcroissant, lvillette, msevilla };
            //Affinités
            nnarcisse.Affinite.Add(lolivo);
            dhenry.Affinite.Add(mzak);
            List<String> plat = new List<String>() { "Tartiflette","Bolo","Salade","Curry"};
            Repartition R = new Repartition(plat, eleves, 4, 4);
            R.Repartir();
        }
    }
}
