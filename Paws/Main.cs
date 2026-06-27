using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.WinForms;

namespace Paws
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        string getStatText = "";

        public Main()
        {
            InitializeComponent();
        }
        #region Load Settings
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
        #endregion
        #region WebView2
        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {

            webView21.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            webView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
            webView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
            webView21.CoreWebView2.Settings.IsStatusBarEnabled = true;

            webView21.CoreWebView2.ContextMenuRequested += CoreWebView2_ContextMenuRequested;

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

            if (e.Uri == "https://pawchive.st/")
            {
             
            }
            else if (!e.Uri.Contains("pawchive.st"))
            {
                e.Cancel = true;
                OpenInExternalBrowser(e.Uri);
            }
            else if (e.Uri.Contains("patreon"))
            {
                
            }
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            //Attempt to open a new instance when a new window is requested, currently does not work.
            e.Handled = true;
            OpenInExternalBrowser(getStatText);
        }

        private void CoreWebView2_ContextMenuRequested(object sender, CoreWebView2ContextMenuRequestedEventArgs e)
        {
            e.Handled = true;
            int x = e.Location.X;
            int y = e.Location.Y;
            Point screenLocation = webView21.PointToScreen(new Point(x, y));

            backToolStripMenuItem.Enabled = webView21.CanGoBack;
            forwardToolStripMenuItem.Enabled = webView21.CanGoForward;

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                pasteToolStripMenuItem.Enabled = true;
            }

            if (webView21.CoreWebView2.StatusBarText == "")
            {
                copyLinkToolStripMenuItem.Enabled = false;
                openInNewWindowToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyLinkToolStripMenuItem.Enabled = true;
                openInNewWindowToolStripMenuItem.Enabled = true;
                getStatusText();
            }


            menuRightClick.Show(screenLocation);
        }

        private void webView21_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Middle)
            {
                return;
            }
            if (webView21.CoreWebView2 == null)
            {
                return;
            }
            var geturl = webView21.CoreWebView2.StatusBarText;
            OpenInExternalBrowser(geturl);
        }
        #endregion
        #region Right-click Menu
        private void openInNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Use the status text of WebView2 and run it through a new WebView2 instance.
            OpenInExternalBrowser(getStatText);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Go back a page.
            webView21.GoBack();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Go forward a page.
            webView21.GoForward();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reload the current page.
            webView21.Reload();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cut from the current web page and store it in the clipboard.
            webView21.CoreWebView2?.ExecuteScriptAsync("document.execCommand('cut');");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copy from the current web page and store it in the clipboard.
            webView21.CoreWebView2?.ExecuteScriptAsync("document.execCommand('copy');");
        }

        private void copyLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set the clipboard to the WebView2 status text currently hovered over.
            Clipboard.SetText(getStatText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Grab from the saved clipboard text and paste the stored text.
            PasteWithKeystrokes();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Open a new settings window.
            var settingsform = new Settings();
            settingsform.ShowDialog();
        }

        private void aboutPawsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a new about window and pull app version.
            var aboutform = new About();
            aboutform.lblVersion.Text = "Paws " + Application.ProductVersion;
            aboutform.ShowDialog();
        }

        private void menuRightClick_MouseLeave(object sender, EventArgs e)
        {
            //Close the right click menu if the mouse pointer leaves it.
            menuRightClick.Close();
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
            aboutform.lblVersion.Text = "Paws " + Application.ProductVersion;
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
        #region Timers
        private void ContentTimer_Tick(object sender, EventArgs e)
        {
            //Attempt to update window title to match area of Pawchive.
            try
            {
                if (webView21.CoreWebView2.DocumentTitle == "")
                {
                    webView21.Visible = false;
                    Text = "Initialising... - Paws";
                    sysTrayIcon.Text = "Initialising... - Paws";
                    Thread.Sleep(1000);
                    webView21.Visible = true;
                    sysTrayIcon.Text = "Paws";
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

                //Attempt to block AI generated content.
                if(Properties.Settings.Default.AI == 0)
                {
                    if (Text.Contains("ai"))
                    {
                        webView21.CoreWebView2.GoBack();
                    }
                }
                else
                {

                }
            }
            catch
            {
                
            }
        }
        #endregion
        #region Fuctions
        private void linkArt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //If WebView2 does not initialise (WebView2 Runtime not installed), allow user to click a link to the artist for the Pawchive mascot.
            Process.Start("https://x.com/ruka_tou");
        }

        private void OpenInExternalBrowser(string url)
        {
            //Create a new WebView2 instance and pull the previous WebView2 instance status text from that
            //Run that status text through the new instance after the new instance has been initialised.
            var startnew = new Main();
            startnew.Show();
            startnew.webView21.CoreWebView2InitializationCompleted += (s, args) =>
            {
                startnew.webView21.Source = new Uri(getStatText);
            };
        }

        private void PasteWithKeystrokes()
        {
            //Focus WebView2 and send the keystrokes stored in the clipboard.
            webView21.Focus();
            SendKeys.SendWait("^v");
        }

        private void getStatusText()
        {
            getStatText = webView21.CoreWebView2.StatusBarText;
        }
        #endregion
        #region Closing
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Future use.
        }
        #endregion
    }
}