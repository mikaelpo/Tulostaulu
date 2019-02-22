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
            ArrayList a = new ArrayList();
            int i = a1.getNeljanneksienmaara();
            a.Add(i);
            kokoonpanot k1 = new kokoonpanot(a);
            k1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a1.setNeljanneksienmaara(Convert.ToInt32(textBox2.Text));
        }
    }
}
