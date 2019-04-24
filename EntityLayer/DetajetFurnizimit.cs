using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class DetajetFurnizimit
    {
        private int detajet_Furnizimit_ID;
        private int produkti_ID;
        private int furnizimi_ID;
        private int sasia;
        private double zbritja;


        public int Furnizimi_ID
        {
            get { return furnizimi_ID; }
            set { furnizimi_ID = value; }
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

        public int Detajet_Furnizimit_ID
        {
            get { return detajet_Furnizimit_ID; }
            set { detajet_Furnizimit_ID = value; }
        }

    }
}
