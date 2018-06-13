using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace IdleMiner
{
    partial class AboutBox : Form
    {
        private string projectURL = "https://github.com/devinbileck/IdleMiner";
        private string iconAttribution = "Icons made by Freepik from http://www.flaticon.com";

        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyInfo.Title);
            this.labelProductName.Text = AssemblyInfo.Product;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyInfo.Version);
            this.labelCopyright.Text = AssemblyInfo.Copyright;
            this.labelCompanyName.Text = AssemblyInfo.Company;
            this.richTextBoxDescription.Text = String.Format("{0}\r\n\r\n{1}\r\n\r\n{2}", AssemblyInfo.Description, projectURL, iconAttribution);
        }

        private void RichTextBoxDescription_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            LaunchWeblink(e.LinkText);
        }

        private void LaunchWeblink(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        private bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }
    }
}
