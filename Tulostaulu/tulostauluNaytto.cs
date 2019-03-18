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


        //Pisteiden lisäystä ohjaustaulun kautta
        public void lisaaPiste1()
        {
            p1++;
            k1.Text = p1.ToString();
        }
        public void lisaaPiste2()
        {
            p2++;
            k2.Text = p2.ToString();
        }
        public void lisaaPiste3()
        {
            p3++;
            k3.Text = p3.ToString();
        }
        public void lisaaPiste4()
        {
            p4++;
            k4.Text = p4.ToString();
        }
        public void lisaaPiste5()
        {
            p5++;
            k5.Text = p5.ToString();
        }
        public void lisaaPiste6()
        {
            p6++;
            k6.Text = p6.ToString();
        }
        public void lisaaPiste7()
        {
            p7++;
            k7.Text = p7.ToString();
        }
        public void lisaaPiste8()
        {
            p8++;
            k8.Text = p8.ToString();
        }
        public void lisaaPiste9()
        {
            p9++;
            k9.Text = p9.ToString();
        }
        public void lisaaPiste10()
        {
            p10++;
            k10.Text = p10.ToString();
        }
        public void lisaaPiste11()
        {
            p11++;
            k11.Text = p11.ToString();
        }
        public void lisaaPiste12()
        {
            p12++;
            k12.Text = p12.ToString();
        }

        //Poistot
        public void poistaPiste1()
        {
            p1--;
            if(p1 <= 0) p1 = 0;
            k1.Text = p1.ToString();
        }
        public void poistaPiste2()
        {
            p2--;
            if (p2 <= 0) p2 = 0;
            k2.Text = p2.ToString();
        }
        public void poistaPiste3()
        {
            p3--;
            if (p3 <= 0) p3 = 0;
            k3.Text = p3.ToString();
        }
        public void poistaPiste4()
        {
            p4--;
            if (p4 <= 0) p4 = 0;
            k4.Text = p4.ToString();
        }
        public void poistaPiste5()
        {
            p5--;
            if (p5 <= 0) p5 = 0;
            k5.Text = p5.ToString();
        }
        public void poistaPiste6()
        {
            p6--;
            if (p6 <= 0) p6 = 0;
            k6.Text = p6.ToString();
        }
        public void poistaPiste7()
        {
            p7--;
            if (p7 <= 0) p7 = 0;
            k7.Text = p7.ToString();
        }
        public void poistaPiste8()
        {
            p8--;
            if (p8 <= 0) p8 = 0;
            k8.Text = p8.ToString();
        }
        public void poistaPiste9()
        {
            p9--;
            if (p9 <= 0) p9 = 0;
            k9.Text = p9.ToString();
        }
        public void poistaPiste10()
        {
            p10--;
            if (p10 <= 0) p10 = 0;
            k10.Text = p10.ToString();
        }
        public void poistaPiste11()
        {
            p11--;
            if (p11 <= 0) p11 = 0;
            k11.Text = p11.ToString();
        }
        public void poistaPiste12()
        {
            p12--;
            if (p12 <= 0) p12 = 0;
            k12.Text = p12.ToString();
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
