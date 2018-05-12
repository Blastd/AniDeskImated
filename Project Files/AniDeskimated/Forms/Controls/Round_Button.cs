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
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 20)),
            MainFunctions.Color_Check(),
            Button_Part.Text,MainFunctions.IntProportion(30, 12, this.Height), FontStyle.Bold,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 150)));
        }
        private void Button_Part_MouseHover(object sender, EventArgs e)
        {
            Graphics Hover = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Hover, Button_Part.Width, Button_Part.Height,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 10)),
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), -10)),
            Button_Part.Text, MainFunctions.IntProportion(30, 12, this.Height), FontStyle.Bold,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 135)));
        }
        private void Button_Part_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics Down = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Down, Button_Part.Width, Button_Part.Height,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 5)),
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), -15)),
            Button_Part.Text, MainFunctions.IntProportion(30, 12, this.Height), FontStyle.Bold,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 120)));
        }
        private void Button_Part_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics Up = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Up, Button_Part.Width, Button_Part.Height,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 10)),
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), -10)),
            Button_Part.Text, MainFunctions.IntProportion(30, 12, this.Height), FontStyle.Bold,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 135)));
        }
        private void Button_Part_MouseLeave(object sender, EventArgs e) { Button_Part.Invalidate(); }
        private void Button_Part_Click(object sender, EventArgs e){this.InvokeOnClick(this,e);}
    }
}
