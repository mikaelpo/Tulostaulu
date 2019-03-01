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
        private oletusasetukset a1 = new oletusasetukset(4,10, 5, true, 2, 15, 2, 1, 3, 1, 1, 5, 1, 1 );
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
    }
}
