/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using Microsoft.Win32;
using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using AniDeskimated.Forms;
using System.Text;

namespace AniDeskimated.Classes
{
    public class MainFunctions
    {
        #region Background Manager
        public static IntPtr workerw = IntPtr.Zero;
        public static App_Back backform;
        public static void StartShow()
        {
            #region //This 3rd party code is protected by the Code Project Open License (CPOL)
            IntPtr progman = W32.FindWindow("Progman", null);
            IntPtr result = IntPtr.Zero;
            W32.SendMessageTimeout(progman, 0x052C, new IntPtr(0), IntPtr.Zero, W32.SendMessageTimeoutFlags.SMTO_NORMAL, 1000, out result);
            W32.EnumWindows(new W32.EnumWindowsProc((tophandle, topparamhandle) => {
                IntPtr p = W32.FindWindowEx(tophandle, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero);
                if (p != IntPtr.Zero) { workerw = W32.FindWindowEx(IntPtr.Zero, tophandle, "WorkerW", IntPtr.Zero); }
                return true;
            }), IntPtr.Zero);
            #endregion
            backform = new App_Back();
            backform.Show();
            Update_View();
        } //Get Windows Desktop handle showing form and setting its parent to the Windows Desktop
        public static void CloseApp()
        {
            Log("User is closing the app.");
            backform.Hide();
            IntPtr progman = W32.FindWindow("Progman", null);
            IntPtr ShellView = W32.FindWindowEx(progman, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero);
            IntPtr wallhandle = W32.FindWindowEx(ShellView, IntPtr.Zero, "SysListView32", IntPtr.Zero);
            W32.SendMessage(wallhandle, W32.WmPaint, IntPtr.Zero, IntPtr.Zero);
            Delete_Player_Files();
            Application.Exit();
        }
        #endregion
        #region Registry Management
        public enum Rgk
        { Adm, Path, Color, Scale, Volume, Effects }
        public static string Rname(Rgk ktype)
        {
            switch(ktype)
            {
                case Rgk.Adm:
                    return @"Software\ADM";
                case Rgk.Color:
                    return "colorFill";
                case Rgk.Path:
                    return "contentPath";
                case Rgk.Scale:
                    return "viewScale";
                case Rgk.Volume:
                    return "volumeValue";
                case Rgk.Effects:
                    return "cssEffects";
                default:
                    return null;
            }
        }
        public static void ResetAsset()
        {
            Properties.Settings.Default.AppletPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Log("Resetting Asset...");
            Directory.CreateDirectory(Properties.Settings.Default.AppletPath + @"\ADM");
            try { File.WriteAllBytes(Properties.Settings.Default.AppletPath + @"\ADM\NoMedia.gif", Properties.Resources.NoMedia);
                SetKey(Rgk.Path,Properties.Settings.Default.AppletPath + @"\ADM\NoMedia.gif"); } catch (Exception ex)
            { Log("Cannot restore Placeholder Image. Closing. - " + ex.Message); Application.Exit(); }
        }
        public static Color Color_Check()
        {
            Color Color_Test = Color.Black;
            try
            {
                string[] Reg_Value = MainFunctions.ReadKey(Rgk.Color).Split('-');
                Color_Test = Color.FromArgb(255, Convert.ToInt32(Reg_Value[0]), Convert.ToInt32(Reg_Value[1]), Convert.ToInt32(Reg_Value[2]));
                return Color_Test;
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); MainFunctions.Log(Ex.Message); MainFunctions.SetKey(Rgk.Color, "000-000-000"); return Color_Check(); }
        }
        public static void CSubKey(string Keypath)
        {
            using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                hkcu.CreateSubKey(Keypath, true);
        }
        public static void SetKey(Rgk ktype, string Value)
        {
            using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                hkcu.OpenSubKey(Rname(Rgk.Adm), true).SetValue(Rname(ktype), Value);
            Log("Set value '" + ktype.ToString() + "' to " + Value);
            Update_View();
        }
        public static void FixIE()
        {
            using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
            {
                FileInfo FileH = new FileInfo(new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
                hkcu.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true)
                    .SetValue(FileH.Name, 0x2AF9, RegistryValueKind.DWord);
            }
        }
        public static void WinStartup(bool boot_state)
        {
            if (boot_state) {
                using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).SetValue("Animated Desktop - ADM",
                        new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            } else
            {
                using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("Animated Desktop - ADM");
            }

        }
        public static string ReadKey(Rgk KeyName)
        {
            try
            {
                using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    return hkcu.OpenSubKey(Rname(Rgk.Adm), true).GetValue(Rname(KeyName)).ToString();
            } catch (Exception Ex) { Log("Cannot read Registry Keys", Ex); SetKey(KeyName, "Ell"); return "0"; }
        }
        public static void DelVal(string ValueName)
        {
            try
            {
                using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    hkcu.OpenSubKey(Rname(Rgk.Adm), true).DeleteValue(ValueName);
            } catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
        #endregion
        #region Graphics
        public static Color SuitableContrast(Color bc) {
            if ((double)((bc.R + bc.G + bc.B) / 3) <= 127.5)
                return Color.White; 
            else
                return Color.Black;
        }
        public static int ColorContrast(Color bc, int val) {
            if (((bc.R + bc.G + bc.B) / 3) <= 127.5)
                return val * 1;
            else
                return val * -1;
        }
        public static Color VariableColor(Color bc, int e) {
            int rr, rg, rb;
            rr = Math.Abs(bc.R + e);
            rg = Math.Abs(bc.G + e);
            rb = Math.Abs(bc.B + e);
            return Color.FromArgb(255, LNum(rr), LNum(rg), LNum(rb));
        }
        public static int LNum(int VAL)
        {
            if (VAL > 255)
                return 255;
            else if (VAL < 0)
                return 0;
            else
                return VAL;
        }
        public static string Color_to_hex(Color bc)
        {
            return bc.R.ToString("X2") + bc.G.ToString("X2") + bc.B.ToString("X2");
        }
        public static void Draw_Terminator(Graphics e, Color Line_Color, Control C) {
            e.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath Terminator = new GraphicsPath();
            Terminator.AddArc(new Rectangle(C.DisplayRectangle.Location, new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height - 1)), 270, -90);
            Terminator.AddArc(new Rectangle(C.DisplayRectangle.Location, new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height - 1)), 180, -90);
            Terminator.AddArc(new Rectangle(new Point(C.DisplayRectangle.Width - C.DisplayRectangle.Height - 1, C.DisplayRectangle.Top),
                new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height - 1)), 90, -90);
            Terminator.AddArc(new Rectangle(new Point(C.DisplayRectangle.Width - C.DisplayRectangle.Height - 1, C.DisplayRectangle.Top),
                new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height - 1)), 0, -90);
            Terminator.CloseFigure();
            e.DrawPath(new Pen(Line_Color), Terminator);
        }
        public static void Draw_Terminator(Graphics e, Color Line_Color, Rectangle C)
        {
            e.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath Terminator = new GraphicsPath();
            Terminator.AddArc(new Rectangle(C.Location, new Size(C.Height, C.Height - 1)), 270, -90);
            Terminator.AddArc(new Rectangle(C.Location, new Size(C.Height, C.Height - 1)), 180, -90);
            Terminator.AddArc(new Rectangle(new Point(C.Width - C.Height - 1, C.Top),
                new Size(C.Height, C.Height - 1)), 90, -90);
            Terminator.AddArc(new Rectangle(new Point(C.Width - C.Height - 1, C.Top),
                new Size(C.Height, C.Height - 1)), 0, -90);
            Terminator.CloseFigure();
            e.DrawPath(new Pen(Line_Color), Terminator);
        }
        #endregion
        #region Logging
        public static void Log(string add_msg, Exception ex) { Write_Log(add_msg + ": " + ex.Message); }
        public static void Log(string msg) { Write_Log(msg); }
        public static void Write_Log(string msg)
        {
            if (Properties.Settings.Default.log == true)
            {
                try
                    {
                        File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Log.log",
                            DateTime.Now + " - " + msg + '\n');
                    }
                catch (Exception exc)
                    {
                        MessageBox.Show("Cannot Log details, " + exc.Message);
                    }
            }
        }
        #endregion
        #region Startup
        public static void CheckArgs(string[] Args)
        {
            foreach (var arg in Args)
            {
                switch(arg)
                {
                    case "log":
                        Properties.Settings.Default.log = true;
                        break;
                    case "devmode":
                        Properties.Settings.Default.devMode = true;
                        break;
                }
            }
        }
        public static void CheckData()
           {
               FixIE();
               if (CheckResult() == 7873)// N.I. Not Initialized
               {
                   Log("No app settings found in the system. App will act as if it was First-Run.");
                   CSubKey(@"Software\ADM");
                   ResetAsset();
                   SetKey(Rgk.Volume, "0");
                   SetKey(Rgk.Scale, "100");
                   var x = new NotifyIcon
                   {
                       Icon = Properties.Resources.AppIcon,
                       Visible = true,
                       BalloonTipTitle = "Hi there!",
                       BalloonTipText = "If you want to customize your desktop\nclick on the icon in the notification bar!"
                   };
                   x.BalloonTipClicked += new EventHandler(FirstStart);
                   x.BalloonTipClosed += new EventHandler(FirstStart);
                   x.ShowBalloonTip(1500);
                   x.Visible = false;
                   CheckData();
               }
               if (CheckResult() == 6582)// A.R. All Right
               {
                   Log("Check Complete. Normal Startup.");
                   StartShow();
                   Application.Run(new DeskSettings());
               }
               if (CheckResult() == 8277) { CSubKey(@"Software\ADM"); ResetAsset(); SetKey(Rgk.Color, "0-0-0"); CheckData(); }//R. M. Registry Missing
               if (CheckResult() == 678277) { SetKey(Rgk.Color, "0-0-0"); CheckData(); }//C. R. M. Color Registry Missing
               if (CheckResult() == 8677) { SetKey(Rgk.Volume, "0"); CheckData(); }//V. M. Volume Missing
               if (CheckResult() == 7777) { Log("Media file missing, setting default media file..."); ResetAsset(); CheckData(); }// M.M. Media Missing
               if (CheckResult() == 8377) { SetKey(Rgk.Scale, "100"); CheckData(); }//Scale Missing
           }
        public static int CheckResult()
           {
               using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
               { if (hkcu.OpenSubKey(Rname(Rgk.Adm)) == null) { return 7873; } //Not Initialized
                   else if ((Uri.TryCreate(ReadKey(Rgk.Path), UriKind.RelativeOrAbsolute, out var nothing))==false && File.Exists(hkcu.OpenSubKey(Rname(Rgk.Adm)).GetValue(Rname(Rgk.Path)).ToString()) == false || ReadKey(Rgk.Path) == null) { return 7777; } 
                   else if (ReadKey(Rgk.Color) == null) { return 678277; }
                   else if (ReadKey(Rgk.Volume) == null) { return 8677; }
                   else if (ReadKey(Rgk.Scale) == null || ReadKey(Rgk.Scale) == "0") { return 8377; }
                   else { return 6582; }
               }
           }
        private static void FirstStart(object sender, EventArgs e)
        {
            foreach(Form Frm in Application.OpenForms)
            {
                if (Frm is DeskSettings)
                    Frm.Show();
            }
        }
        public static void CheckOs()
        {
            if (float.Parse(System.Environment.OSVersion.Version.Major.ToString() + "." +
                System.Environment.OSVersion.Version.Minor.ToString()) <= 6.1)
                MessageBox.Show("Please update your Operative System to use this app");
            Application.Exit();
        }
        #endregion
        #region Online Data Processing
        public static int ParseLink(string input_link)
        {
            if (input_link.Contains("youtu.be") || input_link.Contains("youtube.com"))
            {
                SetKey(Rgk.Path, input_link);
                return 2;
            }
            if (Uri.TryCreate(input_link, UriKind.RelativeOrAbsolute, out Uri X))
            {
                SetKey(Rgk.Path, X.ToString());
                return 1;
            }
            else return 0;
        }
        public static string YoutubeIdParse(string fullUrl)
        {
            return fullUrl.Replace("youtu.be/", "")
                .Replace("http://", "")
                .Replace("https://", "")
                .Replace("www.youtube.com/watch?v=", "")
                .Replace("www.youtube.com/v/", "")
                .Replace("www.youtube.com/embed/", "")
                .Split('?')[0];
        }
        #endregion
        #region Media View
            #region Variables
        private static Random rnd = new Random();
        #endregion
            public static int File_Ext(string filename)
            {
                if (Uri.TryCreate(filename, UriKind.Absolute, out var n))
                {
                    if (filename.Contains("mp4") || filename.Contains("webm"))
                        return 1;
                    else if (filename.Contains("youtu") && filename.Contains("be"))
                        return 2;
                    else if (filename.Contains("dll"))
                        return 3;
                    else
                        return 0;
                }
                else
                    return -1;
            }
            public static void Update_View()
            {
                Log("Updating media player.");
                Delete_Player_Files();
                Generate_Player_Files(File_Ext(ReadKey(Rgk.Path)));
            }
            public static void Generate_Player_Files(int filetype)
            {
                try{
                    Properties.Settings.Default.HTML_Location = 
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            @"\ADM_" + rnd.Next(DateTime.Now.Millisecond).ToString() + ".html";
                    //MessageBox.Show(Properties.Settings.Default.HTML_Location);
                    switch(filetype)
                    {
                        case 3:
                            Log("User has selected a Custom Theme Format");
                            break;
                        default:
                            File.WriteAllText(Properties.Settings.Default.HTML_Location, HTML_Code(filetype));
                            break;
                    }
                    backform.Controls.Clear();
                    backform.Invalidate();
                }catch (Exception Ex)
                   {
                       Log("Cannot create Player media files. Closing Application...", Ex);
                       Application.Exit();
                   }
            }
            public static string HTML_Code(int filetype)
            {
                string ctop = 
                @"<!DOCTYPE html>
                  <html><style>
		             *{margin:0;background-color:#" + Color_to_hex(Color_Check()) + @"; -ms-overflow-style: none;}
		             .adm{position:absolute;width:" + ReadKey(Rgk.Scale) + @"%;
                        bottom:50%;right:50%;transform: translate(50%,50%);"+
                        ReadKey(Rgk.Effects)+@"}
	              </style><body>";
                string cend =@"</body></html>";
                switch(filetype)
                {
                    case 0:
                        Log("User has selected an image.");
                        return ctop +
                        @"<img class=""adm"" src=""" + new Uri(ReadKey(Rgk.Path)).AbsoluteUri +@"""/>"
                        + cend;
                    case 1:
                        Log("User has selected a video.");
                        return ctop +
                        @"<video loop preload autoplay Id=""adm"" Class=""adm""> 
                        <source id=""source_polar_mp4"" src=""" + new System.Uri(ReadKey(Rgk.Path)).AbsoluteUri + @""" >
                        <script>var vid = document.getElementById(""adm"");
                        function setVolume(){vid.volume =" + (Convert.ToDouble(ReadKey(Rgk.Volume)) / 100).ToString().Replace(',', '.')
                        + ";}setVolume();</script>"
                        + cend;
                    case 2:
                        Log("User has selected a video from YouTube.");
                        return ctop +
                        #region Code Provided By Google
                        @"<div id=""adm"" class=""adm"" allow=""autoplay"">
                        <script>
                        var tag = document.createElement('script');
                        tag.src = ""https://www.youtube.com/iframe_api"";
                        var firstScriptTag = document.getElementsByTagName('script')[0];
                        firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);
                        var player;
                        function onYouTubeIframeAPIReady() {
                          player = new YT.Player('adm', {
                            height: '100%',
                            width: '100%',
                        videoId: '" + YoutubeIdParse(ReadKey(Rgk.Path)) + @"',
                        playerVars: {
                                    'autoplay': 1,
					    			'mute': 1,
                                    'controls': 0,           
                                    'showinfo': 0,
                                    'rel': 0,
					    			'loop': 1,
                                    'origin': null},
                        events: {
                                   'onReady': onPlayerReady,
					    		   'onStateChange': onPlayerStateChange
                                 }
                               });
                             }
                        function onPlayerReady(event) {
                        event.target.playVideo();}
					    function onPlayerStateChange(event) {}
                        </script></div>"
                    #endregion
                        + cend;
                    default:
                        return @"<h2 style=""font-family: Arial, Segoe Ui, sans-serif;
                                text-align: center;"">Unsupported file type or link not working.</h2>";
                }
            }
            public static void Delete_Player_Files()
            {
                try{
                    if(File.Exists(Properties.Settings.Default.HTML_Location))
                        File.Delete(Properties.Settings.Default.HTML_Location);
                }
                catch (Exception Ex)
                {
                    Console.Write(Ex.Message);
                    Log($"Cannot delete {Properties.Settings.Default.HTML_Location}. Delete it manually");
                }
            }
        #region ADT Custom Code
        public static void LoadADT()
        {
            bool ContainsUC = false;
            try
            {
                Assembly LOADEDFILE = Assembly.LoadFile(ReadKey(Rgk.Path));
                foreach (Type ASSEMBLYTYPE in LOADEDFILE.GetTypes())
                {
                    try
                    {
                        UserControl FACADE = new UserControl();
                        FACADE = (UserControl)Activator.CreateInstance(ASSEMBLYTYPE);
                        FACADE.Dock = DockStyle.Fill;
                        FACADE.Name = "ADT_FACADE";
                        backform.Controls.Add(FACADE);
                        FACADE.BringToFront();
                        ContainsUC = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (ContainsUC == false)
                    throw new Exception();
            }
            catch
            {
                Log($"Cannot parse {ReadKey(Rgk.Path)} correctly.");
                MessageBox.Show("This custom theme is not valid, re-download it try another file");
            }
        }
        public static Form LoadADTS()
        {
            try
            {
                Assembly LOADEDFILE = Assembly.LoadFile(ReadKey(Rgk.Path));
                foreach (Type ASSEMBLYTYPE in LOADEDFILE.GetTypes())
                {
                    try
                    {
                        if(Activator.CreateInstance(ASSEMBLYTYPE) is Form)
                        return (Form)Activator.CreateInstance(ASSEMBLYTYPE);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot parse dll file correctly: " + ex.Message);
                Log("Cannot parse dll file correctly", ex);
                return null;
            }
        }
        #endregion
        #endregion
        /*#region Effects
         public static int Eff_Type(string item)
        {
            foreach(var val in Obj_items.Eff_Control(true))
            {
                if (item.Contains(val.Item1))
                    return val.Item2;
            }
            return 10;
        }

        public static string eff_prefix(string EffName)
        {
            foreach (var val in Obj_items.Eff_Prefix())
            {
                if (EffName.Contains(val.Item1))
                    return val.Item2;
            }
            return null;
        }

        public static string[] ParseEffects()
        {
                return ReadKey(Rgk.Effects).Split(';');
        }

        public static void Parse_Single(string EffName, out string ArgExt, out int MaxVal,
            out int EffId, out bool PosNeg, out int EffArg)
        {
            switch(Eff_Type(EffName))
            {
                case 0:
                    ArgExt = "deg";
                    MaxVal = 360;
                    PosNeg = true;
                    break;
                case 1:
                    ArgExt = "deg";
                    MaxVal = 360;
                    PosNeg = true;
                    break;
                case 2:
                    ArgExt = "%";
                    MaxVal = 100;
                    PosNeg = false;
                    break;
                case 3:
                    ArgExt = "px";
                    MaxVal = 1000;
                    PosNeg = false;
                    break;
                case 4:
                    ArgExt = "";
                    MaxVal = 100;
                    PosNeg = false;
                    break;
                default:
                    ArgExt = "err";
                    MaxVal = 0;
                    PosNeg = false;
                    break;
            }
            try
            {
                EffArg = Convert.ToInt32(EffName.Split('(')[1].Split(')')[0]);
            }
            catch
            { EffArg = 0; }
            EffId = Eff_Type(EffName);
        }
        #endregion*/
        #region Project
            #region Installing
            public string Check_Integrity(string file)
            {
                var Spr = SHA256.Create();
                Stream fl_h = new FileStream(file, FileMode.Open);
                return Encoding.UTF8.GetString(Spr.ComputeHash(fl_h));
            }
            #endregion
        #endregion
    }
}
