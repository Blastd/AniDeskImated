/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;
namespace AniDeskimated.Forms.Elements
{
    public partial class Round_Button : UserControl
    {
        public Round_Button()=>InitializeComponent();
        private void Button_Part_Paint(object sender, PaintEventArgs e)
        {
            MainFunctions.Draw_Terminator(e.Graphics,
                Color.White,this);
            Button_Part.ForeColor = Color.White;
        }
        private void Button_Part_MouseHover(object sender, EventArgs e)
        {
            Button_Part.Font = new Font(Button_Part.Font.FontFamily, Button_Part.Font.Size, FontStyle.Underline);
            Button_Part.ForeColor = MainFunctions.VariableColor(Color.White,
                MainFunctions.ColorContrast(Color.White, 30));
        }
        private void Button_Part_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics Down = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Down,
                MainFunctions.VariableColor(Color.White,
                    MainFunctions.ColorContrast(MainFunctions.Color_Check(), 30)),this);
            Button_Part.ForeColor = MainFunctions.VariableColor(Color.White,
                MainFunctions.ColorContrast(Color.White, 20));
        }
        private void Button_Part_MouseUp(object sender, MouseEventArgs e)
        {
                Graphics Up = Button_Part.CreateGraphics();
                MainFunctions.Draw_Terminator(Up,
                    MainFunctions.VariableColor(Color.White,
                        MainFunctions.ColorContrast(Color.White, 30)),this);
                Button_Part.ForeColor = MainFunctions.VariableColor(Color.White,
                    MainFunctions.ColorContrast(Color.White, 30));
        }
        private void Button_Part_MouseLeave(object sender, EventArgs e)
        {
            Button_Part.Font = new Font(Button_Part.Font.FontFamily, Button_Part.Font.Size, FontStyle.Regular);
            Button_Part.Invalidate();
        }
        private void Button_Part_Click(object sender, EventArgs e) =>this.InvokeOnClick(this,e);
        private void Round_Button_Load(object sender, EventArgs e)
        {
            Button_Part.Font = new Font(Button_Part.Font.FontFamily,
                (float)((12*this.Height)/40), FontStyle.Regular);
        }
    }
    public class Button_Part : Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
