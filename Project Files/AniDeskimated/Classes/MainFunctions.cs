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

namespace AniDeskimated.Classes
{
    class MainFunctions
    {
        #region Maths
            //Remember that the proportions code follows the formula     a1:a2=b1:x     where x is the given value
            public static double Proportion(double a1, double a2, double b1) { return (a2 * b1) / a1; }
            public static int IntProportion(double a1, double a2, double b1) { return (int)Math.Floor((decimal)((a2 * b1) / a1)); }
            //Remember that the inverted proportions code follows the formula     a1*a2=b1*x     where x is the given value
            public static double InvertedProportion(double a1, double a2, double b1) { return (a1 * a2) / b1; }
            public static int IntInvertedProportion(double a1, double a2, double b1) { return (int)Math.Floor((decimal)((a1 * a2) / b1)); }
        #endregion
        #region Registry Management
            public static void ResetAsset()
            {
                Log("Resetting Asset...");
                try { Directory.CreateDirectory(Properties.Settings.Default.AppletPath + @"\ADM"); } catch (Exception ex) { Log("Directory already exists.",ex); Console.WriteLine(ex.Message); }
                try { File.WriteAllBytes(Properties.Settings.Default.AppletPath + @"\ADM\NoMedia.gif", Properties.Resources.NoMedia);
                    ChangeAsset(Properties.Settings.Default.AppletPath + @"\ADM\NoMedia.gif"); } catch (Exception ex)
                { Log("Cannot restore Placeholder Image. Closing. - " + ex.Message); Application.Exit(); }
            }
            public static void ChangeAsset(string fl_p)
            {
                SetKey("contentPath", fl_p);
                Update_View();
            }
            public static void ChangeVolume(int val)
            {
                SetKey("volumeValue", val.ToString());
                Update_View();
            }
            public static void ChangeScale(int prc)
            {
                SetKey("viewScale", prc.ToString());
                Update_View();
            }
            public static void ChangeColor(Color pxc) {
                MainFunctions.SetKey("colorFill", pxc.R.ToString() + "-" + pxc.G.ToString() + "-" + pxc.B.ToString());
                Update_View();
            }
            public static Color Color_Check()
            {
                Color Color_Test = Color.Black;
                try
                {
                    string[] Reg_Value = MainFunctions.ReadKey("colorFill").Split('-');
                    Color_Test = Color.FromArgb(255, Convert.ToInt32(Reg_Value[0]), Convert.ToInt32(Reg_Value[1]), Convert.ToInt32(Reg_Value[2]));
                    return Color_Test;
                }
                catch (Exception Ex) { Console.WriteLine(Ex.Message); MainFunctions.Log(Ex.Message); MainFunctions.SetKey("colorFill", "000-000-000"); return Color_Check(); }
            }
            public static void CSubKey(string Keypath)
            {
                using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    hkcu.CreateSubKey(Keypath, true);
            }
            public static void SetKey(string ValueName, string Value)
            {
                using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    hkcu.OpenSubKey(@"Software\ADM", true).SetValue(ValueName, Value);
            }
            public static void FixIE()
            {
                using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    FileInfo FileH = new FileInfo(new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
                    hkcu.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true)
                        .SetValue(FileH.Name, 0x2AF9,RegistryValueKind.DWord);
                }
            }
            public static void WinStartup(bool boot_state)
            {
                if (boot_state) {
                    using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).SetValue("Animated Desktop - ADM", 
                            new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
                }else
                {
                    using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("Animated Desktop - ADM");
                }
                
            }
            public static string ReadKey(string KeyName)
            {
                try
                {
                    using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        return hkcu.OpenSubKey(@"Software\ADM", true).GetValue(KeyName).ToString();
                } catch (Exception Ex) { Log("Cannot read Registry Keys", Ex); return "0"; }
            }
            public static void DelVal(string ValueName)
            {
                try
                {
                    using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        hkcu.OpenSubKey(@"Software\ADM", true).DeleteValue(ValueName);
                } catch (Exception X)
                {
                    Console.WriteLine(X.Message);
                }
            }
        #endregion
        #region Graphics
            #region Center String
        public static Point String_Centre(string Txt, Graphics Ctrl_G, Size Ctrl_size, Font font_type, int offset_x, int offset_y)
        {
            return new Point(((Ctrl_size.Width / 2) - (Convert.ToInt32(Math.Ceiling(Ctrl_G.MeasureString(Txt, font_type).Width) / 2)) + 1) - offset_x,
                (Ctrl_size.Height / 2) - ((Convert.ToInt32(Math.Ceiling(Ctrl_G.MeasureString(Txt, font_type).Height) / 2)) + 1) - offset_y);
        }
        public static Point String_Centre(string Txt, Graphics Ctrl_G, Size Ctrl_size, Font font_type)
        {
            return new Point(((Ctrl_size.Width / 2) - (Convert.ToInt32(Math.Ceiling(Ctrl_G.MeasureString(Txt, font_type).Width) / 2)) + 1),
                (Ctrl_size.Height / 2) - ((Convert.ToInt32(Math.Ceiling(Ctrl_G.MeasureString(Txt, font_type).Height) / 2)) + 1));
        }
        #endregion
            public static Color SuitableContrast(Color Color_input)
        {
            {
                if ((double)((Color_input.R + Color_input.G + Color_input.B) / 3) <= 127.5)
                { return Color.White; } else { return Color.Black; }
            }
        }
            public static int ColorContrast(Color Base, int value){
            if (((Base.R + Base.G + Base.B) / 3) <= 127.5)
                return value * 1;
            else
                return value * -1;
        }
            public static Color VariableColor(Color Base, int Delta){
                int ResR, ResG, ResB;
                ResR = Base.R + Delta;
                ResG = Base.G + Delta;
                ResB = Base.B + Delta;
                if (ResR < 0) { ResR = 0; } else if (ResR > 255) { ResR = 255; }
                if (ResG < 0) { ResG = 0; } else if (ResG > 255) { ResG = 255; }
                if (ResB < 0) { ResB = 0; } else if (ResB > 255) { ResB = 255; }
                return Color.FromArgb(Base.A, ResR, ResG, ResB);
            }
            public static string Color_to_hex(Color Oc)
            {
                return Oc.R.ToString("X2") + Oc.G.ToString("X2") + Oc.B.ToString("X2");
            }
            public static void Draw_Terminator(Graphics e, Color Line_Color,Control C)
        {
            e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GraphicsPath Terminator = new GraphicsPath();
            Terminator.AddArc(new Rectangle(C.DisplayRectangle.Location, new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height-1)), 270, -90);
            Terminator.AddArc(new Rectangle(C.DisplayRectangle.Location, new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height-1)), 180, -90);
            Terminator.AddArc(new Rectangle(new Point(C.DisplayRectangle.Width - C.DisplayRectangle.Height-1, C.DisplayRectangle.Top),
                new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height-1)), 90, -90);
            Terminator.AddArc(new Rectangle(new Point(C.DisplayRectangle.Width - C.DisplayRectangle.Height-1, C.DisplayRectangle.Top),
                new Size(C.DisplayRectangle.Height, C.DisplayRectangle.Height-1)), 0, -90);
            Terminator.CloseFigure();
            e.DrawPath(new Pen(Line_Color), Terminator);
        }
            #endregion
        #region Logging
            public static void Log(string add_msg, Exception ex) { Write_Log(add_msg + ": " + ex.Message); }
            public static void Log(string msg) { Write_Log(msg); }
            public static void Write_Log(string msg)
            {
                if (Properties.Settings.Default.nolog == false)
                { try { if (!File.Exists(Properties.Settings.Default.AppletPath)) { System.IO.File.WriteAllText(Properties.Settings.Default.AppletPath + @"\Log.log", '\n' + DateTime.Now.ToString() + " - " + msg); }
                        else { { System.IO.File.WriteAllText(Properties.Settings.Default.AppletPath + @"\Log.log",
                                  System.IO.File.ReadAllText(Properties.Settings.Default.AppletPath + @"\Log.log") + '\n' + DateTime.Now + " - " + msg); } } } catch (Exception exc)
                    { MessageBox.Show("Cannot Log details, " + exc.Message); } }
            }
        #endregion
        #region App Data Check
           public static void CheckData()
           {
               FixIE();
               if (CheckResult() == 7873)// N.I. Not Initialized
               {
                   Log("No app settings found in the system, first Run routine.");
                   CSubKey(@"Software\ADM");
                   ResetAsset();
                   Properties.Settings.Default.NormalStartup = false;
                   ChangeVolume(0);
                   ChangeScale(100);
                   CheckData();
               }
               if (CheckResult() == 6582)// A.R. All Right
               {
                   Log("Check Complete. Normal Startup.");
                   Application.Run(new DeskSettings());
               }
               if (CheckResult() == 8277) { CSubKey(@"Software\ADM"); ResetAsset(); SetKey("colorFill", "0-0-0"); CheckData(); }//R. M. Registry Missing
               if (CheckResult() == 678277) { SetKey("colorFill", "0-0-0"); CheckData(); }//C. R. M. Color Registry Missing
               if (CheckResult() == 8677) { ChangeVolume(0); CheckData(); }//V. M. Volume Missing
               if (CheckResult() == 7777) { Log("Media file missing, setting default media file..."); ResetAsset(); CheckData(); }// M.M. Media Missing
               if (CheckResult() == 8377) { SetKey("viewScale", "100"); CheckData(); }//Scale Missing
           }
           public static int CheckResult()
           {
               using (var hkcu = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
               { if (hkcu.OpenSubKey(@"Software\ADM") == null && Directory.Exists(@Properties.Settings.Default.AppletPath + @"\ADM\") == false) { return 7873; } //Not Initialized
                   else if (hkcu.OpenSubKey(@"Software\ADM") == null) { return 8277; } //Registry Missing
                   else if ((Uri.TryCreate(ReadKey("contentPath"), UriKind.RelativeOrAbsolute, out var nothing))==false && File.Exists(hkcu.OpenSubKey(@"Software\ADM").GetValue("contentPath").ToString()) == false || ReadKey("contentPath") == null) { return 7777; } 
                   else if (ReadKey("colorFill") == null) { return 678277; }
                   else if (ReadKey("volumeValue") == null) { return 8677; }
                   else if (ReadKey("viewScale") == null || ReadKey("viewScale") == "0") { return 8377; }
                   else { return 6582; }
               }
           }
        #endregion
        #region Online Data Processing
        public static int ParseLink(string input_link)
        {
            if (input_link.Contains("youtu.be") || input_link.Contains("youtube.com"))
            {
                return 2;
            }
            if (Uri.TryCreate(input_link, UriKind.RelativeOrAbsolute, out Uri X))
            {
                ChangeAsset(X.ToString());
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
                .Replace("www.youtube.com/embed/", "").Split('?')[0];
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
                {
                    return 1;
                }
                else if (filename.Contains("youtu") && filename.Contains("be"))
                {
                    return 2;
                }
                else if (filename.Contains("dll"))
                {
                    return 3;
                }
                else
                    return 0;
            }
            else
                return -1;
        }
            public static void Update_View()
            {
                foreach (Control CRem in DeskSettings.backform.Controls) { CRem.Dispose(); }
                if (File.Exists(Properties.Settings.Default.HTML_Location) == true)
                { Delete_Player_Files();}
                MainFunctions.Generate_Player_Files(MainFunctions.File_Ext(MainFunctions.ReadKey("contentPath")));
            }
            public static void Generate_Player_Files(int filetype)
            {try
                {
                    if (filetype == 3)
                    {
                        Log("Detected custom theme format.");
                        DeskSettings.backform.Invalidate();
                        return;
                    }
                    Log("Creating Player media files...");
                    Properties.Settings.Default.HTML_Location = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        @"\ADM_" + rnd.Next(DateTime.Now.Second).ToString() + rnd.Next(DateTime.Now.Millisecond).ToString() + ".html";
                    if (File.Exists(Properties.Settings.Default.HTML_Location) == false)
                    {
                     try {
                            File.WriteAllText(Properties.Settings.Default.HTML_Location, Generate_HTML_Code(filetype)); }
                        catch (Exception Ex)
                        { Log("Cannot Create HTML file.", Ex); }System.Threading.Thread.Sleep(250); DeskSettings.backform.Invalidate();}
                    else{Generate_Player_Files(filetype);
                    }} catch (Exception Ex)
                { Log("Cannot create Player media files. Closing Application...", Ex);Application.Exit(); }}
            public static string Generate_HTML_Code(int filetype)
            {
                if (filetype == 1) {
                    return @"<!DOCTYPE html><meta http-equiv='Content-Type' content='text/html; charset=unicode' />
                        <meta http-equiv='X-UA-Compatible' content='IE=9' /><html><style>* {margin: 0;padding: 0;}
                        .videocontainer {display: grid;height: 100%;position: relative;}.videofile {max-width: " + ReadKey("viewScale") + @"%;max-height: " + ReadKey("viewScale") + @"vh;margin: 0 auto;display: block;}
                        </style><body bgcolor=""#" + Color_to_hex(Color_Check()) + @"""> <div class=""videocontainer""><video loop preload autoplay Id=""videofile"" Class=""videofile""> 
                        <source id=""source_polar_mp4"" src=""" + new System.Uri(ReadKey("contentPath")).AbsoluteUri + @""" ><script>"
                        + @"var vid = document.getElementById(""videofile"");function setVolume(){vid.volume =" + (Convert.ToDouble(ReadKey("volumeValue"))/100).ToString().Replace(',','.')
                        + ";}setVolume();</script></video></div></body></html>";}
                else if (filetype == 0) {
                    return @"<!DOCTYPE html><meta http-equiv='Content-Type' content='text/html; charset=unicode' />
                        <meta http-equiv='X-UA-Compatible' content='IE=9' /><html><style>* {margin: 0;padding: 0;}
                        .imgcontainer {display: grid;height: 100%;position: relative;}.imgfile {max-width: "+ ReadKey("viewScale") + @"%;max-height: " + ReadKey("viewScale") + @"vh;margin: 0 auto;display: block;}
                        </style><body bgcolor=""#" + Color_to_hex(Color_Check()) + @"""> <div class=""imgcontainer""><img class=""imgfile"" src='" +
                         new System.Uri(ReadKey("contentPath")).AbsoluteUri + "'>" + "<script></script></div></body></html>";}
                else if (filetype == 2) {
                    #region code samples provided by Google https://developers.google.com/youtube/iframe_api_reference
                return @"<!DOCTYPE html><meta http-equiv='Content-Type' content='text/html; charset=unicode' />
                    <meta http-equiv='X-UA-Compatible' content='IE=9' /><html><style>* {margin: 0;padding: 0;}
                    .videocontainer {display: grid;height: 100%;position: relative;}.videofile {max-width: " + ReadKey("viewScale") +
                    @"%;max-height: " + ReadKey("viewScale") + @"vh;margin: 0 auto;display: block;}
                    </style><body bgcolor=""#" + Color_to_hex(Color_Check()) + @"""> <div class=""videocontainer"">
                    <div id=""videofile"" class=""videofile"" allow=""autoplay"">
                    <script>
                    var tag = document.createElement('script');
                    tag.src = ""https://www.youtube.com/iframe_api"";
                    var firstScriptTag = document.getElementsByTagName('script')[0];
                    firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);
                    var player;
                    function onYouTubeIframeAPIReady() {
                      player = new YT.Player('videofile', {
                        height: '3000',
                        width: '3000',
                    videoId: '" + YoutubeIdParse(ReadKey("contentPath")) + @"',
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
                    event.target.setVolume(10);
                    event.target.playVideo();
					event.target.unMute();
                    }
					function onPlayerStateChange(event) {
					        
					}</script></div></div></body ></html >";
                #endregion
                    //return @"<p style=""font-family: Arial, Helvetica, sans-serif;text-align: center;"">Youtube Links are not supported</p>";
                }
                else { return @"<p style=""font-family: Arial, Helvetica, sans-serif;text-align: center;"">Unsupported file type or Link not working</p>"; }
            }
            public static void Delete_Player_Files(){try{File.Delete(Properties.Settings.Default.HTML_Location);}
            catch (Exception Ex)
                { Console.Write(Ex.Message);
                Log(@"Cannot delete Media Player Files, you may delete them  manually. They're located in %Appdata%\<random>.html and <random>.css");}}
            #region ADT Custom Code
        public static void LoadADT()
        {
            bool ContainsUC = false;
            try
            {
                Assembly LOADEDFILE = Assembly.LoadFile(ReadKey("contentPath"));
                foreach (Type ASSEMBLYTYPE in LOADEDFILE.GetTypes())
                {
                    try
                    {
                        UserControl FACADE = new UserControl();
                        FACADE = (UserControl)Activator.CreateInstance(ASSEMBLYTYPE);
                        FACADE.Dock = DockStyle.Fill;
                        FACADE.Name = "ADT_FACADE";
                        DeskSettings.backform.Controls.Add(FACADE);
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
            catch (Exception ex)
            {
                Console.WriteLine("Cannot parse dll file correctly: "+ex.Message);
                Log("Cannot parse dll file correctly",ex);
                MessageBox.Show("Something is telling me that this custom theme is not valid");
            }
        }
        public static Form LoadADTS()
        {
            try
            {
                Assembly LOADEDFILE = Assembly.LoadFile(ReadKey("contentPath"));
                foreach (Type ASSEMBLYTYPE in LOADEDFILE.GetTypes())
                {
                    try
                    {
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
    }
}
