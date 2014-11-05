namespace LinkSearch
{
    partial class About
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutGorup = new System.Windows.Forms.GroupBox();
            this.NameAndVersion = new System.Windows.Forms.Label();
            this.CopyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aboutGorup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LinkSearch.Properties.Resources.About;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // aboutGorup
            // 
            this.aboutGorup.Controls.Add(this.CopyRight);
            this.aboutGorup.Controls.Add(this.NameAndVersion);
            this.aboutGorup.Location = new System.Drawing.Point(229, 13);
            this.aboutGorup.Name = "aboutGorup";
            this.aboutGorup.Size = new System.Drawing.Size(219, 241);
            this.aboutGorup.TabIndex = 1;
            this.aboutGorup.TabStop = false;
            this.aboutGorup.Text = "About";
            // 
            // NameAndVersion
            // 
            this.NameAndVersion.AutoSize = true;
            this.NameAndVersion.Location = new System.Drawing.Point(7, 20);
            this.NameAndVersion.Name = "NameAndVersion";
            this.NameAndVersion.Size = new System.Drawing.Size(100, 13);
            this.NameAndVersion.TabIndex = 0;
            this.NameAndVersion.Text = "LinkSearch: 0.0.0.1";
            // 
            // CopyRight
            // 
            this.CopyRight.AutoSize = true;
            this.CopyRight.Location = new System.Drawing.Point(10, 37);
            this.CopyRight.Name = "CopyRight";
            this.CopyRight.Size = new System.Drawing.Size(98, 13);
            this.CopyRight.TabIndex = 1;
            this.CopyRight.Text = "Copyright @ 2hu01";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 267);
            this.Controls.Add(this.aboutGorup);
            this.Controls.Add(this.pictureBox1);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aboutGorup.ResumeLayout(false);
            this.aboutGorup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox aboutGorup;
        private System.Windows.Forms.Label CopyRight;
        private System.Windows.Forms.Label NameAndVersion;
    }
}