namespace LinkSearch
{
    partial class LinkSearch
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
            this.keyword = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.url = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.urlList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(35, 43);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(160, 20);
            this.keyword.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(319, 85);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1025, 690);
            this.webBrowser.TabIndex = 3;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(319, 43);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(431, 20);
            this.url.TabIndex = 4;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(756, 43);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(73, 23);
            this.Browse.TabIndex = 5;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(201, 43);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // urlList
            // 
            this.urlList.FormattingEnabled = true;
            this.urlList.Location = new System.Drawing.Point(35, 85);
            this.urlList.Name = "urlList";
            this.urlList.Size = new System.Drawing.Size(241, 693);
            this.urlList.TabIndex = 6;
            // 
            // LinkSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 796);
            this.Controls.Add(this.urlList);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.url);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.Search);
            this.Name = "LinkSearch";
            this.Text = "LinkSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox urlList;
    }
}

