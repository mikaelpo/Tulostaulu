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

        public tulostauluNaytto(string [] lista, string kotiKuva, string vierasKuva)
        {
            InitializeComponent();
            this.lista = lista;
            this.koti = kotiKuva;
            this.vieras = vierasKuva;

        }

        private void tulostauluNaytto_Load(object sender, EventArgs e)
        {
            resetTime();
            isActive = false;
        }

        public void aloita()
        {
            
            pictureBox1.Image = new Bitmap(@koti);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = new Bitmap(@vieras);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

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
        

        public void naytaPelaajat()
        {
            label1.Text = lista[0];
            label2.Text = lista[1];
            label3.Text = lista[2];
        }


        private void tulostauluNaytto_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void resetTime()
        {
            timeMs = 0;
            timeSs = 0;
            timeMm = 55;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {

                timeMs--;

                if (timeMs <= 0)
                {
                    timeSs--;
                    timeMs = 100;

                    if (timeSs <= 0)
                    {
                        timeMm--;
                        timeSs = 59;
                    }
                }
            }

            drawTime();
        }

        private void drawTime()
        {
            labelMs.Text = String.Format("{0:00}", timeMs);
            labelSs.Text = String.Format("{0:00}", timeSs);
            labelMm.Text = String.Format("{0:00}", timeMm);
        }

    }
}
