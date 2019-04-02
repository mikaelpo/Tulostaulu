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
    public partial class asetukset : Form
    {


        private oletusasetukset a1 = new oletusasetukset(4, 0, 10, 5, 0, true, 2, 0, 15, 0, 2, 1, 3, 1, 1, 5, 1, 1 );
        public asetukset()
        {
            InitializeComponent();
            
        }

        private void asetukset_Load(object sender, EventArgs e)
        {
            textBox1.Text = 10.ToString();
            textBox2.Text = 4.ToString();
            textBox4.Text = 0.ToString();
            textBox3.Text = 5.ToString();
            textBox5.Text = 2.ToString();
            textBox7.Text = 15.ToString();
            a1.setKellonkayntisuuntaalaspain(true);
            textBox6.Text = 60.ToString();
            textBox8.Text = 3.ToString();
            textBox9.Text = 24.ToString();
            textBox10.Text = 14.ToString();
            textBox11.Text = 5.ToString();
            textBox13.Text = 2.ToString();
            textBox12.Text = 2.ToString();
            textBox14.Text = 0.ToString();
            textBox15.Text = 0.ToString();
            textBox16.Text = 0.ToString();
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            
            try
            {
                a1.setNeljanneksenpituus(Convert.ToInt32(textBox1.Text));
                a1.setNeljanneksenpituusSekunnit(Convert.ToInt32(textBox4.Text));
                a1.setNeljanneksienmaara(Convert.ToInt32(textBox2.Text));
                a1.setJatkoajanpituus(Convert.ToInt32(textBox3.Text));
                a1.setJatkoajanpituusSekunnit(Convert.ToInt32(textBox14.Text));
                a1.setLyhyttauko(Convert.ToInt32(textBox5.Text));
                a1.setLyhyttaukoSekunnit(Convert.ToInt32(textBox15.Text));
                a1.setPitkatauko(Convert.ToInt32(textBox7.Text));
                a1.setPitkataukoSekunnit(Convert.ToInt32(textBox16.Text));
                a1.setAikalisa(Convert.ToInt32(textBox6.Text));
                a1.setAikalisienlukumaara(Convert.ToInt32(textBox8.Text));
                a1.setHyokkaysaika1(Convert.ToInt32(textBox9.Text));
                a1.setHyokkaysaika2(Convert.ToInt32(textBox10.Text));
                a1.setVirheet(Convert.ToInt32(textBox11.Text));
                a1.setPelikellonsummeri(Convert.ToInt32(textBox13.Text));
                a1.setHeittokellonsummeri(Convert.ToInt32(textBox12.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Jossain teksikentässä on jotain muuta kuin numeroita, korjaa kenttä/kentät pelkiksi kokonaisluvuiksi");
                return;
            }


            kokoonpanot k1 = new kokoonpanot(a1);
            
            k1.Show();
            this.Hide();
            
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = 10.ToString();
            textBox2.Text = 4.ToString();
            textBox3.Text = 5.ToString();
            textBox4.Text = 0.ToString();
            textBox5.Text = 2.ToString();
            textBox7.Text = 15.ToString();
            a1.setKellonkayntisuuntaalaspain(true);
            textBox6.Text = 60.ToString();
            textBox8.Text = 3.ToString();
            textBox9.Text = 24.ToString();
            textBox10.Text = 14.ToString();
            textBox11.Text = 5.ToString();
            textBox13.Text = 2.ToString();
            textBox12.Text = 2.ToString();
            textBox14.Text = 0.ToString();
            textBox15.Text = 0.ToString();
            textBox16.Text = 0.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1.setKellonkayntisuuntaalaspain(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a1.setKellonkayntisuuntaalaspain(false);
                
        }

        private void ohjeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ohjekirja o = new Ohjekirja();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
