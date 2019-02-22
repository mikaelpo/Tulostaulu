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

        public tulostauluNaytto(string [] lista, string kotiKuva, string vierasKuva)
        {
            InitializeComponent();
            this.lista = lista;
            this.koti = kotiKuva;
            this.vieras = vierasKuva;

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
        
    }
}
