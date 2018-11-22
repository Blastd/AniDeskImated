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
            this.Opacity = 0;
            Graphics Image_graphics = Graphics.FromHdc(GetDC(IntPtr.Zero));
            IntPtr Image_handle = Image_graphics.GetHdc();
            int Sel_Px = (int)GetPixel(Image_handle, e.Location.X, e.Location.Y);
            Color Pixel_color = Color.FromArgb((Sel_Px & 0x000000FF), (Sel_Px & 0x0000FF00) >> 8, (Sel_Px & 0x00FF0000) >> 16);
            MainFunctions.ChangeColor(Pixel_color);
            this.Close();
        }
        private void Color_Picker_Frame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Click anywhere to pick a color from the screen.", new Font("Segoe Ui Black", 14),
                       new SolidBrush(Color.FromArgb(255, 0, 148, 255)),
                       MainFunctions.String_Centre("Click anywhere to pick a color from the screen.", e.Graphics, this.Size, new Font("Segoe Ui Black", 14)));
        }
        #region Custom Cursor
        private void Color_Picker_Frame_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(LoadCursorFromFile(
               System.IO.Directory.GetDirectoryRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "\\Windows\\Cursors\\aero_pen.cur"));
        }
        #endregion
        #endregion
    }
}
