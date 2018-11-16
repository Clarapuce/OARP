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
            Personne Jeremie = new OARP.Personne("Jeremie"); //Utilise constructeur
            Console.WriteLine(Jeremie.Message);
            Jeremie.Message = "Je suis une punaise";
            Console.WriteLine(Jeremie.Message);
            Jeremie.Parler();
        }
    }
}
