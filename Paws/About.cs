using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Paws
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabelContribute_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/windowslogic-productions/paws");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
