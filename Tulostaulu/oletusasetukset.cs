using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulostaulu
{
    class oletusasetukset
    {
        private int neljanneksenPituus = 10;
        private int neljanneksienMaara = 4;
        private int jatkoajanPituus = 5;
        private Boolean kellonKayntisuuntaAlaspain = true;
        private int lyhytTauko = 2;
        private int pitkaTauko = 15;
        private int tauko = 2;
        private int aikalisa = 1;
        private int aikalisienLukumaara = 3;
        private int hyokkaysaika1 = 0;
        private int hyokkaysaika2 = 0;
        private int virheet = 5;
        private int pelikellonSummeri = 0;
        private int heittokellonSummeri = 0;


        public oletusasetukset(int neljanneksenPituus, int neljanneksienMaara, int jatkoajanPituus, Boolean kellonKayntisuuntaAlaspain, int lyhytTauko, int pitkaTauko, int tauko, int aikalisa, int aikalisienLukumaara, int hyokkaysaika1, int hyokkaysaika2, int virheet, int pelikellonSummeri, int heittokellonSummeri)
        {
            this.neljanneksenPituus = neljanneksenPituus;
            this.neljanneksienMaara = neljanneksienMaara;
            this.jatkoajanPituus = jatkoajanPituus;
            this.kellonKayntisuuntaAlaspain = kellonKayntisuuntaAlaspain;
            this.lyhytTauko = lyhytTauko;
            this.pitkaTauko = pitkaTauko;
            this.tauko = tauko;
            this.aikalisa = aikalisa;
            this.aikalisienLukumaara = aikalisienLukumaara;
            this.hyokkaysaika1 = hyokkaysaika1;
            this.hyokkaysaika2 = hyokkaysaika2;
            this.pelikellonSummeri = pelikellonSummeri;
            this.heittokellonSummeri = heittokellonSummeri;

        }
    }
}
