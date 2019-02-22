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
    public partial class taulunOhjaus : Form
    {

        private string[] lista;
        private string koti;
        private string vieras;
        private tulostauluNaytto t1;
        

        public taulunOhjaus(string[] lista, string kotiKuva, string vierasKuva)
        {
            InitializeComponent();

            this.lista = lista;
            this.koti = kotiKuva;
            this.vieras = vierasKuva;

            
        }

        public void naytaPelaajatOhjauspaneelissa()
        {
            label1.Text = lista[0];
            label2.Text = lista[1];
            label3.Text = lista[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new tulostauluNaytto(lista, koti, vieras);
            t1.aloita();
            t1.naytaPelaajat();
            t1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste1();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste2();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste3();
        }
    }
}
