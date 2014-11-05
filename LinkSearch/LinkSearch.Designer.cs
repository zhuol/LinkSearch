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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectionLog = new System.Windows.Forms.ListBox();
            this.sqli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Browser = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Browser.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyword
            // 
            this.keyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyword.Location = new System.Drawing.Point(7, 22);
            this.keyword.Margin = new System.Windows.Forms.Padding(4);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(275, 22);
            this.keyword.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(16, 55);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1048, 572);
            this.webBrowser.TabIndex = 3;
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.url.Location = new System.Drawing.Point(16, 25);
            this.url.Margin = new System.Windows.Forms.Padding(4);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(961, 22);
            this.url.TabIndex = 4;
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(985, 22);
            this.Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(79, 28);
            this.Browse.TabIndex = 5;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(290, 19);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 28);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // urlList
            // 
            this.urlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlList.FormattingEnabled = true;
            this.urlList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.urlList.ItemHeight = 16;
            this.urlList.Location = new System.Drawing.Point(7, 55);
            this.urlList.Margin = new System.Windows.Forms.Padding(4);
            this.urlList.Name = "urlList";
            this.urlList.Size = new System.Drawing.Size(358, 212);
            this.urlList.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1483, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // injectionLog
            // 
            this.injectionLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.injectionLog.FormattingEnabled = true;
            this.injectionLog.ItemHeight = 16;
            this.injectionLog.Location = new System.Drawing.Point(7, 303);
            this.injectionLog.Name = "injectionLog";
            this.injectionLog.Size = new System.Drawing.Size(358, 324);
            this.injectionLog.TabIndex = 8;
            // 
            // sqli
            // 
            this.sqli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sqli.Location = new System.Drawing.Point(290, 274);
            this.sqli.Name = "sqli";
            this.sqli.Size = new System.Drawing.Size(75, 23);
            this.sqli.TabIndex = 9;
            this.sqli.Text = "SQLi";
            this.sqli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.keyword);
            this.groupBox1.Controls.Add(this.sqli);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.injectionLog);
            this.groupBox1.Controls.Add(this.urlList);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 639);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQLi";
            // 
            // Browser
            // 
            this.Browser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Browser.Controls.Add(this.webBrowser);
            this.Browser.Controls.Add(this.url);
            this.Browser.Controls.Add(this.Browse);
            this.Browser.Location = new System.Drawing.Point(399, 31);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(1071, 639);
            this.Browser.TabIndex = 11;
            this.Browser.TabStop = false;
            this.Browser.Text = "Browser";
            // 
            // LinkSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1483, 674);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LinkSearch";
            this.Text = "LinkSearch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Browser.ResumeLayout(false);
            this.Browser.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox injectionLog;
        private System.Windows.Forms.Button sqli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Browser;
    }
}

