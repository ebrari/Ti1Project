using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class DepoLevizese
    {
        private int depo_Levizje_ID;
        private int puntori_ID;
        private DateTime dataMarrjes;
        private DateTime dataKthimit;

        public DateTime DataKthimit
        {
            get { return dataKthimit; }
            set { dataKthimit = value; }
        }

        public DateTime DataMarrjes
        {
            get { return dataMarrjes; }
            set { dataMarrjes = value; }
        }


        public int Puntori_ID
        {
            get { return puntori_ID; }
            set { puntori_ID = value; }
        }

        public int Depo_Levizje_ID
        {
            get { return depo_Levizje_ID; }
            set { depo_Levizje_ID = value; }
        }

    }
}
