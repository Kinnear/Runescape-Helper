using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace RunescapeHelper
{
    public partial class Form1 : Form
    {
        public string csvData = "";
        public HighscoreData playerHighscoreData;

        public Form1()
        {
            InitializeComponent();
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            string a = "http://services.runescape.com/m=hiscore/index_lite.ws?player=" + usernameTextbox.Text;
            
            csvData = GET(a);
            resultsTextbox.Text = csvData;
        }

        // parses the highscore csv into data that is meaningful
        void HighscoreParser(string csv)
        {
            string[] temp;
            char[] delimiters = {',', ' ' };

        }

        // Returns JSON string
        string GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }
    }
}