using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Paws
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            pnlGeneral.Show();
            pnlGeneral.BringToFront();
            pnlAdvanced.Hide();
            btnGeneral.BackColor = Color.FromArgb(255, 82, 82, 82);
            btnAdvanced.BackColor = Color.FromArgb(255, 23, 25, 26);

            //Load startup settings.
            if (Properties.Settings.Default.Startup == 0)
            {
                chkStartup.Checked = false;
            }
            else
            {
                chkStartup.Checked = true;
            }

            //Load system tray settings.
            if (Properties.Settings.Default.SysTray == 0)
            {
                chkSysTray.Checked = false;
            }
            else
            {
                chkSysTray.Checked = true;
            }

            //Load close button settings.
            if (Properties.Settings.Default.CloseMinimise == 0)
            {
                chkCM.Checked = false;
            }
            else
            {
                chkCM.Checked = true;
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            pnlGeneral.Show();
            pnlGeneral.BringToFront();
            pnlAdvanced.Hide();
            btnGeneral.BackColor = Color.FromArgb(255, 82, 82, 82);
            btnAdvanced.BackColor = Color.FromArgb(255, 23, 25, 26);
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            pnlAdvanced.Show();
            pnlAdvanced.BringToFront();
            pnlGeneral.Hide();
            btnGeneral.BackColor = Color.FromArgb(255, 23, 25, 26);
            btnAdvanced.BackColor = Color.FromArgb(255, 82, 82, 82);
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Open a new about window and pull app version.
            var aboutform = new About();
            aboutform.lblVersion.Text = "Paws " + Application.ProductVersion;
            aboutform.ShowDialog();
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartup.Checked == true)
            {
                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                startupKey.SetValue(Application.ProductName, Application.ExecutablePath);
                Properties.Settings.Default.Startup = 1;
            }
            else
            {
                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                startupKey.DeleteValue(Application.ProductName);
                Properties.Settings.Default.Startup = 0;
            }
        }

        private void chkSysTray_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSysTray.Checked == true)
            {
                Properties.Settings.Default.SysTray = 1;
            }
            else
            {
                Properties.Settings.Default.SysTray = 0;
            }
        }

        private void chkCM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCM.Checked == true)
            {
                Properties.Settings.Default.CloseMinimise = 1;
            }
            else
            {
                Properties.Settings.Default.CloseMinimise = 0;
            }
        }

        private void chkHardware_CheckedChanged(object sender, EventArgs e)
        {
            var mainform = new Main();

            try
            {
                if (chkHardware.Checked == true)
                {
                    Properties.Settings.Default.HA = 1;
                    mainform.webView21.Reload();
                }
                else
                {
                    Properties.Settings.Default.HA = 0;
                    mainform.webView21.Reload();
                }
            }
            catch
            {

            }
        }

        private void CacheButton_Click(object sender, EventArgs e)
        {
            var mainform = new Main();

            if (MessageBox.Show("Would you like to clear Paws' cache?  It may take a while for Paws to reload fully and you may be logged out of Pawchive.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mainform.webView21.CoreWebView2.Profile.ClearBrowsingDataAsync();
                mainform.webView21.Reload();
            }
        }

        private void DataButton_Click(object sender, EventArgs e)
        {
            var mainform = new Main();

            if (MessageBox.Show("Would you like to clear Paws' cache?  It may take a while for Paws to reload fully and you may be logged out of Pawchive.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mainform.webView21.CoreWebView2.ExecuteScriptAsync("javascript:localStorage.clear()");
                mainform.webView21.Reload();
            }
        }
    }
}
