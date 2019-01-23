/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms
{
    public partial class App_Back : Form
    {
        public App_Back() { InitializeComponent(); }
        #region Events
        #region Form
        private void ShowView_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width + 1, Screen.PrimaryScreen.Bounds.Height + 1);
            this.Location = new Point(0, 0);
            W32.SetParent(this.Handle, MainFunctions.workerw);
        }
        private void ShowView_Paint(object sender, PaintEventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width + 1, Screen.PrimaryScreen.Bounds.Height + 1);
            this.Location = new Point(0, 0);
            if (MainFunctions.File_Ext(MainFunctions.ReadKey(MainFunctions.rgk.Path)) != 3)
            {
                WebBrowser ViewPart = new WebBrowser
                {
                    ScriptErrorsSuppressed = true,
                    Dock = DockStyle.Fill
                };
                ViewPart.Navigated += new WebBrowserNavigatedEventHandler(ViewPart_Navigated);
                this.Controls.Add(ViewPart);
                ViewPart.BringToFront();
                ViewPart.Url = new System.Uri(new System.Uri(Properties.Settings.Default.HTML_Location).AbsolutePath);
                ViewPart.Refresh();
            }
            else { MainFunctions.LoadADT(); }
        }
        private void ViewPart_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            { if (ViewPart.DocumentText.Contains("error")) { MainFunctions.Update_View(); } }
        }
        #endregion
        #endregion
    }
}
