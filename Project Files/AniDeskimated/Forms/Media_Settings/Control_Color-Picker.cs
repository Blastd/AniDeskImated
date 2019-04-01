/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using AniDeskimated.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AniDeskimated.Forms.Interfaces
{
    public partial class Color_Picker_Frame : Form
    {
        public Color_Picker_Frame()=>InitializeComponent();
        #region Functions
        [DllImport("User32.dll", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        private static extern IntPtr LoadCursorFromFile(String str);
        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        static extern IntPtr GetDC(IntPtr hWnd);
        #endregion        
        #region FormEvents
        private void Color_Picker_Frame_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    this.Opacity -= 0.04;
                    System.Threading.Thread.Sleep(16);
                }
                Graphics Image_graphics = Graphics.FromHdc(GetDC(IntPtr.Zero));
                IntPtr Image_handle = Image_graphics.GetHdc();
                int Sel_Px = (int)GetPixel(Image_handle, e.Location.X, e.Location.Y);
                Color Cl = Color.FromArgb((Sel_Px & 0x000000FF), (Sel_Px & 0x0000FF00) >> 8, (Sel_Px & 0x00FF0000) >> 16);
                MainFunctions.SetKey(MainFunctions.Rgk.Color,
                    Cl.R.ToString() +
                    "-" + Cl.G.ToString() +
                    "-" + Cl.B.ToString());
            }catch(Exception x) { MessageBox.Show(x.Message); }
                this.Close();
        }
        #region Custom Cursor
        private void Color_Picker_Frame_Load(object sender, EventArgs e)
        {
            Rectangle ScrWidth = new Rectangle();
            this.Cursor = new Cursor(LoadCursorFromFile(
               System.IO.Directory.GetDirectoryRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "\\Windows\\Cursors\\aero_pen.cur"));
            foreach(var Scr in Screen.AllScreens)
            {
                ScrWidth = Rectangle.Union(ScrWidth, Scr.Bounds);
            }
            this.Top = ScrWidth.Top;
            this.Left = ScrWidth.Left;
            this.Size = ScrWidth.Size;
        }
        #endregion
        #endregion
    }
}
