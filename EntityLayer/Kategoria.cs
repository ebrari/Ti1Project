using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Kategoria
    {
        private int kategoria_ID;
        private string kategori;

        public string Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }

        public int Kategoria_ID
        {
            get { return kategoria_ID; }
            set { kategoria_ID = value; }
        }

    }
}
