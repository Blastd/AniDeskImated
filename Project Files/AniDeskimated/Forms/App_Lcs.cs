/*AniDeskImated - By Blastd Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using AniDeskimated.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace AniDeskimated.Forms
{
    public partial class App_Lcs : Form
    {
        public App_Lcs(){InitializeComponent();}
        private void Form_License_Load(object sender, EventArgs e)
        {
            this.lcs_b0.Text = "AniDeskImated \n" +
                "Coded by Blastd Mind\n" +
                "The \"Draw Behind Desktop\" feature uses 3rd party code,\n" +
                "which is protected by the Code Project Open License\n" +
                "THIS application is released under the GNU LGPL v3.0 License\n" +
                Application.ProductVersion + '\n';
            this.lcs_b1.Text = LCS.L_LGPL;
            this.lcs_b2.Text = LCS.L_GPL;
            this.lcs_b3.Text = LCS.L_CPOL;
        }
    }
}

