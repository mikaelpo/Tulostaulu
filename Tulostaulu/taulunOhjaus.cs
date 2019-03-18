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
            label8.Text = lista[6];
            label9.Text = lista[7];
            label10.Text = lista[8];
            label11.Text = lista[9];
            label12.Text = lista[10];
            label13.Text = lista[11];
            label14.Text = lista[12];
            label15.Text = lista[13];
            label16.Text = lista[14];
            label17.Text = lista[15];
            label18.Text = lista[16];
            label19.Text = lista[17];
            label20.Text = lista[18];
            label21.Text = lista[19];
            label22.Text = lista[20];
            label23.Text = lista[21];
            label24.Text = lista[22];
            label25.Text = lista[23];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new tulostauluNaytto(lista, koti, vieras, asetukset2);
            t1.Show();  
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

        private void button5_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste4();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste5();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste6();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste7();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste8();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste9();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste10();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste11();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste12();
        }

        //Poistot
        private void button14_Click(object sender, EventArgs e)
        {
            t1.poistaPiste1();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            t1.poistaPiste2();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            t1.poistaPiste3();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            t1.poistaPiste4();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            t1.poistaPiste5();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            t1.poistaPiste6();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            t1.poistaPiste7();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            t1.poistaPiste8();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            t1.poistaPiste9();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            t1.poistaPiste10();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            t1.poistaPiste11();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            t1.poistaPiste12();
        }
    }
}
