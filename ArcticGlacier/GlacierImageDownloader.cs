using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Net;
using HtmlAgilityPack;
using System.Windows.Forms;


namespace ArcticGlacier
{
    public class GlacierImageDownloader
    {
        public string PobierzObraz(string url, string sciezkaZapisu)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(sciezkaZapisu, FileMode.Create))
                {
                    stream.CopyTo(fileStream);
                }
                return sciezkaZapisu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania obrazu: " + ex.Message);
            }
            return null;
        }

       
    }
}
