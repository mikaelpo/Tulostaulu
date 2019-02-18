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
        private string osoite;
        private string osoite2;

        public tulostauluNaytto(string [] lista, string osoite)
        {
            InitializeComponent();
            this.lista = lista;
            this.osoite = osoite;
            //this.osoite2 = osoite2;

        }

        private void labelT1_Click(object sender, EventArgs e)
        {
            //labelT1.Text = lista[0];
            //label12.Text = this.osoite;
            pictureBox1.Image = new Bitmap(@"C:\Users\mikae\j.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
