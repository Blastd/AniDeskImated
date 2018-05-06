using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;
namespace AniDeskimated.Forms.Controls
{
    public partial class Round_Button : UserControl
    {
        public Round_Button(){InitializeComponent();}
        private void Button_Part_Paint(object sender, PaintEventArgs e)
        {
            MainFunctions.Draw_Terminator(e.Graphics, Button_Part.Width, Button_Part.Height,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 20),
            Color.FromArgb(255, 32, 32, 32),
            Button_Part.Text,MainFunctions.IntProportion(30, 10, this.Height), FontStyle.Bold,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 120));
        }
        private void Button_Part_MouseHover(object sender, EventArgs e)
        {
            Graphics Hover = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Hover, Button_Part.Width, Button_Part.Height,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 10),
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), -10),
            Button_Part.Text, MainFunctions.IntProportion(30, 10, this.Height), FontStyle.Underline,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 105));
        }
        private void Button_Part_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics Down = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Down, Button_Part.Width, Button_Part.Height,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 5),
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), -15),
            Button_Part.Text, MainFunctions.IntProportion(30, 10, this.Height), FontStyle.Underline,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 90));
        }
        private void Button_Part_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics Up = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Up, Button_Part.Width, Button_Part.Height,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 10),
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), -10),
            Button_Part.Text, MainFunctions.IntProportion(30, 10, this.Height), FontStyle.Bold,
            MainFunctions.VariableColor(Color.FromArgb(255, 32, 32, 32), 105));
        }
        private void Button_Part_MouseLeave(object sender, EventArgs e) { Button_Part.Invalidate(); }
        private void Button_Part_Click(object sender, EventArgs e){this.InvokeOnClick(this,e);}
    }
}
