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

namespace AniDeskimated
{
    public partial class DeskSettings : Form
    {
        public DeskSettings()=>InitializeComponent();
        #region Variables
        public static Form backform = new App_Back();
        public static IntPtr workerw = IntPtr.Zero;
        public static bool isHooked = false;
        public static Point beforeMove;
        #endregion
        #region Background Manager
        public static void StartShow()
        {
            #region //This part of code is not mine and is protected by the Code Project Open License
            IntPtr progman = W32.FindWindow("Progman", null);
            IntPtr result = IntPtr.Zero;
            W32.SendMessageTimeout(progman, 0x052C, new IntPtr(0), IntPtr.Zero, W32.SendMessageTimeoutFlags.SMTO_NORMAL, 1000, out result);
            W32.EnumWindows(new W32.EnumWindowsProc((tophandle, topparamhandle) => {
                IntPtr p = W32.FindWindowEx(tophandle, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero);
                if (p != IntPtr.Zero) { workerw = W32.FindWindowEx(IntPtr.Zero, tophandle, "WorkerW", IntPtr.Zero); }
                return true;
            }), IntPtr.Zero);
            #endregion
            backform.Show();
            MainFunctions.Update_View();
        } //Get Windows Desktop handle showing form and setting its parent to the Windows Desktop
        #endregion
        #region Events
        #region Form
        private void DeskSettings_Load(object sender, EventArgs e)
        {
            this.Hide();
            Ch_win();
            Button_NewMedia.Button_Part.Text = "New background";
            Ch_start();
            StartShow();
            FileType();
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
        private void DeskSettings_MouseUp(object sender, MouseEventArgs e)
        {
            isHooked = false;
        }
        #endregion
        #region Media Control
        private void Button_VideoVolume_Click(object sender, EventArgs e)
        {
            BVolume_Control.Visible = true;
            BVolume_Control.Dock = DockStyle.Fill;
        }
        private void Button_Magnifier_Click(object sender, EventArgs e)
        {
            Acontrol_Scale.Visible = true;
            Acontrol_Scale.Dock = DockStyle.Fill;
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
        private void FileType()
        {
            switch(MainFunctions.File_Ext(MainFunctions.ReadKey("contentPath")))
            {
                case 0:
                    F_type.Text = "\uEB9F";
                    Button_VideoVolume.Enabled = false;
                    Button_Magnifier.Enabled = true;
                    Button_ADT_Settings.Enabled = false;
                    break;
                case 1:
                    F_type.Text = "\uE8B2";
                    Button_VideoVolume.Enabled = true;
                    Button_Magnifier.Enabled = true;
                    Button_ADT_Settings.Enabled = false;
                    break;
                case 3:
                    F_type.Text = "\uF259";
                    Button_VideoVolume.Enabled = false;
                    Button_Magnifier.Enabled = false;
                    if (MainFunctions.LoadADTS() != null)
                    {
                        Button_ADT_Settings.Enabled = true;
                    }
                    break;
                default:
                    F_type.Text = "\uF259";
                    Button_VideoVolume.Enabled = false;
                    Button_Magnifier.Enabled = false;
                    Button_ADT_Settings.Enabled = false;
                    break;

            }
        }
        #endregion
        private void Ch_win()
        {
            using (var hkcu = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.CurrentUser, Microsoft.Win32.RegistryView.Registry64))
                if (hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).GetValue("Animated Desktop - ADM") == null)
                    Check_WindowsStartup.Checked = false;
                else
                    Check_WindowsStartup.Checked = true;
        }
        private void DeskSettings_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(MainFunctions.VariableColor(this.BackColor, 25)),
                new Rectangle(new Point(0, 0), new Size(this.Width-1,this.Height-1)));
        }
        private void Ch_start()
        {
            if (Properties.Settings.Default.NormalStartup == false)
            {
                new App_Init().Show();
            }
        }
        private void Choose_Color_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillPie(new SolidBrush(MainFunctions.Color_Check()), new Rectangle(new Point(1, 1),
                new Size(Button_Color_Choose.Width - 2, Button_Color_Choose.Height - 2)), 0, 360);
            e.Graphics.DrawString("\uE790", Button_Color_Choose.Font, 
                new SolidBrush(MainFunctions.SuitableContrast(MainFunctions.Color_Check())), 
                MainFunctions.String_Centre("\uE790", e.Graphics, Button_Color_Choose.Size, Button_Color_Choose.Font,0,-3));
        }
        private void App_About_Paint(object sender, PaintEventArgs e)
        {
            App_About.Text = "\uE946";
        }
        private void App_About_Click(object sender, EventArgs e)
        {
            App_Lcs Frm_License = new App_Lcs();
            Frm_License.ShowDialog();
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeskSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.CanClose == false)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }
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
            MainFunctions.Log("User is closing the app.");
            MainFunctions.Delete_Player_Files();
            this.TaskBar_Notify_Icon.Visible = false;
            backform.Close();
            Application.Exit();
        }
        private void TaskBar_Notify_Icon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        #endregion
        #endregion
        #region Changing Content
        private void Button_NewMedia_Click(object sender, EventArgs e)
        {
            BackMenuChoose.Show(MousePosition.X - 50 % BackMenuChoose.Width,
                MousePosition.Y - 50 % BackMenuChoose.Height);
        }
        private void GetMediaFile_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Supported Files: gif jpg jpeg bmp wmf png mp4 webm dll");
        }
        private void BackMenu_Gif_Click(object sender, EventArgs e) => GetMediaFile.ShowDialog();
        private void BackMenu_WebComponent_Click(object sender, EventArgs e) {
            Form X = new Forms.Media_Settings.Control_InLink();
            X.ShowDialog();
            FileType();
        }
        private void GetMediaFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                FileType();
                MainFunctions.ChangeAsset(GetMediaFile.FileName);
            }catch(Exception Ex){
                Console.Write(Ex.Message);
                MainFunctions.Log("Entered an invalid media file.");
                F_type.Text = "Try another image";
            }
        }
        #region Changing Color
        private void Choose_Color_Click(object sender, EventArgs e)
        {
            ColorPickMenuChoose.Show(MousePosition.X - 50 % ColorPickMenuChoose.Width,
                MousePosition.Y - 50 % ColorPickMenuChoose.Height);
        }
        private void ColorPick_Screen_Click(object sender, EventArgs e)
        {
            Color_Picker_Frame X = new Color_Picker_Frame();
                X.Show();
                this.Hide();
                X.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ColorPicker_Closed);
        }
        void ColorPicker_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            F_type.BackColor = MainFunctions.Color_Check();
        }
        private void ColorPick_Menù_Click(object sender, EventArgs e)
        {
            Menu_Color.ShowDialog();
            MainFunctions.ChangeColor(Menu_Color.Color);
        }
        #endregion
        #endregion
        private void Check_WindowsStartup_CheckedChanged(object sender, EventArgs e)
        {
            MainFunctions.WinStartup(Check_WindowsStartup.Checked);
        }
    }
}
