using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Depo
    {
        private int depo_ID;
        private string adresa;

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }


        public int Depo_ID
        {
            get { return depo_ID; }
            set { depo_ID = value; }
        }

    }
}
