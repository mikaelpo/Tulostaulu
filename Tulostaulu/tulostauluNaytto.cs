using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tulostaulu
{
    public partial class tulostauluNaytto : Form
    {
         
        private string[] lista;
        private string[] lista2;
        private string koti;
        private string vieras;
        private int pisteetKoti = 0;
        private int pisteetVieras = 0;
        private bool onkoTimeritKaytossa = false;

        private int pelaajaVirheK1, pelaajaVirheK2, pelaajaVirheK3, pelaajaVirheK4, pelaajaVirheK5, pelaajaVirheK6, pelaajaVirheK7, pelaajaVirheK8, pelaajaVirheK9
            , pelaajaVirheK10 , pelaajaVirheK11 , pelaajaVirheK12 , pelaajaVirheV1 , pelaajaVirheV2 , pelaajaVirheV3 , pelaajaVirheV4 , pelaajaVirheV5 , pelaajaVirheV6 
            , pelaajaVirheV7 , pelaajaVirheV8 , pelaajaVirheV9 , pelaajaVirheV10 , pelaajaVirheV11 , pelaajaVirheV12 = 0;
        private int virheetKoti = 0;
        private int virheetVieras = 0;
        private int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20,
            p21, p22, p23, p24 = 0;
        private int aikalisaKoti, aikalisaVieras = 0;

        private oletusasetukset at;
        private taulunOhjaus to;

        private int neljanneksenPituusMin = 0;
        private int neljanneksenPituusSek = 0;
        private int neljannes = 0;

        //ajastimen muuttujat
        int timeMs;
        int timeSs;
        int timeMm;
        bool isActive;

        bool odotusKelloKayntiin;
        int odotusKelloMin = 0;
        int odotusKelloSek = 0;

        //Aikalisä ajastin
        int timeAikalisaSek;
        bool aikalisaKaynnissa = false;

        Label vilkku = null;

        //Summeri 
        SoundPlayer summeri1 = new SoundPlayer(Tulostaulu.Properties.Resources.Buzzer);
        SoundPlayer summeri2 = new SoundPlayer(Tulostaulu.Properties.Resources.Air_Horn);

        public tulostauluNaytto(string[] listaKoti, string[] listaVieras, string kotiKuva, string vierasKuva, oletusasetukset at, taulunOhjaus to, bool odotusKelloKayntiin)
        {
            InitializeComponent();
            this.lista2 = listaVieras;
            this.lista = listaKoti;
            this.koti = kotiKuva;
            this.vieras = vierasKuva;
            this.at = at;
            this.to = to;
            this.odotusKelloKayntiin = odotusKelloKayntiin;

        }

        private void tulostauluNaytto_Load(object sender, EventArgs e)
        {

            //Punaiset reunukset pois näkyvistä
            pictureBoxViivaAla.Visible = false;
            pictureBoxViivaOikea.Visible = false;
            pictureBoxViivaVasen.Visible = false;
            pictureBoxViivaYla.Visible = false;

            //Kellon millisekunti labelit
            label9.Visible = false;
            labelMs.Visible = false;

            timeAikalisaSek = at.getAikalisa();

            //Pelikello
            isActive = false;
            if (odotusKelloKayntiin)
            {
                neljanneksenPituusMin = at.getNeljanneksenpituus();
                neljanneksenPituusSek = at.getNeljanneksenpituusSekunnit();
            }
            else
            {
                neljanneksenPituusMin = at.getNeljanneksenpituus();
                neljanneksenPituusSek = at.getNeljanneksenpituusSekunnit();
                resetTime();
                uusiNeljannes();
            }

            //Kotijoukkueen kuva
            pictureBox1.Image = new Bitmap(@koti);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //Vierasjoukkueen kuva
            pictureBox2.Image = new Bitmap(@vieras);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //Pelaajat
            
                label1.Text = lista[0];
                label2.Text = lista[1];
                label3.Text = lista[2];
                label6.Text = lista[3];
                label8.Text = lista[4];
                label10.Text = lista[5];
                label11.Text = lista[6];
                label12.Text = lista[7];
                label13.Text = lista[8];
                label14.Text = lista[9];
                label15.Text = lista[10];
                label16.Text = lista[11];
                label17.Text = lista2[0];
                label18.Text = lista2[1];
                label19.Text = lista2[2];
                label20.Text = lista2[3];
                label21.Text = lista2[4];
                label22.Text = lista2[5];
                label23.Text = lista2[6];
                label24.Text = lista2[7];
                label25.Text = lista2[8];
                label26.Text = lista2[9];
                label27.Text = lista2[10];
                label28.Text = lista2[11];
            

            labelAikalisaKello.Text = timeAikalisaSek.ToString();
            labelAikalisaKello.Visible = false;

            nollaaAikalisat();
            nollaaPisteet();
            nollaaVirheet();
        }
        public void nollaaAikalisat()
        {
            aikalisaKoti = 0;
            aikalisaVieras = 0;

            //Aikalisät
            ak1.Visible = false;
            ak2.Visible = false;
            ak3.Visible = false;
            av1.Visible = false;
            av2.Visible = false;
            av3.Visible = false;
        }
        
        public void nollaaPisteet()
        {
            
            pisteetKoti = 0;
            labelPisteKoti.Text = pisteetKoti.ToString();
            pisteetVieras = 0;
            labelPisteVieras.Text = pisteetVieras.ToString();
            
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
            p5 = 0;
            p6 = 0;
            p7 = 0;
            p8 = 0;
            p9 = 0;
            p10 = 0;
            p11 = 0;
            p12 = 0;
            p13 = 0;
            p14 = 0;
            p15 = 0;
            p16 = 0;
            p17 = 0;
            p18 = 0;
            p19 = 0;
            p20 = 0;
            p21 = 0;
            p22 = 0;
            p23 = 0;
            p24 = 0;
            //pelaajien pisteet pois näkyvistä 
            k1.Text = p1.ToString();
            k2.Text = p2.ToString();
            k3.Text = p3.ToString();
            k4.Text = p4.ToString();
            k5.Text = p5.ToString();
            k6.Text = p6.ToString();
            k7.Text = p7.ToString();
            k8.Text = p8.ToString();
            k9.Text = p9.ToString();
            k10.Text = p10.ToString();
            k11.Text = p11.ToString();
            k12.Text = p12.ToString();

            v1.Text = p13.ToString();
            v2.Text = p14.ToString();
            v3.Text = p15.ToString();
            v4.Text = p16.ToString();
            v5.Text = p17.ToString();
            v6.Text = p18.ToString();
            v7.Text = p19.ToString();
            v8.Text = p20.ToString();
            v9.Text = p21.ToString();
            v10.Text = p22.ToString();
            v11.Text = p23.ToString();
            v12.Text = p24.ToString();
        }

        public void nollaaJoukkueVirheet()
        {
            virheetKoti = 0;
            labelVirheetKoti.Text = virheetKoti.ToString();
            virheetVieras = 0;
            labelVirheetVieras.Text = virheetVieras.ToString();
        }
        public void nollaaVirheet()
        {
            
        
            pelaajaVirheK1 = 0;
            pelaajaVirheK2 = 0;
            pelaajaVirheK3 = 0;
            pelaajaVirheK4 = 0;
            pelaajaVirheK5 = 0;
            pelaajaVirheK6 = 0;
            pelaajaVirheK7 = 0;
            pelaajaVirheK8 = 0;
            pelaajaVirheK9 = 0;
            pelaajaVirheK10 = 0;
            pelaajaVirheK11 = 0;
            pelaajaVirheK12 = 0;
            pelaajaVirheV1 = 0;
            pelaajaVirheV2 = 0;
            pelaajaVirheV3 = 0;
            pelaajaVirheV4 = 0;
            pelaajaVirheV5 = 0;
            pelaajaVirheV6 = 0;
            pelaajaVirheV7 = 0;
            pelaajaVirheV8 = 0;
            pelaajaVirheV9 = 0;
            pelaajaVirheV10 = 0;
            pelaajaVirheV11 = 0;
            pelaajaVirheV12 = 0;

            virheetKoti = 0;
            labelVirheetKoti.Text = virheetKoti.ToString();
            virheetVieras = 0;
            labelVirheetVieras.Text = virheetVieras.ToString();          

            // ensimmäinen kotijoukkueen pelaaja
            vk1.Visible = false;
            vk2.Visible = false;
            vk3.Visible = false;
            vk4.Visible = false;
            vk5.Visible = false;

            // toinen kotijoukkueen pelaaja
            vk6.Visible = false;
            vk7.Visible = false;
            vk8.Visible = false;
            vk9.Visible = false;
            vk10.Visible = false;

            //kolmas kotijoukkueen pelaaja
            vk11.Visible = false;
            vk12.Visible = false;
            vk13.Visible = false;
            vk14.Visible = false;
            vk15.Visible = false;

            //neljäs kotijoukkueen pelaaja
            vk16.Visible = false;
            vk17.Visible = false;
            vk18.Visible = false;
            vk19.Visible = false;
            vk20.Visible = false;

            //viides kotijoukkueen pelaaja
            vk21.Visible = false;
            vk22.Visible = false;
            vk23.Visible = false;
            vk24.Visible = false;
            vk25.Visible = false;

            //kuudes kotijoukkueen pelaaja
            vk26.Visible = false;
            vk27.Visible = false;
            vk28.Visible = false;
            vk29.Visible = false;
            vk30.Visible = false;

            // seitsemäs kotijoukkueen pelaaja
            vk31.Visible = false;
            vk32.Visible = false;
            vk33.Visible = false;
            vk34.Visible = false;
            vk35.Visible = false;

            //kahdeksas kotijoukkueen pelaaja
            vk36.Visible = false;
            vk37.Visible = false;
            vk38.Visible = false;
            vk39.Visible = false;
            vk40.Visible = false;

            //yhdeksäs kotijoukkueen pelaaja
            vk41.Visible = false;
            vk42.Visible = false;
            vk43.Visible = false;
            vk44.Visible = false;
            vk45.Visible = false;

            //kymmenes kotijoukkueen pelaaja
            vk46.Visible = false;
            vk47.Visible = false;
            vk48.Visible = false;
            vk49.Visible = false;
            vk50.Visible = false;

            //yhdestoista kotijoukkueen pelaaja
            vk51.Visible = false;
            vk52.Visible = false;
            vk53.Visible = false;
            vk54.Visible = false;
            vk55.Visible = false;

            //kahdestoista kotijoukkueen pelaaja
            vk56.Visible = false;
            vk57.Visible = false;
            vk58.Visible = false;
            vk59.Visible = false;
            vk60.Visible = false;

            //ensimmäinen vierasjoukkueen pelaaja
            vv1.Visible = false;
            vv2.Visible = false;
            vv3.Visible = false;
            vv4.Visible = false;
            vv5.Visible = false;

            //toinen vierasjoukkueen pelaaja
            vv6.Visible = false;
            vv7.Visible = false;
            vv8.Visible = false;
            vv9.Visible = false;
            vv10.Visible = false;

            //kolmas vierasjoukkueen pelaaja
            vv11.Visible = false;
            vv12.Visible = false;
            vv13.Visible = false;
            vv14.Visible = false;
            vv15.Visible = false;

            //neljäs vierasjoukkueen pelaaja
            vv16.Visible = false;
            vv17.Visible = false;
            vv18.Visible = false;
            vv19.Visible = false;
            vv20.Visible = false;

            //viides vierasjoukkueen pelaaja
            vv21.Visible = false;
            vv22.Visible = false;
            vv23.Visible = false;
            vv24.Visible = false;
            vv25.Visible = false;

            //kuudes vierasjoukkueen pelaaja
            vv26.Visible = false;
            vv27.Visible = false;
            vv28.Visible = false;
            vv29.Visible = false;
            vv30.Visible = false;

            //seitsemäs vierasjoukkueen pelaaja
            vv31.Visible = false;
            vv32.Visible = false;
            vv33.Visible = false;
            vv34.Visible = false;
            vv35.Visible = false;

            //kahdeksas vierasjoukkueen pelaaja
            vv36.Visible = false;
            vv37.Visible = false;
            vv38.Visible = false;
            vv39.Visible = false;
            vv40.Visible = false;

            //yhdeksäs vierasjoukkueen pelaaja
            vv41.Visible = false;
            vv42.Visible = false;
            vv43.Visible = false;
            vv44.Visible = false;
            vv45.Visible = false;

            //kymmenes vierasjoukkueen pelaaja
            vv46.Visible = false;
            vv47.Visible = false;
            vv48.Visible = false;
            vv49.Visible = false;
            vv50.Visible = false;

            //yhdestoista vierasjoukkueen pelaaja
            vv51.Visible = false;
            vv52.Visible = false;
            vv53.Visible = false;
            vv54.Visible = false;
            vv55.Visible = false;

            //kahdestoista vierasjoukkueen pelaaja
            vv56.Visible = false;
            vv57.Visible = false;
            vv58.Visible = false;
            vv59.Visible = false;
            vv60.Visible = false;            
        }



        //Lisätään aikalisä kotijoukkueelle
        public void lisaaAikalisaKoti()
        {
            aikalisaKoti++;
            if (aikalisaKoti > 3) { aikalisaKoti = 3; }
            if (aikalisaKoti == 1) { ak1.Visible = true; }
            if (aikalisaKoti == 2) { ak2.Visible = true; }
            if (aikalisaKoti == 3) { ak3.Visible = true; }
            kaynnistaAikalisa();
        }
        //Vähennetään aikalisä kotijoukkueelta
        public void vahennaAikalisaKoti()
        {
            switch (aikalisaKoti)
            {
                case 1:
                    ak1.Visible = false;
                    break;
                case 2:
                    ak2.Visible = false;
                    break;
                case 3:
                    ak3.Visible = false;
                    break;
            }
            aikalisaKoti--;
            if (aikalisaKoti < 0) { aikalisaKoti = 0; }
            piilotaAikalisaKello();
        }
        //Lisätään aikalisä vierasjoukkueelle
        public void lisaaAikalisaVieras()
        {
            aikalisaVieras++;
            if (aikalisaVieras > 3) { aikalisaVieras = 3; }
            if (aikalisaVieras == 1) { av1.Visible = true; }
            if (aikalisaVieras == 2) { av2.Visible = true; }
            if (aikalisaVieras == 3) { av3.Visible = true; }
            kaynnistaAikalisa();
        }
        //Vahennetään aikalisä vierasjoukkueelta
        public void vahennaAikalisaVieras()
        {
            switch (aikalisaVieras)
            {
                case 1:
                    av1.Visible = false;
                    break;
                case 2:
                    av2.Visible = false;
                    break;
                case 3:
                    av3.Visible = false;
                    break;
            }
            aikalisaVieras--;
            if (aikalisaVieras < 0) { aikalisaVieras = 0; }
            piilotaAikalisaKello();
        }
        //Lisätään virhe kotijoukkueelle
        public void lisaaVirheKoti()
        {
            virheetKoti++;
            if (virheetKoti > 5)
            {
                virheetKoti = 5;
            }
            labelVirheetKoti.Text = virheetKoti.ToString();
        }
        //Vähennetään Virhe kotijoukkueelta
        public void vahennaVirheKoti()
        {
            virheetKoti--;
            if(virheetKoti < 0)
            {
                virheetKoti = 0;
            }
            labelVirheetKoti.Text = virheetKoti.ToString();
        }

        //Lisätään virhe kotijoukkueelle
        public void lisaaVirheVieras()
        {
            virheetVieras++;
            if (virheetVieras > 5)
            {
                virheetVieras = 5;
            }
            labelVirheetVieras.Text = virheetVieras.ToString();
        }
        //Vähennetään Virhe kotijoukkueelta
        public void vahennaVirheVieras()
        {
            virheetVieras--;
            if (virheetVieras < 0)
            {
                virheetVieras = 0;
            }
            labelVirheetVieras.Text = virheetVieras.ToString();
        }


        //Vilkutetaan virhe-labelia timer2 ja timer3 avulla
        public void vilkutaLabel(Label l)
        {
            onkoTimeritKaytossa = true;
            timer2.Start();
            timer3.Start();
            vilkku = l;
        }
        //Virhe labelin vilkutus
        public void timer2_Tick(object sender, EventArgs e)
        {
            if (vilkku.ForeColor == Color.Black)
                vilkku.ForeColor = Color.Red;
            else
                vilkku.ForeColor = Color.Black;
        }
        //Katsotaan kun virhe-labelia on vilkutettu tarpeeksi pitkään
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            vilkku.ForeColor = Color.Red;
            onkoTimeritKaytossa = false;
        }

        
        //Kotijoukkueen pelaajien virheen lisäystä
        public int lisaaVirheKotiPelaaja(int i, Label a, Label b, Label c, Label d, Label f, bool vainPelaajaVirhe)
        {
            
            if (i > 5) { i = 5; }
            if (i == 1) { a.Visible = true; }
            if (i == 2) { b.Visible = true; }
            if (i == 3) { c.Visible = true; }
            if (i == 4) { d.Visible = true; }
            if (i == 5) { f.Visible = true; if (onkoTimeritKaytossa == false) { vilkutaLabel(f); }  }

            if (vainPelaajaVirhe == false) { lisaaVirheKoti(); }
            return i;
        }

        //Kotijoukkueen pelaajien virheen vähennystä
        public int vahennaVirheKotiPelaaja(int i, Label a, Label b, Label c, Label d, Label f, bool vainPelaajaVirhe)
        {
            switch (i)
            {
                case 1:
                    a.Visible = false;
                    break;
                case 2:
                    b.Visible = false;
                    break;
                case 3:
                    c.Visible = false;
                    break;
                case 4:
                    d.Visible = false;
                    break;
                case 5:
                    f.Visible = false;
                    break;
            }
            i--;
            if (i < 0) { i = 0; }
            if (vainPelaajaVirhe == false) { vahennaVirheKoti(); }
            return i;          
        }

        //Vierasjoukkueen pelaajien virheen lisäystä
        public int lisaaVirheVierasPelaaja(int i, Label a, Label b, Label c, Label d, Label f, bool vainPelaajaVirhe)
        {

            if (i > 5) { i = 5; }
            if (i == 1) { a.Visible = true; }
            if (i == 2) { b.Visible = true; }
            if (i == 3) { c.Visible = true; }
            if (i == 4) { d.Visible = true; }
            if (i == 5) { f.Visible = true; if (onkoTimeritKaytossa == false) { vilkutaLabel(f); } }

            if (vainPelaajaVirhe == false) { lisaaVirheVieras(); }
            return i;
        }

        //Vierasjoukkueen pelaajien virheen vähennystä
        public int vahennaVirheVierasPelaaja(int i, Label a, Label b, Label c, Label d, Label f, bool vainPelaajaVirhe)
        {
            switch (i)
            {
                case 1:
                    a.Visible = false;
                    break;
                case 2:
                    b.Visible = false;
                    break;
                case 3:
                    c.Visible = false;
                    break;
                case 4:
                    d.Visible = false;
                    break;
                case 5:
                    f.Visible = false;
                    break;
            }
            i--;
            if (i < 0) { i = 0; }
            if (vainPelaajaVirhe == false) { vahennaVirheVieras(); }
            return i;
        }
        //Virheet
        //Kotipelaaja 1
        public void lisaaVirheKoti1(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK1++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK1, vk1, vk2, vk3, vk4, vk5, vainPelaajaVirhe);
            pelaajaVirheK1 = i;
        }
        public void vahennaVirheKoti1(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK1, vk1, vk2, vk3, vk4, vk5, vainPelaajaVirhe);
            pelaajaVirheK1 = i;

        }
        //Kotipelaaja 2
        public void lisaaVirheKoti2(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK2++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK2, vk6, vk7, vk8, vk9, vk10, vainPelaajaVirhe);
            pelaajaVirheK2 = i;
        }       
        public void vahennaVirheKoti2(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK2, vk6, vk7, vk8, vk9, vk10, vainPelaajaVirhe);
            pelaajaVirheK2 = i;
        }

        //Kotipelaaja 3
        public void lisaaVirheKoti3(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK3++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK3, vk11, vk12, vk13, vk14, vk15, vainPelaajaVirhe);
            pelaajaVirheK3 = i;
        }
        public void vahennaVirheKoti3(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK3, vk11, vk12, vk13, vk14, vk15, vainPelaajaVirhe);
            pelaajaVirheK3 = i;
        }

        //Kotipelaaja 4
        public void lisaaVirheKoti4(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK4++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK4, vk16, vk17, vk18, vk19, vk20, vainPelaajaVirhe);
            pelaajaVirheK4 = i;
        }
        public void vahennaVirheKoti4(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK4, vk16, vk17, vk18, vk19, vk20, vainPelaajaVirhe);
            pelaajaVirheK4 = i;
        }

        //Kotipelaaja 5
        public void lisaaVirheKoti5(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK5++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK5, vk21, vk22, vk23, vk24, vk25, vainPelaajaVirhe);
            pelaajaVirheK5 = i;
        }
        public void vahennaVirheKoti5(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK5, vk21, vk22, vk23, vk24, vk25, vainPelaajaVirhe);
            pelaajaVirheK5 = i;
        }

        //Kotipelaaja 6
        public void lisaaVirheKoti6(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK6++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK6, vk26, vk27, vk28, vk29, vk30, vainPelaajaVirhe);
            pelaajaVirheK6 = i;
        }
        public void vahennaVirheKoti6(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK6, vk26, vk27, vk28, vk29, vk30, vainPelaajaVirhe);
            pelaajaVirheK6 = i;
        }

        //Kotipelaaja 7
        public void lisaaVirheKoti7(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK7++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK7, vk31, vk32, vk33, vk34, vk35, vainPelaajaVirhe);
            pelaajaVirheK7 = i;
        }
        public void vahennaVirheKoti7(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK7, vk31, vk32, vk33, vk34, vk35, vainPelaajaVirhe);
            pelaajaVirheK7 = i;
        }

        //Kotipelaaja 8
        public void lisaaVirheKoti8(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK8++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK8, vk36, vk37, vk38, vk39, vk40, vainPelaajaVirhe);
            pelaajaVirheK8 = i;
        }
        public void vahennaVirheKoti8(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK8, vk36, vk37, vk38, vk39, vk40, vainPelaajaVirhe);
            pelaajaVirheK8 = i;
        }

        //Kotipelaaja 9
        public void lisaaVirheKoti9(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK9++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK9, vk41, vk42, vk43, vk44, vk45, vainPelaajaVirhe);
            pelaajaVirheK9 = i;
        }
        public void vahennaVirheKoti9(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK9, vk41, vk42, vk43, vk44, vk45, vainPelaajaVirhe);
            pelaajaVirheK9 = i;
        }
        
        //Kotipelaaja 10
        public void lisaaVirheKoti10(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK10++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK10, vk46, vk47, vk48, vk49, vk50, vainPelaajaVirhe);
            pelaajaVirheK10 = i;
        }
        public void vahennaVirheKoti10(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK10, vk46, vk47, vk48, vk49, vk50, vainPelaajaVirhe);
            pelaajaVirheK10 = i;
        }
    
        //Kotipelaaja 11
        public void lisaaVirheKoti11(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK11++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK11, vk51, vk52, vk53, vk54, vk55, vainPelaajaVirhe);
            pelaajaVirheK11 = i;
        }
        public void vahennaVirheKoti11(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK11, vk51, vk52, vk53, vk54, vk55, vainPelaajaVirhe);
            pelaajaVirheK11 = i;
        }

        //Kotipelaaja 12
        public void lisaaVirheKoti12(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheK12++;
            i = lisaaVirheKotiPelaaja(pelaajaVirheK12, vk56, vk57, vk58, vk59, vk60, vainPelaajaVirhe);
            pelaajaVirheK12 = i;
        }
        public void vahennaVirheKoti12(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheKotiPelaaja(pelaajaVirheK12, vk56, vk57, vk58, vk59, vk60, vainPelaajaVirhe);
            pelaajaVirheK12 = i;
        }

        //Virheet vierasjoukkueen pelaajat
        //Pelaaja 1
        public void lisaaVirheVieras1(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV1++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV1, vv1, vv2, vv3, vv4, vv5, vainPelaajaVirhe);
            pelaajaVirheV1 = i;
        }
        public void vahennaVirheVieras1(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV1, vv1, vv2, vv3, vv4, vv5, vainPelaajaVirhe);
            pelaajaVirheV1 = i;
        }

        //Pelaaja 2
        public void lisaaVirheVieras2(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV2++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV2, vv6, vv7, vv8, vv9, vv10, vainPelaajaVirhe);
            pelaajaVirheV2 = i;
        }
        public void vahennaVirheVieras2(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV2, vv6, vv7, vv8, vv9, vv10, vainPelaajaVirhe);
            pelaajaVirheV2 = i;
        }

        //Pelaaja 3
        public void lisaaVirheVieras3(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV3++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV3, vv11, vv12, vv13, vv14, vv15, vainPelaajaVirhe);
            pelaajaVirheV3 = i;
        }
        public void vahennaVirheVieras3(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV3, vv11, vv12, vv13, vv14, vv15, vainPelaajaVirhe);
            pelaajaVirheV3 = i;
        }

        //Pelaaja 4
        public void lisaaVirheVieras4(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV4++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV4, vv16, vv17, vv18, vv19, vv20, vainPelaajaVirhe);
            pelaajaVirheV4 = i;
        }
        public void vahennaVirheVieras4(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV4, vv16, vv17, vv18, vv19, vv20, vainPelaajaVirhe);
            pelaajaVirheV4 = i;
        }

        //Pelaaja 5
        public void lisaaVirheVieras5(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV5++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV5, vv21, vv22, vv23, vv24, vv25, vainPelaajaVirhe);
            pelaajaVirheV5 = i;
        }
        public void vahennaVirheVieras5(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV5, vv21, vv22, vv23, vv24, vv25, vainPelaajaVirhe);
            pelaajaVirheV5 = i;
        }

        //Pelaaja 6
        public void lisaaVirheVieras6(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV6++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV6, vv26, vv27, vv28, vv29, vv30, vainPelaajaVirhe);
            pelaajaVirheV6 = i;
        }
        public void vahennaVirheVieras6(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV6, vv26, vv27, vv28, vv29, vv30, vainPelaajaVirhe);
            pelaajaVirheV6 = i;
        }

        //Pelaaja 7
        public void lisaaVirheVieras7(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV7++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV7, vv31, vv32, vv33, vv34, vv35, vainPelaajaVirhe);
            pelaajaVirheV7 = i;
        }
        public void vahennaVirheVieras7(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV7, vv31, vv32, vv33, vv34, vv35, vainPelaajaVirhe);
            pelaajaVirheV7 = i;
        }

        //Pelaaja 8
        public void lisaaVirheVieras8(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV8++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV8, vv36, vv37, vv38, vv39, vv40, vainPelaajaVirhe);
            pelaajaVirheV8 = i;
        }
        public void vahennaVirheVieras8(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV8, vv36, vv37, vv38, vv39, vv40, vainPelaajaVirhe);
            pelaajaVirheV8 = i;
        }

        //Pelaaja 9
        public void lisaaVirheVieras9(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV9++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV9, vv41, vv42, vv43, vv44, vv45, vainPelaajaVirhe);
            pelaajaVirheV9 = i;
        }
        public void vahennaVirheVieras9(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV9, vv41, vv42, vv43, vv44, vv45, vainPelaajaVirhe);
            pelaajaVirheV9 = i;
        }
    
        //Pelaaja 10
        public void lisaaVirheVieras10(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV10++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV10, vv46, vv47, vv48, vv49, vv50, vainPelaajaVirhe);
            pelaajaVirheV10 = i;
        }
        public void vahennaVirheVieras10(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV10, vv46, vv47, vv48, vv49, vv50, vainPelaajaVirhe);
            pelaajaVirheV10 = i;
        }

        //Pelaaja 11
        public void lisaaVirheVieras11(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV11++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV11, vv51, vv52, vv53, vv54, vv55, vainPelaajaVirhe);
            pelaajaVirheV11 = i;
        }
        public void vahennaVirheVieras11(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV11, vv51, vv52, vv53, vv54, vv55, vainPelaajaVirhe);
            pelaajaVirheV11 = i;
        }

        //Pelaaja 12
        public void lisaaVirheVieras12(bool vainPelaajaVirhe)
        {
            int i = 0;
            pelaajaVirheV12++;
            i = lisaaVirheVierasPelaaja(pelaajaVirheV12, vv56, vv57, vv58, vv59, vv60, vainPelaajaVirhe);
            pelaajaVirheV12 = i;
        }
        public void vahennaVirheVieras12(bool vainPelaajaVirhe)
        {
            int i = 0;
            i = vahennaVirheVierasPelaaja(pelaajaVirheV12, vv56, vv57, vv58, vv59, vv60, vainPelaajaVirhe);
            pelaajaVirheV12 = i;
        }



        //Pisteiden lisäystä/poistoa ohjaustaulun kautta
        //Kotijoukkueen pisteiden lisäys ja vähennys
        public void lisaaPisteKotijoukkue()
        {
            pisteetKoti++;
            labelPisteKoti.Text = pisteetKoti.ToString();
        }
        public void vahennaPisteKotijoukkue()
        {
            pisteetKoti--;
            if(pisteetKoti < 0)
            {
                pisteetKoti = 0;
            }
            labelPisteKoti.Text = pisteetKoti.ToString();
        }
        //Vierasjoukkueen pisteiden lisäys ja vähennys
        public void lisaaPisteVierasjoukkue()
        {
            pisteetVieras++;
            labelPisteVieras.Text = pisteetVieras.ToString();
        }
        public void vahennaPisteVierasjoukkue()
        {
            pisteetVieras--;
            if (pisteetVieras < 0)
            {
                pisteetVieras = 0;
            }
            labelPisteVieras.Text = pisteetVieras.ToString();
        }
        //Kotijoukkueen pelaajat
        public void lisaaPisteK1(bool vainPelaaja)
        {
            p1++;
            k1.Text = p1.ToString();
            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK2(bool vainPelaaja)
        {
            p2++;
            k2.Text = p2.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK3(bool vainPelaaja)
        {
            p3++;
            k3.Text = p3.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK4(bool vainPelaaja)
        {
            p4++;
            k4.Text = p4.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK5(bool vainPelaaja)
        {
            p5++;
            k5.Text = p5.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK6(bool vainPelaaja)
        {
            p6++;
            k6.Text = p6.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK7(bool vainPelaaja)
        {
            p7++;
            k7.Text = p7.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK8(bool vainPelaaja)
        {
            p8++;
            k8.Text = p8.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK9(bool vainPelaaja)
        {
            p9++;
            k9.Text = p9.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK10(bool vainPelaaja)
        {
            p10++;
            k10.Text = p10.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
     

        public void lisaaPisteK11(bool vainPelaaja)
        {
            p11++;
            k11.Text = p11.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void lisaaPisteK12(bool vainPelaaja)
        {
            p12++;
            k12.Text = p12.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti++;
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }

        //Poistot
        //Kotijoukkue
        public void poistaPisteK1(bool vainPelaaja)
        {
            p1--;
            if(p1 <= 0) p1 = 0;
            k1.Text = p1.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK2(bool vainPelaaja)
        {
            p2--;
            if (p2 <= 0) p2 = 0;
            k2.Text = p2.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK3(bool vainPelaaja)
        {
            p3--;
            if (p3 <= 0) p3 = 0;
            k3.Text = p3.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK4(bool vainPelaaja)
        {
            p4--;
            if (p4 <= 0) p4 = 0;
            k4.Text = p4.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK5(bool vainPelaaja)
        {
            p5--;
            if (p5 <= 0) p5 = 0;
            k5.Text = p5.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK6(bool vainPelaaja)
        {
            p6--;
            if (p6 <= 0) p6 = 0;
            k6.Text = p6.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK7(bool vainPelaaja)
        {
            p7--;
            if (p7 <= 0) p7 = 0;
            k7.Text = p7.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK8(bool vainPelaaja)
        {
            p8--;
            if (p8 <= 0) p8 = 0;
            k8.Text = p8.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK9(bool vainPelaaja)
        {
            p9--;
            if (p9 <= 0) p9 = 0;
            k9.Text = p9.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK10(bool vainPelaaja)
        {
            p10--;
            if (p10 <= 0) p10 = 0;
            k10.Text = p10.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK11(bool vainPelaaja)
        {
            p11--;
            if (p11 <= 0) p11 = 0;
            k11.Text = p11.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }
        public void poistaPisteK12(bool vainPelaaja)
        {
            p12--;
            if (p12 <= 0) p12 = 0;
            k12.Text = p12.ToString();

            if (vainPelaaja == false)
            {
                pisteetKoti--;
                if (pisteetKoti < 0)
                {
                    pisteetKoti = 0;
                }
                labelPisteKoti.Text = pisteetKoti.ToString();
            }
        }

        

        //Vierasjoukkueen pisteiden lisäys/poisto
        //Lisäys
        public void lisaaPisteV1(bool vainPelaaja)
        {
            p13++;
            v1.Text = p13.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV2(bool vainPelaaja)
        {
            p14++;
            v2.Text = p14.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV3(bool vainPelaaja)
        {
            p15++;
            v3.Text = p15.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV4(bool vainPelaaja)
        {
            p16++;
            v4.Text = p16.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV5(bool vainPelaaja)
        {
            p17++;
            v5.Text = p17.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV6(bool vainPelaaja)
        {
            p18++;
            v6.Text = p18.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV7(bool vainPelaaja)
        {
            p19++;
            v7.Text = p19.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV8(bool vainPelaaja)
        {
            p20++;
            v8.Text = p20.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV9(bool vainPelaaja)
        {
            p21++;
            v9.Text = p21.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }

       
        public void lisaaPisteV10(bool vainPelaaja)
        {
            p22++;
            v10.Text = p22.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV11(bool vainPelaaja)
        {
            p23++;
            v11.Text = p23.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void lisaaPisteV12(bool vainPelaaja)
        {
            p24++;
            v12.Text = p24.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras++;
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }

        //Vierasjoukkueen pisteiden poisto
        public void poistaPisteV1(bool vainPelaaja)
        {
            p13--;
            if (p13 <= 0) p13 = 0;
            v1.Text = p13.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV2(bool vainPelaaja)
        {
            p14--;
            if (p14 <= 0) p14 = 0;
            v2.Text = p14.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV3(bool vainPelaaja)
        {
            p15--;
            if (p15 <= 0) p15 = 0;
            v3.Text = p15.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV4(bool vainPelaaja)
        {
            p16--;
            if (p16 <= 0) p16 = 0;
            v4.Text = p16.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV5(bool vainPelaaja)
        {
            p17--;
            if (p17 <= 0) p17 = 0;
            v5.Text = p17.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV6(bool vainPelaaja)
        {
            p18--;
            if (p18 <= 0) p18 = 0;
            v6.Text = p18.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV7(bool vainPelaaja)
        {
            p19--;
            if (p19 <= 0) p19 = 0;
            v7.Text = p19.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV8(bool vainPelaaja)
        {
            p20--;
            if (p20 <= 0) p20 = 0;
            v8.Text = p20.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV9(bool vainPelaaja)
        {
            p21--;
            if (p21 <= 0) p21 = 0;
            v9.Text = p21.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV10(bool vainPelaaja)
        {
            p22--;
            if (p22 <= 0) p22 = 0;
            v10.Text = p22.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV11(bool vainPelaaja)
        {
            p23--;
            if (p23 <= 0) p23 = 0;
            v11.Text = p23.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }
        public void poistaPisteV12(bool vainPelaaja)
        {
            p24--;
            if (p24 <= 0) p24 = 0;
            v12.Text = p24.ToString();

            if (vainPelaaja == false)
            {
                pisteetVieras--;
                if (pisteetVieras < 0)
                {
                    pisteetVieras = 0;
                }
                labelPisteVieras.Text = pisteetVieras.ToString();
            }
        }


        //Pelikellon toiminta
        public void kelloStart()
        {
            isActive = true;                     
        }
        public void kelloPause()
        {
            isActive = false;
            

        }
        public void kelloReset()
        {
            isActive = false; 
            
            resetTime();
        }
        //Kellon resetointi
        private void resetTime()
        {
            if (odotusKelloKayntiin == false)
            {
                timeMs = 0;
                timeSs = at.getNeljanneksenpituusSekunnit();
                timeMm = at.getNeljanneksenpituus();
                to.hyokkaysKelloReset();
            }
            else if(odotusKelloKayntiin == true)
            {
                timeMs = 0;
                timeSs = odotusKelloSek;
                timeMm = odotusKelloMin;              
            }
        }
        //Laitetaan taululle neljänneksen määritelty pituus kun tauko loppuu. Kutsutaan timer_tickistä
        public void resetTimeNeljannes()
        {
            timeMs = 0;
            timeSs = neljanneksenPituusSek;
            timeMm = neljanneksenPituusMin;

            at.setNeljanneksenpituus(neljanneksenPituusMin);
            at.setNeljanneksenpituus(neljanneksenPituusSek);
        }

        public void resetTimeJatkoAika()
        {
            timeMs = 0;
            timeMm = at.getJatkoajanpituus();
            timeSs = at.getJatkoajanpituusSekunnit(); 
        }

        public void setTime(int aika)
        {
            timeMm = aika;
        }

        //Timer toiminta
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                
                if (odotusKelloKayntiin == false)
                {                   
                    to.kaynnistaHyokkaysKello();
                    to.timer1Tick();                  
                }

                timeMs--;
                if (timeMs == -1)
                {
                    timeSs--;
                    timeMs = 9;
                }
                if (timeSs == -1)
                {
                    timeMm--;
                    timeSs = 59;
                }
                if (timeMm == 1 && timeSs == 0 && timeMs == 0)
                {
                    labelMs.Visible = true;
                    label9.Visible = true;
                }
                if (odotusKelloKayntiin == false)
                {
                    if (timeMm == 0 && timeSs == 0 && timeMs == 0)
                    {
                        isActive = false;
                        // labelMs.Visible = false;                      
                        // label9.Visible = false;
                        soitaSummeri1JaReunat();
                        ehdotaTauko();
                    }
                }
                else if (odotusKelloKayntiin == true)
                {
                    if (timeMm == 0 && timeSs == 0 && timeMs == 0)
                    {
                        isActive = false;
                        labelMs.Visible = false;
                        label9.Visible = false;
                        soitaSummeri1();

                        resetTimeNeljannes();
                        uusiNeljannes();
                        odotusKelloKayntiin = false;
                        
                        
                    }
                }

                if (timeMm < 0)
                {
                    resetTime();
                }


            }
            else
            {
                to.sammutaHyokkaysKello();
            }

            drawTime();
        }
        //Ajan piirtäminen labeleihin
        private void drawTime()
        {
            labelMs.Text = String.Format("{0}", timeMs);
            labelSs.Text = String.Format("{0:00}", timeSs);
            labelMm.Text = String.Format("{0:00}", timeMm);
        }
        //Pelikellon muuttaminen ohjaustaulun kautta
        public void muutaKello(int minuutti, int sekunti, bool onkoTauko)
        {
            if (onkoTauko == true) { odotusKelloKayntiin = true; }
            if (odotusKelloKayntiin == true)
            {
                odotusKelloMin = minuutti;
                odotusKelloSek = sekunti;
            }
            else if(odotusKelloKayntiin == false)
            {
                at.setNeljanneksenpituus(minuutti);
                at.setNeljanneksenpituusSekunnit(sekunti);
            }

            if(minuutti == 0 && sekunti <= 60)
            {
                labelMs.Visible = true;
                label9.Visible = true;
            }
            else if (minuutti == 1 && sekunti == 0)
            {
                labelMs.Visible = true;
                label9.Visible = true;
            }
            if (minuutti >= 1 && sekunti >= 1)
            {
                labelMs.Visible = false;
                label9.Visible = false;
            }
            resetTime();
        }

        //Taukojen kellot
        public void kaynnistaLyhytTauko(bool onkoTauko)
        {
            //odotusKelloKayntiin = true;
            
            this.muutaKello(at.getLyhyttauko(), at.getLyhyttaukoSekunnit(), onkoTauko);
            isActive = true;
        }

        public void kaynnistaPitkaTauko(bool onkoTauko)
        {
            //odotusKelloKayntiin = true;
            
            this.muutaKello(at.getPitkatauko(), at.getPitkataukoSekunnit(), onkoTauko);
            isActive = true;
        }



        //Aikalisän kello
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (aikalisaKaynnissa)
            {
                timeAikalisaSek--;

                if (timeAikalisaSek == 10)
                {
                    soitaSummeri1();
                }
                if (timeAikalisaSek == 0)
                {
                    soitaSummeri1();
                    timer4.Stop();
                    aikalisaKaynnissa = false;
                    labelAikalisaKello.Visible = false;
                    resetAikalisaKello();
                }
            }
            
            aikalisaTaululle();
        }

        private void aikalisaTaululle()
        {
            labelAikalisaKello.Text = String.Format("{0:00}", timeAikalisaSek);
        }

        private void kaynnistaAikalisa()
        {
            aikalisaKaynnissa = true;
            labelAikalisaKello.Visible = true;
            timer4.Start();
            resetAikalisaKello();
        }

        public void resetAikalisaKello()
        {
            timeAikalisaSek = at.getAikalisa();
            labelAikalisaKello.Text = timeAikalisaSek.ToString();
        }

        public void piilotaAikalisaKello()
        {
            labelAikalisaKello.Visible = false;
        }
        //Neljänneksen muuttaminen
        public void uusiNeljannes()
        {
            switch (neljannes)
            {
                case 0:
                    neljannes++;
                    labelNeljannes.Text = neljannes.ToString();
                    nollaaAikalisat();
                    nollaaPisteet();
                    nollaaVirheet();
                    
                    break;
                case 1:
                    neljannes++;
                    labelNeljannes.Text = neljannes.ToString();
                    //nollaa joukkuevirheet mutta jätä aikalisät
                    nollaaJoukkueVirheet();
                    break;
                case 2:
                    neljannes++;
                    labelNeljannes.Text = neljannes.ToString();
                    //nollaa jokkuevirheet ja aikalisät
                    nollaaJoukkueVirheet();
                    nollaaAikalisat();
                    break;
                case 3:
                    neljannes++;
                    labelNeljannes.Text = neljannes.ToString();
                    nollaaJoukkueVirheet();
                    break;
                //Jatkoajat
                case 4:
                    neljannes++;
                    labelNeljannes.Text = "E1";
                    nollaaAikalisat();
                    resetTimeJatkoAika();
                    break;
                case 5:
                    neljannes++;
                    labelNeljannes.Text = "E2";
                    resetTimeJatkoAika();
                    break;
                case 6:
                    neljannes++;
                    labelNeljannes.Text = "E3";
                    resetTimeJatkoAika();
                    break;
                case 7:
                    neljannes++;
                    labelNeljannes.Text = "E4";
                    resetTimeJatkoAika();
                    break;
                case 8:
                    neljannes++;
                    labelNeljannes.Text = "E5";
                    resetTimeJatkoAika();
                    break;
                case 9:
                    neljannes++;
                    labelNeljannes.Text = "E6";
                    resetTimeJatkoAika();
                    break;
                case 10:
                    neljannes++;
                    labelNeljannes.Text = "E7";
                    resetTimeJatkoAika();
                    break;
            }
        }

        public void ehdotaTauko()
        {
            int lyhytTauko = 1;
            int pitkaTauko = 2;

            if(neljannes != 2) 
            {
                to.taukoEhdotus(lyhytTauko);
            }
            else if (neljannes == 2)
            {
                to.taukoEhdotus(pitkaTauko);
            }
            
        }

        //Laitetaan tulostaulunäyttö kokonäytölle
        bool onkoKokoNaytto = false;
        public void kokonaytto()
        {
            if (onkoKokoNaytto)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.TopMost = false;
                onkoKokoNaytto = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.TopMost = true;
                onkoKokoNaytto = true;
            }
        }

        //Summerin toiminta
        public void soitaSummeri1()
        {
            summeri1.Play();
        }
        public void soitaSummeri1JaReunat()
        {
            pictureBoxViivaAla.Visible = true;
            pictureBoxViivaOikea.Visible = true;
            pictureBoxViivaVasen.Visible = true;
            pictureBoxViivaYla.Visible = true;

            summeri1.Play();
            timer5.Start();   
        }
        //Näytetään tulostaulun ympärillä punainen kehä timer5 tickin ajan
        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBoxViivaAla.Visible = false;
            pictureBoxViivaOikea.Visible = false;
            pictureBoxViivaVasen.Visible = false;
            pictureBoxViivaYla.Visible = false;
            timer5.Stop();
        }

        public void soitaSummeri2()
        {
            summeri2.Play();
        }

    }
}
