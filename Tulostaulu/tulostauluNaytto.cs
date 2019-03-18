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
        private string koti;
        private string vieras;
        private int p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18,p19,p20,
            p21,p22,p23,p24 = 0;
        private oletusasetukset at;

        //ajastimen muuttujat
        int timeMs;
        int timeSs;
        int timeMm;
        bool isActive;

        public tulostauluNaytto(string [] lista, string kotiKuva, string vierasKuva, oletusasetukset at)
        {
            InitializeComponent();
            this.lista = lista;
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
            label17.Text = lista[12];
            label18.Text = lista[13];
            label19.Text = lista[14];
            label20.Text = lista[15];
            label21.Text = lista[16];
            label22.Text = lista[17];
            label23.Text = lista[18];
            label24.Text = lista[19];
            label25.Text = lista[20];
            label26.Text = lista[21];
            label27.Text = lista[22];
            label28.Text = lista[23];

        }


        //Pisteiden lisäystä/poistoa ohjaustaulun kautta
        //Kotijoukkue
        public void lisaaPisteK1()
        {
            p1++;
            k1.Text = p1.ToString();
        }
        public void lisaaPisteK2()
        {
            p2++;
            k2.Text = p2.ToString();
        }
        public void lisaaPisteK3()
        {
            p3++;
            k3.Text = p3.ToString();
        }
        public void lisaaPisteK4()
        {
            p4++;
            k4.Text = p4.ToString();
        }
        public void lisaaPisteK5()
        {
            p5++;
            k5.Text = p5.ToString();
        }
        public void lisaaPisteK6()
        {
            p6++;
            k6.Text = p6.ToString();
        }
        public void lisaaPisteK7()
        {
            p7++;
            k7.Text = p7.ToString();
        }
        public void lisaaPisteK8()
        {
            p8++;
            k8.Text = p8.ToString();
        }
        public void lisaaPisteK9()
        {
            p9++;
            k9.Text = p9.ToString();
        }
        public void lisaaPisteK10()
        {
            p10++;
            k10.Text = p10.ToString();
        }
        public void lisaaPisteK11()
        {
            p11++;
            k11.Text = p11.ToString();
        }
        public void lisaaPisteK12()
        {
            p12++;
            k12.Text = p12.ToString();
        }

        //Poistot
        //Kotijoukkue
        public void poistaPisteK1()
        {
            p1--;
            if(p1 <= 0) p1 = 0;
            k1.Text = p1.ToString();
        }
        public void poistaPisteK2()
        {
            p2--;
            if (p2 <= 0) p2 = 0;
            k2.Text = p2.ToString();
        }
        public void poistaPisteK3()
        {
            p3--;
            if (p3 <= 0) p3 = 0;
            k3.Text = p3.ToString();
        }
        public void poistaPisteK4()
        {
            p4--;
            if (p4 <= 0) p4 = 0;
            k4.Text = p4.ToString();
        }
        public void poistaPisteK5()
        {
            p5--;
            if (p5 <= 0) p5 = 0;
            k5.Text = p5.ToString();
        }
        public void poistaPisteK6()
        {
            p6--;
            if (p6 <= 0) p6 = 0;
            k6.Text = p6.ToString();
        }
        public void poistaPisteK7()
        {
            p7--;
            if (p7 <= 0) p7 = 0;
            k7.Text = p7.ToString();
        }
        public void poistaPisteK8()
        {
            p8--;
            if (p8 <= 0) p8 = 0;
            k8.Text = p8.ToString();
        }
        public void poistaPisteK9()
        {
            p9--;
            if (p9 <= 0) p9 = 0;
            k9.Text = p9.ToString();
        }
        public void poistaPisteK10()
        {
            p10--;
            if (p10 <= 0) p10 = 0;
            k10.Text = p10.ToString();
        }
        public void poistaPisteK11()
        {
            p11--;
            if (p11 <= 0) p11 = 0;
            k11.Text = p11.ToString();
        }
        public void poistaPisteK12()
        {
            p12--;
            if (p12 <= 0) p12 = 0;
            k12.Text = p12.ToString();
        }

        //Vierasjoukkueen pisteiden lisäys/poisto
        //Lisäys
        public void lisaaPisteV1()
        {
            p13++;
            v1.Text = p13.ToString();
        }
        public void lisaaPisteV2()
        {
            p14++;
            v2.Text = p14.ToString();
        }
        public void lisaaPisteV3()
        {
            p15++;
            v3.Text = p15.ToString();
        }
        public void lisaaPisteV4()
        {
            p16++;
            v4.Text = p16.ToString();
        }
        public void lisaaPisteV5()
        {
            p17++;
            v5.Text = p17.ToString();
        }
        public void lisaaPisteV6()
        {
            p18++;
            v6.Text = p18.ToString();
        }
        public void lisaaPisteV7()
        {
            p19++;
            v7.Text = p19.ToString();
        }
        public void lisaaPisteV8()
        {
            p20++;
            v8.Text = p20.ToString();
        }
        public void lisaaPisteV9()
        {
            p21++;
            v9.Text = p21.ToString();
        }
        public void lisaaPisteV10()
        {
            p22++;
            v10.Text = p22.ToString();
        }
        public void lisaaPisteV11()
        {
            p23++;
            v11.Text = p23.ToString();
        }
        public void lisaaPisteV12()
        {
            p24++;
            v12.Text = p24.ToString();
        }

        //Vierasjoukkueen pisteiden poisto
        public void poistaPisteV1()
        {
            p13--;
            if (p13 <= 0) p13 = 0;
            v1.Text = p13.ToString();
        }
        public void poistaPisteV2()
        {
            p14--;
            if (p14 <= 0) p14 = 0;
            v2.Text = p14.ToString();
        }
        public void poistaPisteV3()
        {
            p15--;
            if (p15 <= 0) p15 = 0;
            v3.Text = p15.ToString();
        }
        public void poistaPisteV4()
        {
            p16--;
            if (p16 <= 0) p16 = 0;
            v4.Text = p16.ToString();
        }
        public void poistaPisteV5()
        {
            p17--;
            if (p17 <= 0) p17 = 0;
            v5.Text = p17.ToString();
        }
        public void poistaPisteV6()
        {
            p18--;
            if (p18 <= 0) p18 = 0;
            v6.Text = p18.ToString();
        }
        public void poistaPisteV7()
        {
            p19--;
            if (p19 <= 0) p19 = 0;
            v7.Text = p19.ToString();
        }
        public void poistaPisteV8()
        {
            p20--;
            if (p20 <= 0) p20 = 0;
            v8.Text = p20.ToString();
        }
        public void poistaPisteV9()
        {
            p21--;
            if (p21 <= 0) p21 = 0;
            v9.Text = p21.ToString();
        }
        public void poistaPisteV10()
        {
            p22--;
            if (p22 <= 0) p22 = 0;
            v10.Text = p22.ToString();
        }
        public void poistaPisteV11()
        {
            p23--;
            if (p23 <= 0) p23 = 0;
            v11.Text = p23.ToString();
        }
        public void poistaPisteV12()
        {
            p24--;
            if (p24 <= 0) p24 = 0;
            v12.Text = p24.ToString();
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
            timeSs = 0;
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

                if (timeMs <= 0)
                {
                    timeSs--;
                    timeMs = 9;

                    if (timeSs <= 0)
                    {
                        timeMm--;
                        timeSs = 59;

                        if (timeMm <= 0 && timeSs <= 0 && timeMs <= 0)
                        {
                            isActive = false;
                            k3.Text = "Peli loppui";
                        }
                    }
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

    }
}
