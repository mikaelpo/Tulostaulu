using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulostaulu
{
    public class oletusasetukset
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


        public oletusasetukset(int neljanneksienMaara ,int neljanneksenPituus,  int jatkoajanPituus, Boolean kellonKayntisuuntaAlaspain, int lyhytTauko, int pitkaTauko, int tauko, int aikalisa, int aikalisienLukumaara, int hyokkaysaika1, int hyokkaysaika2, int virheet, int pelikellonSummeri, int heittokellonSummeri)
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
        public oletusasetukset()
        {

        }

        public int getNeljanneksenpituus(){
            return this.neljanneksenPituus;
        }

        public void setNeljanneksenpituus(int  neljanneksenPituus ){
            this.neljanneksenPituus = neljanneksenPituus ;
        }

        public int getNeljanneksienmaara(){
            return this.neljanneksienMaara;
        }

        public void setNeljanneksienmaara(int neljanneksienMaara){
            this.neljanneksienMaara = neljanneksienMaara;
        }

        public int getJatkoajanpituus() {
            return this.jatkoajanPituus;
        }

        public void setJatkoajanpituus(int jatkoajanPituus) {
            this.jatkoajanPituus = jatkoajanPituus;
        }

        public Boolean getKellonkayntisuuntaalaspain(){
            return this.kellonKayntisuuntaAlaspain;
        }

        public void setKellonkayntisuuntaalaspain(Boolean kellonKayntisuuntaAlaspain){
            this.kellonKayntisuuntaAlaspain = kellonKayntisuuntaAlaspain;
        }

        public int getLyhyttauko() {
            return this.lyhytTauko;
        }

        public void setLyhyttauko(int lyhytTauko){
            this.lyhytTauko = lyhytTauko;
        }

        public int gePitkatauko() {
            return this.pitkaTauko;
        }

        public void setPitkatauko(int pitkaTauko){
            this.pitkaTauko = pitkaTauko;
        }

        public int getTauko(){
            return this.tauko;
        }

        public void setTauko(int tauko){
            this.tauko = tauko;
        }

        public int getAikalisa(){
            return this.aikalisa;
        }

        public void setAikalisa(int aikalisa){
            this.aikalisa = aikalisa;
        }

        public int getAikalisienLukumaara(){
            return this.aikalisienLukumaara;
        }

        public void setAikalisienlukumaara(int aikalisienLukumaara){
            this.aikalisienLukumaara = aikalisienLukumaara;
        }

        public int getHyokkaysaika1(){
            return this.hyokkaysaika1;
        }

        public void setHyokkaysaika1(int hyokkaysaika1){
            this.hyokkaysaika1 = hyokkaysaika1;
        }

        public int getHyokkausaika2(){
            return this.hyokkaysaika2;
        }

        public void setHyokkausaika2(int hyokkaysaika2){
            this.hyokkaysaika2 = hyokkaysaika2;
        }

        public int getVirheet(){
            return this.virheet;
        }

        public void setVirheet(int virheet){
            this.virheet = virheet;
        }

        public int getPelikellonsummeri(){
            return this.pelikellonSummeri;
        }

        public void setPelikellonsummeri(int pelikellonSummeri){
            this.pelikellonSummeri= pelikellonSummeri;
        }

        public int getHeittokellonsummeri(){
            return this.heittokellonSummeri;
        }

        public void setHeittokellonsummeri(int heittokellonSummeri){
            this.heittokellonSummeri = heittokellonSummeri;
        }

    }
}
