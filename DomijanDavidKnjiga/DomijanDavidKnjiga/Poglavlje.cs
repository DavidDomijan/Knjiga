using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomijanDavidKnjiga
{
    class Poglavlje
    {
        private string nazivPoglavlja;
        private int brojStranice,ukupanBrojStranica;

        public void setNazivPoglavlja(string imePoglavlja) {
            nazivPoglavlja = imePoglavlja;
        }

        public void setBrojStranice(int brojStranice)
        {
            this.brojStranice = brojStranice;
        }

        public void setUkupanBrojStranice(int ukupanBrojStranica)
        {
            this.ukupanBrojStranica = ukupanBrojStranica;
        }

        public string getNazivPoglavlja() {

            return nazivPoglavlja;
        }
        public int getBrojStranice() {

            return brojStranice;
        }
        public int getUkupanBrojStranica() {

            return ukupanBrojStranica;
        }
        //konstruktor
        public Poglavlje(string naziv, int broj) {
            nazivPoglavlja = naziv;
            brojStranice = broj;
        }
        public Poglavlje() {

        }
        //
    }
}
