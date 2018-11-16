using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OARP
{
    class Personne
    {
        //PROPRIETE
        public string Nom { get; set; }
        public string Message { get; set; }


        //CONSTRUCTEUR
        public Personne(string nom)
        {
            Nom = nom;
            Message = "Je suis une chèvre";
        }

        //METHODES
        public void Parler()
        {
            Console.WriteLine( "Je parle !");
        }
    }
}
