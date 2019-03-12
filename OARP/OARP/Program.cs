using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace OARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Preference p = new Preference(4);
            Repartition r = new Repartition(p);
            r.Commencer();
        }
    }
}
