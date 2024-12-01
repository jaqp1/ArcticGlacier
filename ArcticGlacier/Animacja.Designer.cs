namespace ArcticGlacier
{
    partial class Animacja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbZdj = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.lbRok = new System.Windows.Forms.Label();
            this.lbPowierzchnia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdj)).BeginInit();
            this.SuspendLayout();
            // 
            // pbZdj
            // 
            this.pbZdj.Location = new System.Drawing.Point(-5, -4);
            this.pbZdj.Name = "pbZdj";
            this.pbZdj.Size = new System.Drawing.Size(817, 366);
            this.pbZdj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZdj.TabIndex = 0;
            this.pbZdj.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btStart.ForeColor = System.Drawing.Color.White;
            this.btStart.Location = new System.Drawing.Point(257, 325);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(91, 28);
            this.btStart.TabIndex = 7;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.Firebrick;
            this.btStop.ForeColor = System.Drawing.Color.White;
            this.btStop.Location = new System.Drawing.Point(451, 325);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(91, 28);
            this.btStop.TabIndex = 8;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btRestart
            // 
            this.btRestart.BackColor = System.Drawing.Color.Gray;
            this.btRestart.ForeColor = System.Drawing.Color.White;
            this.btRestart.Location = new System.Drawing.Point(354, 325);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(91, 28);
            this.btRestart.TabIndex = 9;
            this.btRestart.Text = "Restart";
            this.btRestart.UseVisualStyleBackColor = false;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // lbRok
            // 
            this.lbRok.AutoSize = true;
            this.lbRok.BackColor = System.Drawing.Color.Black;
            this.lbRok.ForeColor = System.Drawing.Color.White;
            this.lbRok.Location = new System.Drawing.Point(37, 29);
            this.lbRok.Name = "lbRok";
            this.lbRok.Size = new System.Drawing.Size(0, 16);
            this.lbRok.TabIndex = 10;
            // 
            // lbPowierzchnia
            // 
            this.lbPowierzchnia.AutoSize = true;
            this.lbPowierzchnia.BackColor = System.Drawing.Color.Black;
            this.lbPowierzchnia.ForeColor = System.Drawing.Color.White;
            this.lbPowierzchnia.Location = new System.Drawing.Point(679, 29);
            this.lbPowierzchnia.Name = "lbPowierzchnia";
            this.lbPowierzchnia.Size = new System.Drawing.Size(0, 16);
            this.lbPowierzchnia.TabIndex = 11;
            // 
            // Animacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 359);
            this.Controls.Add(this.lbPowierzchnia);
            this.Controls.Add(this.lbRok);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbZdj);
            this.Name = "Animacja";
            this.Text = "Animacja";
            this.Load += new System.EventHandler(this.Animacja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZdj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbZdj;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Label lbRok;
        private System.Windows.Forms.Label lbPowierzchnia;
    }
}