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
            private void ShowView_Load(object sender, EventArgs e)
            {
                this.Location = new Point(0,0);
                this.Size = new Size(10, 10);
                W32.SetParent(this.Handle, MainFunctions.workerw);
            }
            private void ShowView_Paint(object sender, PaintEventArgs e)
            {
                this.Size = new Size(10, 10);
                if (MainFunctions.File_Ext(MainFunctions.ReadKey(MainFunctions.Rgk.Path)) != 3)
                    {
                        bool cancreate = Uri.TryCreate(Properties.Settings.Default.HTML_Location, UriKind.RelativeOrAbsolute, out Uri VUrl);
                        foreach (Screen scr in Screen.AllScreens)
                        {
                            this.Size = new Size(this.Width + scr.Bounds.Width, scr.Bounds.Height);
                            var ViewPart = new WebBrowser
                            {
                                ScriptErrorsSuppressed = true,
                                AllowNavigation = true,
                                Size = scr.Bounds.Size,
                                Location = scr.Bounds.Location,
                                Name = $"Web{scr.Bounds.X.ToString() }",
                                ScrollBarsEnabled = false,
                                Url = VUrl
                            };
                            this.Controls.Add(ViewPart);
                            #region Dev
                            if (Properties.Settings.Default.devMode)
                            MessageBox.Show($"Size ={scr.Bounds.Size}, Location={scr.Bounds.Location}. Form Size={this.Size}");
                            #endregion
                            ViewPart.Navigated += new WebBrowserNavigatedEventHandler(ViewPart_Navigated);
                            this.Controls.Add(ViewPart);
                            ViewPart.BringToFront();
                            if (cancreate)
                                ViewPart.Refresh();
                            else
                                MainFunctions.Log("Viewer uri could not be created");
                        }
                }
                else { MainFunctions.LoadADT(); }
            }
            private void ViewPart_Navigated(object sender, WebBrowserNavigatedEventArgs e)
            {
                foreach(WebBrowser x in this.Controls)
                {
                    if (x.DocumentText.Contains("Error"))
                        x.Refresh();
                }
            }
        #endregion
    }
}
