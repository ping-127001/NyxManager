using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxManagerCLI.Handler
{
    internal class Net
    {
        public static string webstring;
        public static bool WebStringTrue;

        public static void ReadWebString(string website)
        {
            try
            {
                WebClient client = new WebClient();
                webstring = client.DownloadString(website);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void CompareWebString(string website, string compare)
        {
            try
            {
                WebClient client = new WebClient();
                if (client.DownloadString(website).Contains(compare))
                {
                    WebStringTrue = true;
                }
                else
                {
                    WebStringTrue = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void DownloadFile(string url, string filePath)
        {
            WebClient client = new WebClient();
            client.DownloadFileTaskAsync(url, filePath);
        }
    }
}
