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
        private int i,x,c = 0;
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
        }


        //Pisteiden lisäystä ohjaustaulun kautta
        public void lisaaPiste1()
        {
            i++;
            label1testi.Text = i.ToString();
        }
        public void lisaaPiste2()
        {
            c++;
            label4.Text = c.ToString();
        }
        public void lisaaPiste3()
        {
            x++;
            label5.Text = x.ToString();
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
                            label5.Text = "Peli loppui";
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
