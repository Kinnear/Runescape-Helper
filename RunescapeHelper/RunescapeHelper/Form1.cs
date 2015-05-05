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
        public HighscoreData playerHighscoreData;

        public Form1()
        {
            InitializeComponent();
            string a = "http://services.runescape.com/m=hiscore/index_lite.ws?player=kirano";

            playerHighscoreData = HighscoreParser(GET(a));
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
          //  string a = "http://services.runescape.com/m=hiscore/index_lite.ws?player=" + usernameTextbox.Text;
            string a = "http://services.runescape.com/m=hiscore/index_lite.ws?player=kirano";
            
            playerHighscoreData = HighscoreParser(GET(a));
        }

        // parses the highscore csv into data that is meaningful
        HighscoreData HighscoreParser(string csv)
        {
            HighscoreData data = new HighscoreData();

            // to store the segments of data
            string[] temp;
            char[] delimiters = {'\n'};

            temp = csv.Split(delimiters);

            //break the string further down into its components
            for (int i = 0; i < Enum.GetNames(typeof(HighscoreData.SKILLS)).Length; i++)
            {
                string[] holder = temp[i].Split(',');
                for (int j = 0; j < holder.Length; j++)
                {
                    data.skills[i, j] = Int32.Parse(holder[j]);
                }
            }

            return data;
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