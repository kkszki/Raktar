using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar.Models
{
    public class Torekeny: Csomag
    {
        public override void csomagolas()
        {
            Console.WriteLine("Buborékfóliába tekerik, majd ütésálló dobozba teszik.");
        }
    }
}
