using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Porosia
    {
        private int porosia_ID;
        private int konsumatori_ID;
        private int puntori_ID;
        private DateTime dataPorosis;
     

        public int Puntori_ID
        {
            get { return puntori_ID; }
            set { puntori_ID = value; }
        }

        public DateTime DataPorosis
        {
            get { return dataPorosis; }
            set { dataPorosis = value; }
        }

        public int Porosia_ID
        {
            get { return porosia_ID; }
            set { porosia_ID = value; }
        }

        public int Konsumatori_ID
        {
            get { return konsumatori_ID; }
            set { konsumatori_ID = value; }
        }
    }
}
