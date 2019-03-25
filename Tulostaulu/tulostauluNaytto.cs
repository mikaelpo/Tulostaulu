using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private int pelaajaVirheK1 = 0;
        private int virheetKoti = 0;
        private int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20,
            p21, p22, p23, p24 = 0;
        private oletusasetukset at;

        //ajastimen muuttujat
        int timeMs;
        int timeSs;
        int timeMm;
        bool isActive;

        Label vilkku = null;

        public tulostauluNaytto(string[] listaKoti, string[] listaVieras, string kotiKuva, string vierasKuva, oletusasetukset at)
        {
            InitializeComponent();
            this.lista2 = listaVieras;
            this.lista = listaKoti;
            this.koti = kotiKuva;
            this.vieras = vierasKuva;
            this.at = at;

        }

        private void tulostauluNaytto_Load(object sender, EventArgs e)
        {
            resetTime();
            isActive = false;
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

        private void lisaaVirheKoti()
        {
            virheetKoti++;
            if (virheetKoti > 5)
            {
                virheetKoti = 5;
            }
            labelVirheetKoti.Text = virheetKoti.ToString();
        }
        private void vahennaVirheKoti()
        {
            virheetKoti--;
            if(virheetKoti < 0)
            {
                virheetKoti = 0;
            }
            labelVirheetKoti.Text = virheetKoti.ToString();
        }

        public void vilkutaLabel(Label l)
        {
            timer2.Start();
            timer3.Start();
            vilkku = l;
        }
        public void timer2_Tick(object sender, EventArgs e)
        {
            if (vilkku.ForeColor == Color.Black)
                vilkku.ForeColor = Color.Red;
            else
                vilkku.ForeColor = Color.Black;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            vilkku.ForeColor = Color.Red;
        }

        //Virheet
        public void lisaaVirheKoti(bool vainPelaajaVirhe)
        {
            pelaajaVirheK1++;
            if(pelaajaVirheK1 > 5) { pelaajaVirheK1 = 5; }
            if (pelaajaVirheK1 == 1) { vk1.Visible = true; }
            if (pelaajaVirheK1 == 2) { vk2.Visible = true; }
            if (pelaajaVirheK1 == 3) { vk3.Visible = true; }
            if (pelaajaVirheK1 == 4) { vk4.Visible = true; }
            if (pelaajaVirheK1 == 5) { vk5.Visible = true; vilkutaLabel(vk5); }

            if(vainPelaajaVirhe == false) { lisaaVirheKoti(); }
        }
        public void vahennaVirheKoti(bool vainPelaajaVirhe)
        {
            
            switch (pelaajaVirheK1)
            {
                case 1:
                    vk1.Visible = false;
                    break;
                case 2:
                    vk2.Visible = false;
                    break;
                case 3:
                    vk3.Visible = false;
                    break;
                case 4:
                    vk4.Visible = false;
                    break;
                case 5:
                    vk5.Visible = false;
                    break;
            }
            pelaajaVirheK1--;
            if (pelaajaVirheK1 < 0) { pelaajaVirheK1 = 0; }
            if (vainPelaajaVirhe == false) { vahennaVirheKoti(); }
            
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


        //Kellon toiminta nuolten kautta -> Ylänuoli = Start, Alanuoli = Pause, Vasen nuoli = Reset
        /*private void tulostauluNaytto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isActive = true;
                
            }
            if (e.KeyCode == Keys.Down)
            {
                isActive = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                isActive = false;
                resetTime();
            }
        }*/

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
            timeMs = 0;
            timeSs = at.getNeljanneksenpituusSekunnit();
            timeMm = at.getNeljanneksenpituus();
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
                if (timeMm == 0 && timeSs == 0 && timeMs == 0)
                {
                    isActive = false;
                    k3.Text = "Peli loppui";
                }
                    
            }

            drawTime();
        }
        //Ajan piirtäminen labeleihin
        private void drawTime()
        {
            labelMs.Text = String.Format("{0:00}", timeMs);
            labelSs.Text = String.Format("{0:00}", timeSs);
            labelMm.Text = String.Format("{0:00}", timeMm);
        }

        public void muutaKello(int minuutti, int sekunti)
        {
            at.setNeljanneksenpituus(minuutti);
            at.setNeljanneksenpituusSekunnit(sekunti);
            resetTime();
        }

    }
}
