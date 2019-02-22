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
    public partial class taulunOhjaus : Form
    {

        private string[] lista;
        private string koti;
        private string vieras;
        private tulostauluNaytto t1;
        

        public taulunOhjaus(string[] lista, string kotiKuva, string vierasKuva)
        {
            InitializeComponent();

            this.lista = lista;
            this.koti = kotiKuva;
            this.vieras = vierasKuva;

            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new tulostauluNaytto(lista, koti, vieras);
            t1.aloita();
            t1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.lisaaPiste();
        }
    }
}
