using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Furnitori
    {
        private int furnitori_ID;
        private string emri;
        private string adresa;
        private string numriBiznesor;
        private string numriTelefonit;

        public string NumriTelefonit
        {
            get { return numriTelefonit; }
            set { numriTelefonit = value; }
        }

        public string NumriBiznesor
        {
            get { return numriBiznesor; }
            set { numriBiznesor = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Emri
        {
            get { return emri; }
            set { emri = value; }
        }

        public int Furnitori_ID
        {
            get { return furnitori_ID; }
            set { furnitori_ID = value; }
        }

    }
}
