namespace EstateManagement.notification
{
    partial class FormNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotification));
            this.webBrowser_notification = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser_notification
            // 
            this.webBrowser_notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_notification.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_notification.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_notification.Name = "webBrowser_notification";
            this.webBrowser_notification.Size = new System.Drawing.Size(640, 345);
            this.webBrowser_notification.TabIndex = 0;
            this.webBrowser_notification.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_notification_Navigating);
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 345);
            this.Controls.Add(this.webBrowser_notification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提醒";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormNotification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_notification;

    }
}