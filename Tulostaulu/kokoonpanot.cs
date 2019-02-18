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

        string[] lines;
        string osoite = " ";
        string osoite2;

        private void buttonK1_Click(object sender, EventArgs e)
        {
            tulostauluNaytto t1 = new tulostauluNaytto(lines, osoite);
            t1.Show();
            Close();
        }

        private void buttonK2_Click(object sender, EventArgs e)
        {
            //string teksti = textBoxK1.Text;

            //label4.Text = teksti;

            

            openFileDialog1.Filter = "Tekstitiedosto |*.txt;";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBoxK1.Text = openFileDialog1.FileName;

                lines = System.IO.File.ReadAllLines(@openFileDialog1.FileName);
                label1.Text = lines[0];
                label2.Text = lines[1];
                label3.Text = lines[2];
            }

        }

        private void buttonK3_Click(object sender, EventArgs e)
        {
              osoite = textBoxK2.Text;
        }
    }
}



 
