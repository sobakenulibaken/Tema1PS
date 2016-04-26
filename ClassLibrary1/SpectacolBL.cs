using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Layer
{   


   public class SpectacolBL
    {   

        public string titlu { get; set; }
        public string regie { get; set; }
        public string distributia { get; set; }
        public int nrBilete { get; set; }
        public DateTime dataPrimiera { get; set; }

        public SpectacolBL( string titlu, string regie, string distributia, int nrBilete,  DateTime dataPrimiera ) {

            this.titlu = titlu;
            this.regie = regie;
            this.distributia = distributia;
            this.nrBilete = nrBilete;
            this.dataPrimiera = dataPrimiera;
        
        }
        

    }
}
