using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar.Models
{
    public class Hutott:Csomag
    {
        public override void csomagolas()
        {
            Console.WriteLine("Hőszigetelt dobozba kerül, jégakkuval.");
        }

    }
}
