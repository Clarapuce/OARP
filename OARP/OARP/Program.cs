﻿using System;
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
            PreferenceMat p = new PreferenceMat(2);
            AlgorithmeHongrois r = new AlgorithmeHongrois(p.Matrice);
            r.Lancer();
        }
    }
}
