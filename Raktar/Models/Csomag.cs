using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar.Models
{
    public abstract class Csomag
    {
        public int id;
        public int suly;

        public abstract void csomagolas();
    }
}
