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
    public partial class kokoonpanot : Form
    {
        public kokoonpanot()
        {
            InitializeComponent();
        }

        private void buttonK1_Click(object sender, EventArgs e)
        {
            tulostauluNaytto t1 = new tulostauluNaytto();
            t1.Show();
            Close();
        }
    }
}
