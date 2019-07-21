using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndOranges
{
    public abstract class Fruit
    {
        public abstract int[] FallenPositions { get; set; }
        public abstract int Location { get; set; }
    }
}
