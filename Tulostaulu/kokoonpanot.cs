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

        string[] pelaajatKoti = new string[11];
        string[] pelaajatVieras = new string[11];
        string kotijoukkueKuva;
        string vierasjoukkueKuva;

        private void buttonK1_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(textBoxK1.Text))
            {
                MessageBox.Show("Valitse pelaajat");
            }
            else if (String.IsNullOrEmpty(textBoxK4.Text))
            {
                MessageBox.Show("Valitse pelaajat");
            }
            /*else
            {
                for (int i = 0; i < pelaajatKoti.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(pelaajatKoti[i]))
                    {
                        MessageBox.Show("Tekstitiedostossa on tyhjä rivi rivillä: " + i + ". Hae tiedosto, jossa ei ole tyhjiä rivejä");
                        Array.Clear(pelaajatKoti, 0, pelaajatKoti.Length);
                    }
                    
                }
                
            }*/

            if (pelaajatKoti.Length > 11)
            {
                MessageBox.Show("Liikaa pelaajia kotipelaajien tiedostossa, hae uusi tiedosto");
                Array.Clear(pelaajatKoti, 0, pelaajatKoti.Length);
            }
            else if(pelaajatVieras.Length > 11)
            {
                MessageBox.Show("Liikaa pelaajia vieraspelaajien tiedostossa, hae uusi tiedosto");
                Array.Clear(pelaajatKoti, 0, pelaajatKoti.Length);
            }
            /*else if(pelaajatKoti.Length < 24)
            {
                MessageBox.Show("Liian vähän pelaajia, hae uusi tiedosto");
                Array.Clear(pelaajatKoti, 0, pelaajatKoti.Length);
            }*/

            else if (String.IsNullOrEmpty(kotijoukkueKuva) || String.IsNullOrEmpty(vierasjoukkueKuva))
            {
                MessageBox.Show("Joukkueen kuva puuttuu");
            }
            else
            {
                taulunOhjaus t2 = new taulunOhjaus(pelaajatKoti, pelaajatVieras, kotijoukkueKuva, vierasjoukkueKuva, asetukset);
                t2.Show();
                Close();
            }
        }


        private void buttonK2_Click(object sender, EventArgs e)
        {
           
            //Avataan file-haku ja lisätään tekstitiedoston pelaajat listaan
            openFileDialog1.Filter = "Tekstitiedosto |*.txt;";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBoxK1.Text = openFileDialog1.FileName;
                pelaajatKoti = System.IO.File.ReadAllLines(@openFileDialog1.FileName);  
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

        private void ohjeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ohjekirja o = new Ohjekirja();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Avataan file-haku ja lisätään tekstitiedoston pelaajat listaan
            openFileDialog1.Filter = "Tekstitiedosto |*.txt;";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxK4.Text = openFileDialog1.FileName;
                pelaajatVieras = System.IO.File.ReadAllLines(@openFileDialog1.FileName);
            }
        }
    }
}



 
