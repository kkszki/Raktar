using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar.Models
{
    public class Standard:Csomag
    {
        public override void csomagolas()
        {
            Console.WriteLine("Kartondobozba kerül, standard ragasztással.");
        }
    }
}
