using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcticGlacier
{
    public partial class Animacja : Form
    {
        public Animacja()
        {
            InitializeComponent();
        }

        private void Animacja_Load(object sender, EventArgs e)
        {
            string pelnaSciezka = Path.Combine(Directory.GetCurrentDirectory(), "GlacierPhotos\\seaice_1979_720x360.jpg");
            pbZdj.Image = Image.FromFile(pelnaSciezka);
        }
        private bool czyKliknięty = false;
        private int currInd = 0;
        List<double> powierzchnia = Form1.daneMin;
        private void btStart_Click(object sender, EventArgs e)
        {
            czyKliknięty = false;
            string pelnaSciezka = Path.Combine(Directory.GetCurrentDirectory(), "GlacierPhotos");
            string[] pliki = Directory.GetFiles(pelnaSciezka);
            for (int i = currInd; i < pliki.Length; i++)
            {
                currInd = i;
                if (czyKliknięty) break;
                pbZdj.Image = Image.FromFile(Path.Combine(pelnaSciezka, pliki[i]));
                lbRok.Text = "Rok: " + pliki[i].Substring(73,4);
                lbPowierzchnia.Text = powierzchnia[i].ToString() + " mln km²";
                Application.DoEvents();
                Thread.Sleep(1000); 
                if(i == pliki.Length - 1) currInd = 0;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            czyKliknięty = true;
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            czyKliknięty = false;
            string pelnaSciezka = Path.Combine(Directory.GetCurrentDirectory(), "GlacierPhotos\\seaice_1979_720x360.jpg");
            pbZdj.Image = Image.FromFile(pelnaSciezka);
            currInd = 0;
            lbRok.Text = "Rok: 1979";
            lbPowierzchnia.Text = powierzchnia[0].ToString() + " mln km²";
        }
    }
}
