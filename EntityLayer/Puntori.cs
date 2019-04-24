using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Puntori
    {
        private int puntori_ID;
        private string emri;
        private string mbiemri;
        private bool gjinia;
        private string adresa;
        private string numriTelefonit;
        private DateTime dataLindjes;

        public DateTime DataLindjes
        {
            get { return dataLindjes; }
            set { dataLindjes = value; }
        }

        public bool Gjinia
        {
            get { return gjinia; }
            set { gjinia = value; }
        }

        public string Mbiemri
        {
            get { return mbiemri; }
            set { mbiemri = value; }
        }



        public string NumriTelefonit
        {
            get { return numriTelefonit; }
            set { numriTelefonit = value; }
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
        public int Puntori_ID
        {
            get { return puntori_ID; }
            set { puntori_ID = value; }
        }
    }
}
