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
        private string[] lista2;
        private string koti;
        private string vieras;
        private tulostauluNaytto t1;
        private oletusasetukset asetukset2 = new oletusasetukset();



        public taulunOhjaus(string[] lista, string[] lista2, string kotiKuva, string vierasKuva, oletusasetukset asetukset)
        {
            InitializeComponent();

            this.lista = lista;
            this.lista2 = lista2;
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
            label14.Text = lista2[0];
            label15.Text = lista2[1];
            label16.Text = lista2[2];
            label17.Text = lista2[3];
            label18.Text = lista2[4];
            label19.Text = lista2[5];
            label20.Text = lista2[6];
            label21.Text = lista2[7];
            label22.Text = lista2[8];
            label23.Text = lista2[9];
            label24.Text = lista2[10];
            label25.Text = lista2[11];

            textBoxMin.Text = asetukset2.getNeljanneksenpituus().ToString();
            textBoxSek.Text = asetukset2.getNeljanneksenpituusSekunnit().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new tulostauluNaytto(lista, lista2, koti, vieras, asetukset2);
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
        
        //Kotijoukkuueen pisteiden lisäys
        private void button2_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK4();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK5();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK6();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK7();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK8();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK9();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK10();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK11();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteK12();
        }

        //Kotijoukkueen pisteiden poistot
        private void button14_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK1();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK2();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK3();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK4();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK5();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK6();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK7();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK8();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK9();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK10();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK11();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            t1.poistaPisteK12();
        }

        //Vierasjoukkueen pisteiden lisäys
        private void button26_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV1();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV2();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV3();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV4();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV5();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV6();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV7();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV8();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV9();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV10();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV11();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            t1.lisaaPisteV12();
        }
       
        //Vierasjoukkueen pisteiden poisto
        private void button38_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV1();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV2();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV3();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV4();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV5();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV6();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV7();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV8();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV9();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV10();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV11();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            t1.poistaPisteV12();
        }

        private void ohjeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ohjekirja ohje = new Ohjekirja();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            t1.muutaKello(Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxSek.Text));
        }
    }
}
