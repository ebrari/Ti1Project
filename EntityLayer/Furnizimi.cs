using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Furnizimi
    {

        private int furnizimi_ID;
        private int furnitori_ID;
        private DateTime dataPorosis;
        private DateTime dataPranimit;

        public DateTime DataPranimit
        {
            get { return dataPranimit; }
            set { dataPranimit = value; }
        }

        public DateTime DataPorosis
        {
            get { return dataPorosis; }
            set { dataPorosis = value; }
        }

        public int Furnizimi_ID
        {
            get { return furnizimi_ID; }
            set { furnizimi_ID = value; }
        }

        public int Furnitori_ID
        {
            get { return furnitori_ID; }
            set { furnitori_ID = value; }
        }
    }
}
