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
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

namespace LinkSearch
{
    public partial class LinkSearch : Form
    {
        public LinkSearch()
        {
            InitializeComponent();
            url.Text = "https://www.google.com";
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
            Regex linkParser = new Regex(@"((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp)://)+(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,15})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(/[a-zA-Z0-9\&amp;%_\./-~-]*)?", 
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
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
            urlList.HorizontalScrollbar = true;
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

        private void url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter  && !String.IsNullOrEmpty(url.Text))
            {
                webBrowser.Navigate(url.Text);
            }
        }

        private void keyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(keyword.Text))
            {
                Search_Click(sender, e);
            }
        }

        private void sqli_Click(object sender, EventArgs e)
        {
            injectionLog.Items.Clear();
            string script = File.ReadAllText(@"res/hello.py");
            var engine = Python.CreateEngine();
            var outputStream = new MemoryStream();
            var outputStreamWriter = new StreamWriter(outputStream);
            engine.Runtime.IO.SetOutput(outputStream, outputStreamWriter); 

            var scope = engine.CreateScope();
            var sourceCode = engine.CreateScriptSourceFromString(script);
            sourceCode.Execute(scope);

            var output = Encoding.ASCII.GetString(outputStream.ToArray());
            string temp = String.Empty;
            foreach (var c in output)
            {
                temp += c;
                if (temp.Length == 100)
                {
                    injectionLog.Items.Add(temp);
                    temp = String.Empty;
                }
            }
            injectionLog.HorizontalScrollbar = true;
        }
    }
}
