using System.Management.Instrumentation;

namespace ArcticGlacier
{
    partial class Form1
    {
        public ZnajdzLinkObrazu znajdzLink;
        public GlacierImageDownloader GlacierImageDownloader;

        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbZdjecieLodowca = new System.Windows.Forms.PictureBox();
            this.wykrArcSeeEx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbPrzewiduj = new System.Windows.Forms.TextBox();
            this.btPrzewiduj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbPowierzchnia = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btZapisz = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btAnimacja = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecieLodowca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykrArcSeeEx)).BeginInit();
            this.SuspendLayout();
            // 
            // pbZdjecieLodowca
            // 
            this.pbZdjecieLodowca.Location = new System.Drawing.Point(12, 12);
            this.pbZdjecieLodowca.Name = "pbZdjecieLodowca";
            this.pbZdjecieLodowca.Size = new System.Drawing.Size(548, 642);
            this.pbZdjecieLodowca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZdjecieLodowca.TabIndex = 0;
            this.pbZdjecieLodowca.TabStop = false;
            this.toolTip2.SetToolTip(this.pbZdjecieLodowca, resources.GetString("pbZdjecieLodowca.ToolTip"));
            // 
            // wykrArcSeeEx
            // 
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.Title = "Year";
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.Enabled = false;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.Title = "Million Square km";
            chartArea7.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea7.BorderColor = System.Drawing.Color.White;
            chartArea7.Name = "ChartArea1";
            this.wykrArcSeeEx.ChartAreas.Add(chartArea7);
            this.wykrArcSeeEx.Location = new System.Drawing.Point(566, 12);
            this.wykrArcSeeEx.Name = "wykrArcSeeEx";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Name = "Series1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Name = "Series2";
            this.wykrArcSeeEx.Series.Add(series13);
            this.wykrArcSeeEx.Series.Add(series14);
            this.wykrArcSeeEx.Size = new System.Drawing.Size(569, 361);
            this.wykrArcSeeEx.TabIndex = 1;
            this.wykrArcSeeEx.Text = "chart1";
            // 
            // tbPrzewiduj
            // 
            this.tbPrzewiduj.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPrzewiduj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrzewiduj.ForeColor = System.Drawing.Color.White;
            this.tbPrzewiduj.Location = new System.Drawing.Point(963, 391);
            this.tbPrzewiduj.Name = "tbPrzewiduj";
            this.tbPrzewiduj.Size = new System.Drawing.Size(44, 22);
            this.tbPrzewiduj.TabIndex = 2;
            // 
            // btPrzewiduj
            // 
            this.btPrzewiduj.BackColor = System.Drawing.Color.Gray;
            this.btPrzewiduj.ForeColor = System.Drawing.Color.White;
            this.btPrzewiduj.Location = new System.Drawing.Point(1013, 387);
            this.btPrzewiduj.Name = "btPrzewiduj";
            this.btPrzewiduj.Size = new System.Drawing.Size(91, 28);
            this.btPrzewiduj.TabIndex = 4;
            this.btPrzewiduj.Text = "Zatwierdź";
            this.btPrzewiduj.UseVisualStyleBackColor = false;
            this.btPrzewiduj.Click += new System.EventHandler(this.btPrzewiduj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(601, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wizualizacja powierzchni w kolejnych latach (wpisz rok):";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.Gray;
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.Location = new System.Drawing.Point(1013, 456);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(91, 28);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Resetuj";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbPowierzchnia
            // 
            this.lbPowierzchnia.AutoSize = true;
            this.lbPowierzchnia.ForeColor = System.Drawing.Color.White;
            this.lbPowierzchnia.Location = new System.Drawing.Point(601, 428);
            this.lbPowierzchnia.Name = "lbPowierzchnia";
            this.lbPowierzchnia.Size = new System.Drawing.Size(272, 32);
            this.lbPowierzchnia.TabIndex = 8;
            this.lbPowierzchnia.Text = "Obliczona, minimalna powierzchnia lodowca \r\ndla podanego roku: ";
            this.toolTip1.SetToolTip(this.lbPowierzchnia, resources.GetString("lbPowierzchnia.ToolTip"));
            // 
            // btZapisz
            // 
            this.btZapisz.BackColor = System.Drawing.Color.Gray;
            this.btZapisz.ForeColor = System.Drawing.Color.White;
            this.btZapisz.Location = new System.Drawing.Point(1013, 422);
            this.btZapisz.Name = "btZapisz";
            this.btZapisz.Size = new System.Drawing.Size(91, 28);
            this.btZapisz.TabIndex = 7;
            this.btZapisz.Text = "Zapisz";
            this.toolTip3.SetToolTip(this.btZapisz, "Zapisuje dane z wykresu do pliku \"dane.txt\" w lokalizacji projektu.");
            this.btZapisz.UseVisualStyleBackColor = false;
            this.btZapisz.Click += new System.EventHandler(this.btZapisz_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(24, 628);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(445, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kliknij aby uzyskać więcej wizualizacji wraz z dogłębną analizą.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btAnimacja
            // 
            this.btAnimacja.BackColor = System.Drawing.Color.Gray;
            this.btAnimacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAnimacja.ForeColor = System.Drawing.Color.White;
            this.btAnimacja.Location = new System.Drawing.Point(778, 565);
            this.btAnimacja.Name = "btAnimacja";
            this.btAnimacja.Size = new System.Drawing.Size(158, 52);
            this.btAnimacja.TabIndex = 10;
            this.btAnimacja.Text = "Animacja";
            this.toolTip4.SetToolTip(this.btAnimacja, "Kliknij, aby uruchomić animację zmian wygląu satelitarnego Arktyki na przełomie l" +
        "at.\r\n");
            this.btAnimacja.UseVisualStyleBackColor = false;
            this.btAnimacja.Click += new System.EventHandler(this.btAnimacja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1147, 666);
            this.Controls.Add(this.btAnimacja);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbPowierzchnia);
            this.Controls.Add(this.btZapisz);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPrzewiduj);
            this.Controls.Add(this.tbPrzewiduj);
            this.Controls.Add(this.wykrArcSeeEx);
            this.Controls.Add(this.pbZdjecieLodowca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecieLodowca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykrArcSeeEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbZdjecieLodowca;
        private System.Windows.Forms.DataVisualization.Charting.Chart wykrArcSeeEx;
        private System.Windows.Forms.TextBox tbPrzewiduj;
        private System.Windows.Forms.Button btPrzewiduj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btZapisz;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label lbPowierzchnia;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btAnimacja;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

