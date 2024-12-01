using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcticGlacier
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ZnajdzLinkObrazu znajdzLink = new ZnajdzLinkObrazu();
            Form1 form1 = new Form1();
            form1.znajdzLink = znajdzLink;

            GlacierImageDownloader imageDownloader = new GlacierImageDownloader();
            Form1 form2 = new Form1();
            form2.GlacierImageDownloader = imageDownloader;

            Application.Run(new Form1());
        }
    }
}
