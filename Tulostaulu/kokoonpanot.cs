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
        string kotijoukkueKuva = " ";
        string vierasjoukkueKuva = " ";

        private void buttonK1_Click(object sender, EventArgs e)
        {
            
            taulunOhjaus t2 = new taulunOhjaus(lines, kotijoukkueKuva, vierasjoukkueKuva);
            t2.Show();
            Close();
        }

        private void buttonK2_Click(object sender, EventArgs e)
        {
            //Avataan file-haku ja lisätään tekstitiedoston pelaajat listaan
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
        {   //Haetaan kotijoukkueen kuvatiedosto
            openFileDialog1.Filter = "Kuvatiedosto |*.jpg;*.jpeg;*.png;";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxK2.Text = openFileDialog1.FileName;
                kotijoukkueKuva = openFileDialog1.FileName;
            }
        }

        private void buttonK4_Click(object sender, EventArgs e)
        {   // Haetaan vierasjoukkueen kuva
            openFileDialog1.Filter = "Kuvatiedosto |*.jpg;*.jpeg;*.png;";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxK3.Text = openFileDialog1.FileName;
                vierasjoukkueKuva = openFileDialog1.FileName;
            }
        }

  
    }
}



 
