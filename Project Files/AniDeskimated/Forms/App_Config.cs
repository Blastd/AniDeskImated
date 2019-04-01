/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;
using AniDeskimated.Forms;
using AniDeskimated.Forms.Interfaces;
using AniDeskimated.Forms.Media_Settings;

namespace AniDeskimated
{
    public partial class DeskSettings : Form
    {
        public DeskSettings()=>InitializeComponent();
        #region Variables
            public static bool isHooked = false;
            public static Point beforeMove;
        #endregion
        #region Form
            private void DeskSettings_Load(object sender, EventArgs e) => Startup();
            private void Startup()
                {
                    this.Hide();
                    Ch_win();
                    SetStyle();
                }
            #region Form Move
                private void DeskSettings_MouseDown(object sender, MouseEventArgs e)
                {
                    isHooked = true;
                    beforeMove = new Point(e.X,e.Y);
                }
                private void DeskSettings_MouseMove(object sender, MouseEventArgs e)
                {
                    if (isHooked)
                    { Point HookLocation = new Point(e.X,e.Y); this.Location = 
                            new Point((this.PointToScreen(HookLocation).X)-beforeMove.X,
                            (this.PointToScreen(HookLocation).Y) - beforeMove.Y);
                    }
                }
                private void DeskSettings_MouseUp(object sender, MouseEventArgs e) => isHooked = false;
            #endregion
            #region Ux
                private void DeskSettings_Paint(object sender, PaintEventArgs e)
                {
                    e.Graphics.DrawRectangle(new Pen(MainFunctions.VariableColor(this.BackColor, 25)),
                        new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1)));
                }
                private void DeskSettings_Activated(object sender, EventArgs e)
                {
                    Button_Exit.BackColor = Color.FromArgb(150, 255, 0, 0);
                }
                private void DeskSettings_Deactivate(object sender, EventArgs e)
                {
                    Button_Exit.BackColor = Color.FromArgb(150, 64, 64, 64);
                }
                public void SetStyle()
                {
                    Button_NewMedia.Button_Part.Text = "New background";
                    btt_mgn.Text = "\uE721";
                    btt_adt.Text = "\uE713";
                    btt_vol.Text = "\uE767";
                    F_type.ForeColor = MainFunctions.Color_Check();
                    btt_mgn.ForeColor = MainFunctions.Color_Check();
                    btt_adt.ForeColor = MainFunctions.Color_Check();
                    btt_vol.ForeColor = MainFunctions.Color_Check();
                    Button_Color_Choose.ForeColor = MainFunctions.Color_Check();
                    Button_NewMedia.ButtonColor = MainFunctions.Color_Check();
                    FsStyle();
                }
                private void FsStyle()
                {
                    switch (MainFunctions.File_Ext(MainFunctions.ReadKey(MainFunctions.Rgk.Path)))
                    {
                        case 0:
                            F_type.Text = "\uEB9F";
                            btt_vol.Enabled = false;
                            btt_mgn.Enabled = true;
                            btt_adt.Enabled = false;
                            break;
                        case 1:
                            F_type.Text = "\uE8B2";
                            btt_vol.Enabled = true;
                            btt_mgn.Enabled = true;
                            btt_adt.Enabled = false;
                            break;
                        case 2:
                            F_type.Text = "\uE8B2";
                            btt_vol.Enabled = false;
                            btt_mgn.Enabled = true;
                            btt_adt.Enabled = false;
                            break;
                        case 3:
                            F_type.Text = "\uF259";
                            btt_vol.Enabled = false;
                            btt_mgn.Enabled = false;
                            if (MainFunctions.LoadADTS() != null)
                            {
                                btt_adt.Enabled = true;
                            }
                            TaskBar_Notify_Icon.BalloonTipTitle = 
                                "Security warning";
                            TaskBar_Notify_Icon.BalloonTipText =
                                "Custom Themes allow the execution " +
                                "of untrusted programs, exposing the pc " +
                                "to malware that may " +
                                "steal your data or corrupt your system.";
                            TaskBar_Notify_Icon.BalloonTipIcon = ToolTipIcon.Warning;
                            TaskBar_Notify_Icon.ShowBalloonTip(5000);
                            break;
                        default:
                            F_type.Text = "\uF259";
                            btt_vol.Enabled = false;
                            btt_mgn.Enabled = false;
                            btt_adt.Enabled = false;
                            break;

                    }
                }
                private void Ch_win()
                {
                    using (var hkcu = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.CurrentUser, Microsoft.Win32.RegistryView.Registry64))
                        if (hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).GetValue("Animated Desktop - ADM") == null)
                            Check_WindowsStartup.Checked = false;
                        else
                            Check_WindowsStartup.Checked = true;
                }
                private void Choose_Color_Paint(object sender, PaintEventArgs e)
                {
                    Button_Color_Choose.Text = "\uE790";
                    //Button_Color_Choose.ForeColor = MainFunctions.Color_Check();
                }
                private void App_About_Paint(object sender, PaintEventArgs e)
                {
                    App_About.Text = "\uE946";
                }
                private void Button_Exit_Click(object sender, EventArgs e) => this.Close();
                private void DeskSettings_FormClosing(object sender, FormClosingEventArgs e)
                {
                    if (Properties.Settings.Default.CanClose == false)
                    {
                        e.Cancel = true;
                        this.WindowState = FormWindowState.Minimized;
                        this.Hide();
                    }
                }
                private void App_About_Click(object sender, EventArgs e)
                {
                    App_Lcs Frm_License = new App_Lcs();
                    Frm_License.ShowDialog();
                }
                private void Check_WindowsStartup_CheckedChanged(object sender, EventArgs e)
                {
                    MainFunctions.WinStartup(Check_WindowsStartup.Checked);
                }
        #endregion
        #region Media Control
                private void Button_VideoVolume_Click(object sender, EventArgs e)
                {
                    var Ctrl = new Control_Volume
                    {
                        Size = new Size(this.Width, this.Height - Button_Exit.Height),
                        Location = new Point(0, Button_Exit.Height)
                    };
                    this.Controls.Add(Ctrl);
                    Ctrl.BringToFront();
                }
                private void Button_Magnifier_Click(object sender, EventArgs e)
                {
                    var Ctrl = new Control_Scale
                    {
                        Size = new Size(this.Width, this.Height - Button_Exit.Height),
                        Location = new Point(0, Button_Exit.Height)
                    };
                    this.Controls.Add(Ctrl);
                    Ctrl.BringToFront();
                }
                private void Button_ADT_Settings_Click(object sender, EventArgs e)
                {
                    Form ADTS = MainFunctions.LoadADTS();
                    if (ADTS != null)
                    {
                        ADTS.TopMost = true;
                        ADTS.ShowDialog();
                    }
                }
            #endregion
        #endregion
        #region Notification Icon Events
            private void IconButton_Browse_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
            private void IconButton_Quit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CanClose = true;
            MainFunctions.CloseApp();
        }
            private void TaskBar_Notify_Icon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        #endregion
        #region Changing Content
            private void Button_NewMedia_Click(object sender, EventArgs e)
            {
                BackMenuChoose.Show(MousePosition.X - 50 % BackMenuChoose.Width,
                    MousePosition.Y - 50 % BackMenuChoose.Height);
            }
            private void GetMediaFile_HelpRequest(object sender, EventArgs e)
            {
                MessageBox.Show("Supported Files:"+ '\n' +
                    "Images (gif, jpg, jpeg, bmp, png)" + '\n' +
                    "Videos (mp4 webm)" + '\n' +
                    "other (dll)","File types",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            private void BackMenu_Gif_Click(object sender, EventArgs e) => GetMediaFile.ShowDialog();
            private void BackMenu_WebComponent_Click(object sender, EventArgs e)
            {
                Form lnk = new Forms.Media_Settings.Control_InLink();
                lnk.ShowDialog();
                FsStyle();
            }
            private void GetMediaFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
            {
                try
                {
                    MainFunctions.SetKey(MainFunctions.Rgk.Path,GetMediaFile.FileName);
                    FsStyle();
                }catch(Exception Ex){
                    Console.Write(Ex.Message);
                    MainFunctions.Log("Entered an invalid media file.");
                    F_type.Text = "Try another image";
                }
            }
        #endregion
        #region Changing Color
        private void Choose_Color_Click(object sender, EventArgs e)
        {
            ColorPickMenuChoose.Show(MousePosition.X - 50 % ColorPickMenuChoose.Width,
                MousePosition.Y - 50 % ColorPickMenuChoose.Height);
        }
            private void ColorPick_Screen_Click(object sender, EventArgs e)
        {
                Color_Picker_Frame X = new Color_Picker_Frame();
                this.Hide();
                X.FormClosing += new FormClosingEventHandler(ColorPick_closing);
                X.ShowDialog();
        }
            private void ColorPick_closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Show();
                SetStyle();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
            private void ColorPick_Menù_Click(object sender, EventArgs e)
        {
            Menu_Color.Color = MainFunctions.Color_Check();
            Menu_Color.ShowDialog();
            var Cl = Menu_Color.Color;
            MainFunctions.SetKey(MainFunctions.Rgk.Color, Cl.R.ToString() + 
                "-" + 
                Cl.G.ToString() + 
                "-" + 
                Cl.B.ToString());
        }
        #endregion
    }
}
