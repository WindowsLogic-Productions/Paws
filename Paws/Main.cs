using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Paws
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Pre-load hardware support.
            if (Properties.Settings.Default.HA == 1)
            {
                
            }
            else
            {

            }
        }

        private void linkArt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://x.com/ruka_tou");
        }
        #region WebView2
        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {

            webView21.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            webView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
            webView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
            webView21.CoreWebView2.Settings.IsStatusBarEnabled = false;

            if (Properties.Settings.Default.HA == 0)
            {
                var options = new CoreWebView2EnvironmentOptions();
                options.AdditionalBrowserArguments = "--disable-gpu";
            }
            else
            {
            }

            
        }

        private void webView21_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            e.Cancel = true;
            OpenInExternalBrowser(e.Uri);
        }

        private void OpenInExternalBrowser(string url)
        {
            Process.Start(url);
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            if (Properties.Settings.Default.OpenExternal == 0)
            {
            }
            else
            {
                Process.Start(e.Uri);
                e.Handled = true;
            }
        }
        #endregion
    }
}
