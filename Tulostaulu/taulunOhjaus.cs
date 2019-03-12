using System;
using System.Collections;
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
        private oletusasetukset asetukset2 = new oletusasetukset();
        
        

        public taulunOhjaus(string[] lista, string kotiKuva, string vierasKuva, oletusasetukset asetukset)
        {
            InitializeComponent();

            this.lista = lista;
            this.koti = kotiKuva;
            this.vieras = vierasKuva;
            asetukset2 = asetukset;

        }

        private void taulunOhjaus_Load(object sender, EventArgs e)
        {
            label1.Text = lista[0];
            label2.Text = lista[1];
            label3.Text = lista[2];
            label5.Text = lista[3];
            label6.Text = lista[4];
            label7.Text = lista[5];

            label4.Text = asetukset2.getNeljanneksienmaara().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new tulostauluNaytto(lista, koti, vieras, asetukset2);
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

        //Kellon ohjaus näppäimistöltä tulostaululla
        private void taulunOhjaus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            { 
                t1.kelloStart();
            }
            if (e.KeyCode == Keys.D2)
            {
                t1.kelloPause();
            }
            if (e.KeyCode == Keys.D3)
            {
                t1.kelloReset();
            }
        }


    }
}
