﻿using System;
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
        private bool vainPelaajaPisteet = false;
        private bool vainPelaajaVirheet = false;
        private tulostauluNaytto t1;
        private oletusasetukset asetukset2 = new oletusasetukset();

        //Kellon muuttujat
        private int timeHyokkaysMm;
        private int timeHyokkaysSs;
        private int timeHyokkaysMs;
        private bool peliKelloKaynnissa = false;
        private bool hyokkaysKelloNakyvissa = true;
        private bool hyokkaysKellonMsNakyvissa = false;

        private bool odotusKelloKayntiin = false;
        private bool onkoTauko = false;
        private bool hyokkaysAikaNollassa = false;
        bool soitetaankoKello = true;



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

            //Hyökkäyskellon millisekuntilabelit pois näkyvistä
            labelHMS.Visible = false;
            labelHK2.Visible = false;

            timeHyokkaysSs = asetukset2.getHyokkaysaika1();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Haluatko käynnistää odotuskellon?", "Huomautus", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                odotusKelloKayntiin = true;
                MessageBox.Show("Laita aika, jonka haluat odottaa ennen pelin alkamista ohjaustauluun ja paina sen jälkeen 'muuta aika', sitten käynnistä kello");
            }
            else if (dialogResult == DialogResult.No)
            {
                odotusKelloKayntiin = false;
            }
            t1 = new tulostauluNaytto(lista, lista2, koti, vieras, asetukset2, this, odotusKelloKayntiin);
            t1.Show();
        }

        //Kellon ohjaus näppäimistöltä tulostaululla
        private void taulunOhjaus_KeyDown(object sender, KeyEventArgs e)
        {
            try
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
            catch (NullReferenceException) { MessageBox.Show("Avaa tulostaulunäyttö ennen ajan aloittamista, pysäyttämistä tai resetointia"); }
        }

        //Kotijoukkuueen pisteiden lisäys
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK1(vainPelaajaPisteet);
            }catch(Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK2(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK3(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK4(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK5(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK6(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK7(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK8(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK9(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK10(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK11(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteK12(vainPelaajaPisteet);
            }
            catch (Exception)
            {
                MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä");
            }
        }

        //Kotijoukkueen pisteiden vähennykset
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK1(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK2(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK3(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK4(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK5(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK6(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK7(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK8(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK9(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK10(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK11(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteK12(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        //Vierasjoukkueen pisteiden lisäys
        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV1(vainPelaajaPisteet);
            }
            catch (Exception){MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV2(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV3(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV4(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV5(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV6(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV7(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV8(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV9(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV10(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV11(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteV12(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }
       
        //Vierasjoukkueen pisteiden poisto
        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV1(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV2(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV3(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV4(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV5(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV6(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV7(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV8(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV9(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV10(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV11(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            try
            {
                t1.poistaPisteV12(vainPelaajaPisteet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }
        //Ohjekirjan aukaisu
        private void ohjeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ohjekirja ohje = new Ohjekirja();
        }

        //Kellon muuttaminen
        private void button106_Click(object sender, EventArgs e)
        {
            try
            {
                if (onkoTauko)
                {
                    if (String.IsNullOrEmpty(textBoxMin.Text))
                    {
                        textBoxMin.Text = 0.ToString();
                    }
                    t1.muutaKello(Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxSek.Text), onkoTauko);
                    onkoTauko = false;
                }
                else
                {
                    if (String.IsNullOrEmpty(textBoxMin.Text))
                    {
                        textBoxMin.Text = 0.ToString();
                    }
                    t1.muutaKello(Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxSek.Text), onkoTauko);
                }

            }
            catch (NullReferenceException) { MessageBox.Show("Avaa tulostaulunäyttö ennen ajan muuttamista"); }
            catch (FormatException) { MessageBox.Show("Syötemerkit eivät ole kokonaislukuja. Korjaa merkit ja kokeile uudelleen"); }
        }

        //Joukkueiden pisteiden lisäys ja vähennys
        //Koti
        private void button105_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteKotijoukkue();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button104_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaPisteKotijoukkue();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }
        //Vieras
        private void button99_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaPisteVierasjoukkue();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen lisäämistä"); }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaPisteVierasjoukkue();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen pisteen vähentämistä"); }
        }
        //checkBox, jolla katsotaan haluaako käyttäjä lisätä/vähentää pisteitä vain pelaajille joukkuepisteitä muuttamatta 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPiste.Checked == true)
            {
                vainPelaajaPisteet = true;
            }
            if (checkBoxPiste.Checked == false)
            {
                vainPelaajaPisteet = false;              
            }
        }
        

        //checkBox, jolla katsotaan haluaako käyttäjä lisätä/vähentää virheitä vain pelaajille joukkuevirheitä muuttamatta 
        private void checkBoxVirhe_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxVirhe.Checked == true)
            {
                vainPelaajaVirheet = true;
            }
            if (checkBoxVirhe.Checked == false)
            {
                vainPelaajaVirheet = false;
            }
        }


        //Virheiden lisäys kotijoukkue
        private void button50_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti1(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti2(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti3(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti4(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti5(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti6(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti7(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti8(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti9(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti10(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti11(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti12(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        //Virheiden vähennys kotijoukkue
        private void button62_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti1(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti2(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti3(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti4(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti5(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti6(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti7(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti8(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti9(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti10(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti11(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti12(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }
        //Vierasjoukkueen virheen lisäys
        private void button74_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras1(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras2(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras3(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras4(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras5(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras6(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras7(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras8(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras9(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras10(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras11(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras12(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
            
        }
        //Vierasjoukkueen pelaajien virheiden vähentäminen
        private void button86_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras1(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras2(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras3(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras4(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras5(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras6(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras7(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras8(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras9(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras10(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras11(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras12(vainPelaajaVirheet);
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }

        //Vierasjoukkueen virheen lisäys
        private void button101_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheVieras();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }
        //Vierasjoukkueen virheen poisto
        private void button100_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheVieras();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }
        //Kotijoukkueen virheen lisäys
        private void button103_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaVirheKoti();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen lisäämistä"); }
        }
        //Kotijoukkueen virheen poisto
        private void button102_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaVirheKoti();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen virheen vähentämistä"); }
        }



        //KOtijoukkueen aikalisän lisäys ja vähennys
        private void button108_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaAikalisaKoti();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen aikalisän lisäystä"); }
        }

        private void button107_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaAikalisaKoti();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen aikalisän vähentämistä"); }
        }

       //Vierasjoukkueen aikalisän lisäys ja vähennys
        private void button110_Click(object sender, EventArgs e)
        {
            try
            {
                t1.lisaaAikalisaVieras();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen aikalisän lisäystä"); }
        }

        private void button109_Click(object sender, EventArgs e)
        {
            try
            {
                t1.vahennaAikalisaVieras();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen aikalisän vähentämistä"); }
        }

        
        
        //Hyökkäyskellon toiminta
        public void timer1Tick()
        {
            if (peliKelloKaynnissa)
            {
                timeHyokkaysMs--;

                if (timeHyokkaysMs == -1)
                {
                    timeHyokkaysSs--;
                    timeHyokkaysMs = 9;
                }
                if (timeHyokkaysSs == -1)
                {
                    timeHyokkaysMm--;
                    timeHyokkaysSs = 59;
                }
                if (timeHyokkaysMm == 0 && timeHyokkaysSs == 5 && timeHyokkaysMs == 0)
                {
                    labelHMS.Visible = true;
                    labelHK2.Visible = true;
                    hyokkaysKellonMsNakyvissa = true;
                }
                if (timeHyokkaysMm == 0 && timeHyokkaysSs == 0 && timeHyokkaysMs == 0)
                {
                    hyokkaysAikaNollassa = true;
                    if (soitetaankoKello)
                    {
                        t1.soitaSummeri1();
                    }
                }
                if (timeHyokkaysMm < 0)
                {
                    timeHyokkaysMm = 0;
                  
                }
            }
         
            drawTime();
        }

        private void drawTime()
        {
            if (hyokkaysAikaNollassa == false)
            {
                labelHMS.Text = String.Format("{0}", timeHyokkaysMs);
                labelHSS.Text = String.Format("{0:00}", timeHyokkaysSs);
                labelHMM.Text = String.Format("{0:00}", timeHyokkaysMm);
            }
            else if(hyokkaysAikaNollassa == true)
            {
                labelHMS.Text = String.Format("{0}", 0);
                labelHSS.Text = String.Format("{0:00}", 0);
                labelHMM.Text = String.Format("{0:00}", 0);
            }
        }
        //Hyökkäysaika 1
        private void button111_Click(object sender, EventArgs e)
        {
            hyokkaysAikaNollassa = false;
            timeHyokkaysSs = asetukset2.getHyokkaysaika1();
            labelHSS.Text = asetukset2.getHyokkaysaika1().ToString(); 
            if (timeHyokkaysSs <= 5)
            {
                labelHMS.Visible = true;
                labelHK2.Visible = true;
                hyokkaysKellonMsNakyvissa = true;
            }
            if(timeHyokkaysSs > 5)
            {
                labelHMS.Visible = false;
                labelHK2.Visible = false;
                hyokkaysKellonMsNakyvissa = false;
            }
        }
        //Hyökkäysaika 2
        private void button112_Click(object sender, EventArgs e)
        {
            hyokkaysAikaNollassa = false;
            timeHyokkaysSs = asetukset2.getHyokkausaika2();
            labelHSS.Text = asetukset2.getHyokkausaika2().ToString();
            if (timeHyokkaysSs <= 5)
            {
                labelHMS.Visible = true;
                labelHK2.Visible = true;
                hyokkaysKellonMsNakyvissa = true;
            }
            if (timeHyokkaysSs > 5)
            {
                labelHMS.Visible = false;
                labelHK2.Visible = false;
                hyokkaysKellonMsNakyvissa = false;
            }
        }
        //Hyökkäysajan piilottaminen
        private void button113_Click(object sender, EventArgs e)
        {
            
            if(hyokkaysKelloNakyvissa == true)
            {
                soitetaankoKello = false;
                hyokkaysKelloNakyvissa = false;
                labelHMM.Visible = false;
                labelHK1.Visible = false;
                labelHSS.Visible = false;              
                labelHMS.Visible = false;
                labelHK2.Visible = false;
            }
            else
            {
                soitetaankoKello = true;
                hyokkaysKelloNakyvissa = true;
                labelHMM.Visible = true;
                labelHK1.Visible = true;
                labelHSS.Visible = true;
                if (hyokkaysKellonMsNakyvissa)
                {
                    labelHMS.Visible = true;
                    labelHK2.Visible = true;
                }
            }
        }

        public void kaynnistaHyokkaysKello()
        {
            peliKelloKaynnissa = true;           
        }
        public void sammutaHyokkaysKello()
        {
            peliKelloKaynnissa = false;
        }
        public void hyokkaysKelloReset()
        {
            hyokkaysAikaNollassa = false;
            peliKelloKaynnissa = false;
            timeHyokkaysMs = 0;
            labelHMS.Text = timeHyokkaysMs.ToString();
            timeHyokkaysSs = asetukset2.getHyokkaysaika1();
            labelHSS.Text = asetukset2.getHyokkaysaika1().ToString();
            if (timeHyokkaysSs <= 5)
            {
                labelHMS.Visible = true;
                labelHK2.Visible = true;
            }
            if (timeHyokkaysSs > 5)
            {
                labelHMS.Visible = false;
                labelHK2.Visible = false;
            }
        }
        //Muutetaan hyökkäyskellon aikaa textboxin kautta
        private void buttonMuutaHaika_Click(object sender, EventArgs e)
        {
            try
            {
                
                timeHyokkaysSs = Convert.ToInt32(textBoxHaika.Text);
                hyokkaysAikaNollassa = false;
                if (timeHyokkaysSs <= 5)
                {
                    labelHMS.Visible = true;
                    labelHK2.Visible = true;
                    hyokkaysKellonMsNakyvissa = true;
                }
                if (timeHyokkaysSs > 5)
                {
                    labelHMS.Visible = false;
                    labelHK2.Visible = false;
                    hyokkaysKellonMsNakyvissa = false;
                }
                labelHSS.Text = timeHyokkaysSs.ToString();
            }catch (FormatException) { MessageBox.Show("Syötemerkit eivät ole kokonaislukuja. Korjaa merkit ja kokeile uudelleen"); }

        } 

        //Mikä tauko valitaan kun neljännes loppuu
        public void taukoEhdotus(int mikaTauko)
        {
            onkoTauko = true;
            if (mikaTauko == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Haluatko pitää lyhyen tauon?", "Huomautus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    t1.kaynnistaLyhytTauko(onkoTauko);
                }
                else if (dialogResult == DialogResult.No)
                {                    
                    MessageBox.Show("Laita aika, jonka haluat odottaa ennen pelin alkamista ohjaustauluun ja paina sen jälkeen 'muuta aikaa', sitten käynnistä kello");
                }
            }
            else if(mikaTauko == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Haluatko pitää pitkän tauon?", "Huomautus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    t1.kaynnistaPitkaTauko(onkoTauko);
                }
                else if (dialogResult == DialogResult.No)
                {                   
                    MessageBox.Show("Laita aika, jonka haluat odottaa ennen pelin alkamista ohjaustauluun ja paina sen jälkeen 'muuta aikaa', sitten käynnistä kello");
                }
            }
        }

        private void button114_Click(object sender, EventArgs e)
        {
            try
            {
                t1.kokonaytto();
            }catch(Exception) { MessageBox.Show("Avaa tulostaulunäyttö ennen kokonäytölle laittamista"); }
        }

        private void buttonSummeri_Click(object sender, EventArgs e)
        {
            try
            {
                t1.soitaSummeri2();
            }
            catch (Exception) { MessageBox.Show("Avaa tulostaulu ennen summerin soittamista"); }
        }

        private void ohjeetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ohjekirja o = new Ohjekirja();
            o.Show();
        }
    }
}
