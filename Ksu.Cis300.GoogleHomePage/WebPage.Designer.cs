namespace Ksu.Cis300.GoogleHomePage
{
    partial class WebPage
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
            this.uxPage = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // uxPage
            // 
            this.uxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPage.Location = new System.Drawing.Point(8, 8);
            this.uxPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPage.MinimumSize = new System.Drawing.Size(13, 13);
            this.uxPage.Name = "uxPage";
            this.uxPage.Size = new System.Drawing.Size(514, 273);
            this.uxPage.TabIndex = 0;
            this.uxPage.Url = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            // 
            // WebPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.uxPage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WebPage";
            this.Text = "Web Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser uxPage;
    }
}

