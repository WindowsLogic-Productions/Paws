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
using System.Threading;

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
            webView21.CoreWebView2.Settings.IsStatusBarEnabled = true;

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

            if (!e.Uri.Contains("pawchive.st"))
            {
                e.Cancel = true;
                OpenInExternalBrowser(e.Uri);
            }
            
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
        #region System Tray
        private void Main_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SysTray == 1)
            {
                if (WindowState == FormWindowState.Minimized == true)
                {
                    Visible = false;
                    sysTrayIcon.Visible = true;
                    sysTrayIcon.ShowBalloonTip(1, "VisCord - Notification", "Paws is now running in the background.", ToolTipIcon.Info);
                    GC.Collect();
                }
                else if (Properties.Settings.Default.SysTray == 0)
                {
                    GC.Collect();
                }
            }
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                sysTrayIcon.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsform = new Settings();
            settingsform.ShowDialog();
        }

        private void AboutVisCordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutform = new About();
            aboutform.lblVersion.Text = "Paws " + Application.ProductVersion.ToString();
            aboutform.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to exit Paws?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                Application.Exit();
            }
        }
        #endregion

        #region Functions
        private void ContentTimer_Tick(object sender, EventArgs e)
        {
            //Attempt to update window title to match area of Pawchive.
            try
            {
                if (webView21.CoreWebView2.DocumentTitle == "")
                {
                    webView21.Visible = false;
                    Text = "Initailising... - Paws";
                    sysTrayIcon.Text = "Initialising... - Paws";
                    webView21.Visible = true;
                }
                else
                {
                    var title = webView21.CoreWebView2.Source;
                    switch (title)
                    {
                        case string s when title.Contains("artists"):
                            Text = "Creators | " + webView21.CoreWebView2.DocumentTitle + " - Paws";
                            break;

                        case string s when title.Contains("posts"):
                            Text = "Posts | " + webView21.CoreWebView2.DocumentTitle + " - Paws";
                            break;

                        case string s when title.Contains("dms"):
                            Text = "Direct Messages | " + webView21.CoreWebView2.DocumentTitle + " - Paws";
                            break;

                        case string s when title.Contains("shares"):
                            Text = "Filehaus | " + webView21.CoreWebView2.DocumentTitle + " - Paws";
                            break;

                        case string s when title.Contains("favorites"):
                            Text = "Favourites | " + webView21.CoreWebView2.DocumentTitle + " - Paws";
                            break;

                        case string s when title.Contains("tutorial"):
                            Text = "FAQ | " + webView21.CoreWebView2.DocumentTitle + " - Paws";
                            break;

                        default:
                            Text = webView21.CoreWebView2.DocumentTitle + " - Paws";
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FixTitle_Tick(object sender, EventArgs e)
        {

        }
        #endregion


    }
}