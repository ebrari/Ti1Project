using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Produkti
    {
        private int produkti_ID;
        private int kategoria_ID;
        private int furnitori_ID;
        private string emri;
        private string prodhuesi;
        private string pershkrimi;
        private double cmimiBlerjes;
        private double cmimiShitjes;
        private DateTime dataSkadimit;
        private string barkodi;

        public string Barkodi
        {
            get { return barkodi; }
            set { barkodi = value; }
        }

        public DateTime DataSkadimit
        {
            get { return dataSkadimit; }
            set { dataSkadimit = value; }
        }

        public double CmimiShitjes
        {
            get { return cmimiShitjes; }
            set { cmimiShitjes = value; }
        }

        public double CmimiBlerjes
        {
            get { return cmimiBlerjes; }
            set { cmimiBlerjes = value; }
        }

        public string Pershkrimi
        {
            get { return pershkrimi; }
            set { pershkrimi = value; }
        }

        public string Prodhuesi
        {
            get { return prodhuesi; }
            set { prodhuesi = value; }
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

        public int Kategoria_ID
        {
            get { return kategoria_ID; }
            set { kategoria_ID = value; }
        }

        public int Produkti_ID
        {
            get { return produkti_ID; }
            set { produkti_ID = value; }
        }

    }
}
