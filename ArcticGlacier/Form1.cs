using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml;
using System.IO;
using System.Globalization;
using System.Threading;

namespace ArcticGlacier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void WyswietlObraz()
        {
            ZnajdzLinkObrazu link = new ZnajdzLinkObrazu();
            string URLDoObrazu = link.FnZnajdzLinkObrazu("https://nsidc.org/data/seaice_index");
            GlacierImageDownloader imageDownloader = new GlacierImageDownloader();
            string sciezkaLokalnaObrazu = imageDownloader.PobierzObraz(URLDoObrazu, "E:\\3 sem\\.NET\\zdlodowca.png");

            if (System.IO.File.Exists(sciezkaLokalnaObrazu))
            {
                pbZdjecieLodowca.Image = Image.FromFile(sciezkaLokalnaObrazu);
            }
            else
            {
                MessageBox.Show("Błąd przy wyświetlaniu obrazu.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WyswietlObraz();
            kreslWykres();
            this.BackColor = Color.FromArgb(79, 79, 79);
        }

        public static List<double> daneMin = new List<double>();
        List<double> daneMax = new List<double>();
        void kreslWykres()
        {
            var sciezkaDanych = @"E:\3 sem\.NET\ArcticGlacier\arctic-sea-ice\arctic-sea-ice-v2.xlsx";

            

            wykrArcSeeEx.Series[0].Points.Clear();

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(sciezkaDanych)))
            {
                if(!File.Exists(sciezkaDanych)) throw new FileNotFoundException("Plik nie istnieje: " +  sciezkaDanych);

                var separator = CultureInfo.InvariantCulture;

                try
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        var cellValue = worksheet.Cells[row, 4].Text;
                        if(double.TryParse(cellValue, NumberStyles.Any, separator, out double parsedvalue))
                        {
                            daneMin.Add(parsedvalue);
                        }
                        else
                        {
                            MessageBox.Show($"Błąd konwersji w wierszu {row}: {cellValue} nie jest liczbą.");
                        }
                    }
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        var cellValue = worksheet.Cells[row, 5].Text;
                        if (double.TryParse(cellValue, NumberStyles.Any, separator, out double parsedvalue))
                        {
                            daneMax.Add(parsedvalue);
                        }
                        else
                        {
                            MessageBox.Show($"Błąd konwersji w wierszu {row}: {cellValue} nie jest liczbą.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd odczytu danych z pliku .xlsx: " + ex.Message);
                }
                

            }

            wykrArcSeeEx.ChartAreas[0].AxisX.Interval = 5;
            wykrArcSeeEx.ChartAreas[0].BackColor = Color.FromArgb(79,79,79);
            wykrArcSeeEx.BackColor = Color.FromArgb(79, 79, 79);
            tbPrzewiduj.BackColor = Color.FromArgb(79, 79, 79);
            btPrzewiduj.BackColor = Color.FromArgb(79, 79, 79);
            btReset.BackColor = Color.FromArgb(79, 79, 79);
            btZapisz.BackColor = Color.FromArgb(79, 79, 79);

            for (int x = 1979; x <= 2024; x++)
            {
                wykrArcSeeEx.Series[0].MarkerStyle = MarkerStyle.Circle;

                double xValue = x;
                //argumenty.Add(xValue);
                double wartosc = daneMin[x - 1979]; 
                int indeks = Convert.ToInt32(x);
                var point = new DataPoint(xValue, wartosc);
                wykrArcSeeEx.Series[0].Points.Add(point);
            }
            for (int x = 1979; x <= 2024; x++)
            {
                wykrArcSeeEx.Series[1].MarkerStyle = MarkerStyle.Circle;

                double xValue = x;
                //argumenty.Add(xValue);
                double wartosc = daneMax[x - 1979];
                int indeks = Convert.ToInt32(x);
                var point = new DataPoint(xValue, wartosc);
                wykrArcSeeEx.Series[1].Points.Add(point);
            }


        }

        private void btPrzewiduj_Click(object sender, EventArgs e)
        {
            wykrArcSeeEx.Series[0].Points.Clear();
            wykrArcSeeEx.Series[1].Points.Clear();
            //Przewidywana wartość na każdy kolejny rok liczona jest na podstawie wzoru: y=−0.0778⋅x+161.672
            //Wzór ten jest wynikiem analizy regresji liniowej zbioru danych z lat 1979-2024.
            string textBox = tbPrzewiduj.Text;
            int rok = Convert.ToInt32(textBox);
            Random random = new Random();
            for (int i = 2024; i<= rok; i++)
            {
                double randomDouble = random.NextDouble();
                double wartoscPrzewMin = ((-0.0778 * i + 161.627) - 1) + (randomDouble * (((-0.0778 * i + 161.627) + 1) - ((-0.0778 * i + 161.627) - 1)));
                daneMin.Add(wartoscPrzewMin);
                double randomDouble1 = random.NextDouble();
                double wartoscPrzewMax = ((-0.04084 * i + 96.80384) - 0.3) + (randomDouble1 * (((-0.04084 * i + 96.80384) + 0.3) - ((-0.04084 * i + 96.80384) - 0.3))); 
                daneMax.Add(wartoscPrzewMax);
            }
            var point = new DataPoint();
            //for (int x = 1979; x <= rok; x++)
            //{
            //    wykrArcSeeEx.Series[0].MarkerStyle = MarkerStyle.Circle;

            //    double xValue = x;
            //    //argumenty.Add(xValue);
            //    if (x >= 2024)
            //    {
            //        double wartoscDodana = daneMin[x - 1979];
            //        point = new DataPoint(xValue, wartoscDodana);
            //        wykrArcSeeEx.Series[0].Points.Add(point);
            //        Application.DoEvents();
            //        Thread.Sleep(200);
            //    }
            //    else
            //    {
            //        double wartosc = daneMin[x - 1979];
            //        point = new DataPoint(xValue, wartosc);
            //        wykrArcSeeEx.Series[0].Points.Add(point);
            //    }
            //}
            for (int x = 1979; x <= rok; x++)
            {
                wykrArcSeeEx.Series[1].MarkerStyle = MarkerStyle.Circle;

                double xValue = x;
                //argumenty.Add(xValue);
                if (x >= 2024)
                {
                    double wartoscDodana = daneMax[x - 1979];
                    point = new DataPoint(xValue, wartoscDodana);
                    wykrArcSeeEx.Series[1].Points.Add(point);

                    double wartoscDodana1 = daneMin[x - 1979];
                    point = new DataPoint(xValue, wartoscDodana1);
                    wykrArcSeeEx.Series[0].Points.Add(point);

                    Application.DoEvents();
                    Thread.Sleep(400);


                }
                else
                {
                    double wartosc = daneMax[x - 1979];
                    point = new DataPoint(xValue, wartosc);
                    wykrArcSeeEx.Series[1].Points.Add(point);

                    double wartosc1 = daneMin[x - 1979];
                    point = new DataPoint(xValue, wartosc1);
                    wykrArcSeeEx.Series[0].Points.Add(point);


                }

            }
            lbPowierzchnia.Text = lbPowierzchnia.Text + daneMin[daneMin.Count() - 1].ToString("F3") + " mln km²";
            btPrzewiduj.Enabled = false;
            tbPrzewiduj.Enabled = false;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            wykrArcSeeEx.Series[0].Points.Clear();
            wykrArcSeeEx.Series[1].Points.Clear();
            for (int x = 1979; x <= 2024; x++)
            {
                wykrArcSeeEx.Series[0].MarkerStyle = MarkerStyle.Circle;

                double xValue = x;
                //argumenty.Add(xValue);
                double wartosc = daneMin[x - 1979];
                int indeks = Convert.ToInt32(x);
                var point = new DataPoint(xValue, wartosc);
                wykrArcSeeEx.Series[0].Points.Add(point);
            }
            for (int x = 1979; x <= 2024; x++)
            {
                wykrArcSeeEx.Series[1].MarkerStyle = MarkerStyle.Circle;

                double xValue = x;
                //argumenty.Add(xValue);
                double wartosc = daneMax[x - 1979];
                int indeks = Convert.ToInt32(x);
                var point = new DataPoint(xValue, wartosc);
                wykrArcSeeEx.Series[1].Points.Add(point);
            }
            tbPrzewiduj.Clear();
            btPrzewiduj.Enabled = true;
            tbPrzewiduj.Enabled = true;
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dane.txt"));
                sw.WriteLine("ROK  " + "MaxEx  " + "MinEx");
                int j = 1979;
                for (int i = 0; i < daneMax.Count; i++)
                {
                    sw.Write(j + " " + daneMax[i].ToString("F3") + " " + daneMin[i].ToString("F3") + "\n");
                    j++;
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu do pliku: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.polarview.aq/arctic");
            linkLabel1.LinkVisited = true;
        }

        private void btAnimacja_Click(object sender, EventArgs e)
        {
            Animacja animacja = new Animacja();
            animacja.Show();
            
        }
    }

}
