using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paws
{
    public class Variables
    {
        public static string ver = System.Windows.Forms.Application.ProductVersion.ToString() + " (" + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year.ToString() + ")";
        public static string user = System.Windows.Forms.SystemInformation.UserName;
        public static string appname = "Paws";
        public static string vertext = "https://u.windowslogic.co.uk/Updates/PAWS/PAWS.txt";

        public static void ParseVariables(Label input)
        {
            input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user).Replace("%appname%", Variables.appname);
        }
    }
}
