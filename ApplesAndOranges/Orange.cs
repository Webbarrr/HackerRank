using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndOranges
{
    public class Orange : Fruit
    {
        public override int[] FallenPositions { get; set; }
        public override int Location { get; set; }

        public Orange(int location)
        {
            this.Location = location;
        }
    }
}
