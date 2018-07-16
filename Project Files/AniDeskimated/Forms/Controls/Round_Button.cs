using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;
namespace AniDeskimated.Forms.Controls
{
    public partial class Round_Button : UserControl
    {
        public Round_Button()=>InitializeComponent();
        private void Button_Part_Paint(object sender, PaintEventArgs e)
        {
            this.ForeColor =MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 110));
            MainFunctions.Draw_Terminator(e.Graphics,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 20)),this);
        }
        private void Button_Part_MouseHover(object sender, EventArgs e)
        {
            Graphics Hover = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Hover,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 10)),this);
        }
        private void Button_Part_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics Down = Button_Part.CreateGraphics();
            MainFunctions.Draw_Terminator(Down,
            MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 5)),this);
        }
        private void Button_Part_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Graphics Up = Button_Part.CreateGraphics();
                MainFunctions.Draw_Terminator(Up,
                MainFunctions.VariableColor(MainFunctions.Color_Check(), MainFunctions.ColorContrast(MainFunctions.Color_Check(), 10)),this);
            }catch (Exception Ex){ Console.WriteLine(Ex.Message);MainFunctions.Log(Ex.Message); }
        }
        private void Button_Part_MouseLeave(object sender, EventArgs e) =>Button_Part.Invalidate();
        private void Button_Part_Click(object sender, EventArgs e) =>this.InvokeOnClick(this,e);
        private void Round_Button_Load(object sender, EventArgs e)=>
        Button_Part.Font = new Font(Button_Part.Font.FontFamily, (float)MainFunctions.Proportion(40, 12, this.Height), FontStyle.Regular);
    }
}
