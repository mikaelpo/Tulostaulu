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
    public partial class kokoonpanot : Form
    {
        private oletusasetukset asetukset = new oletusasetukset();
        
        public kokoonpanot(oletusasetukset asetukset)
        {
            InitializeComponent();
            
            this.asetukset = asetukset;
        }

        string[] lines = new string[23];
        string kotijoukkueKuva;
        string vierasjoukkueKuva;

        private void buttonK1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(lines[i]))
                {
                    MessageBox.Show("Tekstitiedostossa on tyhjä rivi rivillä: " + i + ". Hae tiedosto, jossa ei ole tyhjiä rivejä");
                    Array.Clear(lines, 0, lines.Length);
                }
            }
            
            if (String.IsNullOrEmpty(textBoxK1.Text))
            {
                MessageBox.Show("Valitse pelaajat");
            }
       
            else if (lines.Length < 24)
            {
                MessageBox.Show("Ei tarpeeksi pelaajia, hae uusi tiedosto");
                Array.Clear(lines, 0, lines.Length);
            }
           
            else if (String.IsNullOrEmpty(kotijoukkueKuva) || String.IsNullOrEmpty(vierasjoukkueKuva))
            {
                MessageBox.Show("Joukkueen kuva puuttuu");
            }
            else
            {
                taulunOhjaus t2 = new taulunOhjaus(lines, kotijoukkueKuva, vierasjoukkueKuva, asetukset);
                t2.Show();
                Close();
            }
        }


        private void tarkastaVirheet()
        {
            
            
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



 
