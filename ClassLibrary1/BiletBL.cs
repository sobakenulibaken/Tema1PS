using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Layer
{   
        


   public  class BiletBL
    {
        public SpectacolBL spectacol { get; set; }
        public int rand { get; set; }
        public int loc { get; set; }

        public BiletBL( SpectacolBL spectacol, int rand, int loc ) {

            this.spectacol = spectacol;
            this.rand = rand;
            this.loc = loc;
        }
    }
}
