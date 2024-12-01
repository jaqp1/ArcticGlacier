using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace ArcticGlacier
{
    public class ZnajdzLinkObrazu
    {
        public string FnZnajdzLinkObrazu(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                string html = webClient.DownloadString(url);

                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(html);

                //Szukanie elementu o klasie 'sea_ice_index'
                var imgNode = document.DocumentNode.SelectSingleNode($"//a[contains(@data-lightbox, 'image15')]");
                return imgNode?.GetAttributeValue("href", null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wyszukiwania linku do obrazu: " + ex.Message);
                return null;
            }
        }

    }
}
