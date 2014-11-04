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

namespace LinkSearch
{
    public partial class LinkSearch : Form
    {
        public LinkSearch()
        {
            InitializeComponent();
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
    }
}
