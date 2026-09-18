using Raktar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    internal class Program
    {
        static List<Csomag> csomagok=new List<Csomag>();    
        static void Main(string[] args)
        {
            csomagok.Add(new Hutott() { id=1,suly=2});
            csomagok.Add(new Hutott() { id = 2, suly = 1 });
            csomagok.Add(new Standard() { id = 3, suly = 3 });
            csomagok.Add(new Torekeny() { id = 4, suly = 4 });
            foreach (Csomag csomag in csomagok)
            {
                csomag.csomagolas();
            }

        }
    }
}
