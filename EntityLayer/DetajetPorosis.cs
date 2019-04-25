using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class DetajetPorosis
    {
        private int detajet_Porosis_ID;
        private int porosia_ID;
        private int produkti_ID;
        private int sasia;
        private double zbritja;

        public int Porosia_ID
        {
            get { return porosia_ID; }
            set { porosia_ID = value; }
        }
        public double Zbritja
        {
            get { return zbritja; }
            set { zbritja = value; }
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

        public int Detajet_Porosis_ID
        {
            get { return detajet_Porosis_ID; }
            set { detajet_Porosis_ID = value; }
        }
    }
}
