using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class ProduktetDepoLevizese
    {
        private int produktet_Depo_Levizje_ID;
        private int depo_Levizje_ID;
        private int depo_ID;
        private int produkti_ID;
        private int sasia;

        public int Depo_Levizje_ID
        {
            get { return depo_Levizje_ID; }
            set { depo_Levizje_ID = value; }
        }
        public int Sasia
        {
            get { return sasia; }
            set { sasia = value; }
        }
        public int Produkti_ID
        {
            get { return produkti_ID; }
            set { produkti_ID = value; }
        }

        public int Depo_ID
        {
            get { return depo_ID; }
            set { depo_ID = value; }
        }

        public int Produktet_Depo_Levizje_ID
        {
            get { return produktet_Depo_Levizje_ID; }
            set { produktet_Depo_Levizje_ID = value; }
        }

    }
}
