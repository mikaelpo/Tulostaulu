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
        private oletusasetukset a1 = new oletusasetukset(0);
        public asetukset()
        {
            InitializeComponent();
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
           
            kokoonpanot k1 = new kokoonpanot(a1);
            k1.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            a1.setNeljanneksienmaara(Convert.ToInt32(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = 10.ToString();
            textBox2.Text = 4.ToString();
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

        }
    }
}
