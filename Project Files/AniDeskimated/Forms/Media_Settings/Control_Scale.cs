using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Control_Scale : UserControl
    {
        public Control_Scale()
        {InitializeComponent();}
        private void Button_Done_Click(object sender, EventArgs e){ MainFunctions.ChangeScale(Scale_Tracker.Value);this.Visible = false; }
        private void Control_Scale_Load(object sender, EventArgs e)
        { Button_Done.Button_Part.Text = "Done"; Scale_Tracker.Value = Convert.ToInt32(MainFunctions.ReadKey("viewScale"));
            Label_StatusPercentage.Text = MainFunctions.ReadKey("viewScale") + '%'; ScaleView.Invalidate(); }
        private void Scale_Tracker_Scroll(object sender, EventArgs e) { Label_StatusPercentage.Text = Scale_Tracker.Value.ToString() + '%';ScaleView.Invalidate(); }
        private void ScaleView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(
                new Point((ScaleView.Width - (Scale_Tracker.Value%ScaleView.Width))/2,
                (ScaleView.Height - (Scale_Tracker.Value % ScaleView.Height)) / 2),
                new Size(Scale_Tracker.Value % ScaleView.Width, Scale_Tracker.Value % ScaleView.Height)));
            if(Scale_Tracker.Value == 100) { e.Graphics.FillRectangle(new SolidBrush(Color.White),new Rectangle(new Point(0, 0), ScaleView.Size)); }
        }
    }
}
