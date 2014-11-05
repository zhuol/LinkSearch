using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;

namespace LinkSearch
{
    public partial class LinkSearch : Form
    {
        public LinkSearch()
        {
            InitializeComponent();
            webBrowser.Navigate("https://www.google.com");
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(url.Text))
            {
                webBrowser.Navigate(url.Text);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            ArrayList urls = new ArrayList();
            foreach(Match u in linkParser.Matches(webBrowser.DocumentText))
                urls.Add(u.Value);

            urlList.Items.Clear();
            if (!String.IsNullOrEmpty(keyword.Text))
            {
                foreach(var u in urls)
                {
                    if(u.ToString().Contains(keyword.Text))
                    {
                        urlList.Items.Add(u.ToString());
                    }
                }
            }
            else
            {
                foreach (var u in urls)
                {
                    urlList.Items.Add(u.ToString());
                }
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {           
            SaveFileDialog exportUrlList = new SaveFileDialog();
            exportUrlList.Filter = "Html File|*.html|Htm File|*.htm|Text File|*.txt";
            exportUrlList.Title = "Export url List";
            exportUrlList.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (exportUrlList.FileName != "")
            {
                using (FileStream f = (System.IO.FileStream)exportUrlList.OpenFile())
                {
                    using (StreamWriter s = new StreamWriter(f))
                    {
                        StringBuilder str = new StringBuilder();
                        switch (exportUrlList.FilterIndex)
                        {
                            case 1:
                            case 2:
                                str.AppendLine("<html><body>");
                                foreach (var l in urlList.Items)
                                {
                                    str.AppendLine("<a href=" + l.ToString() + ">"+l.ToString()+"</a></br>");
                                }
                                str.AppendLine("</body></html>");
                                break;
                            case 3:
                                foreach (var l in urlList.Items)
                                {
                                    str.AppendLine(l.ToString());
                                }
                                break;
                        }
                        s.WriteLine(str);
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
