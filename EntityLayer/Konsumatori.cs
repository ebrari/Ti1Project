using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Konsumatori
    {
        private int konsumatori_ID;
        private string emri;
        private string mbiemri;
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

        public string Mbiemri
        {
            get { return mbiemri; }
            set { mbiemri = value; }
        }

        public string Emri
        {
            get { return emri; }
            set { emri = value; }
        }

        public int Konsumatori_ID
        {
            get { return konsumatori_ID; }
            set { konsumatori_ID = value; }
        }
    }
}
