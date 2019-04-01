/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Control_Scale : UserControl
    {
        public Control_Scale()
        {InitializeComponent();}
        #region Events
        private void Button_Exit_Click(object sender, EventArgs e) { this.Parent.Controls.Remove(this); }
        private void Scale_Tracker_Scroll(object sender, EventArgs e) { Label_StatusPercentage.Text = Scale_Tracker.Value.ToString() + '%'; ScaleView.Invalidate(); }
        private void ScaleView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(
                new Point((ScaleView.Width - ((Scale_Tracker.Value * ScaleView.Width) / 100)) / 2,
                (ScaleView.Height - ((Scale_Tracker.Value * ScaleView.Height) / 100)) / 2),
                new Size((Scale_Tracker.Value * ScaleView.Width) / 100, Scale_Tracker.Value % ScaleView.Height)));
            if (Scale_Tracker.Value >= 100) { e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(0, 0), ScaleView.Size)); }
        }
        private void Button_Done_Click(object sender, EventArgs e) { MainFunctions.SetKey(MainFunctions.Rgk.Scale,Scale_Tracker.Value.ToString()); this.Visible = false; }
        private void Scale_Tracker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Shift)
                Scale_Tracker.SmallChange = 5;
        }
        private void Scale_Tracker_KeyUp(object sender, KeyEventArgs e) { Scale_Tracker.SmallChange = 1; }
        private void Control_Scale_Load(object sender, EventArgs e){
            #region Button Properties
            Button_Done.Button_Part.Text = "";
            Button_Done.Button_Part.Font = new Font("Segoe MDL2 Assets", Button_Done.Button_Part.Font.Size, FontStyle.Regular);
            Button_Done.ButtonColor = Color.Green;
            Button_Undo.Button_Part.Text = "";
            Button_Undo.Button_Part.Font = new Font("Segoe MDL2 Assets", Button_Done.Button_Part.Font.Size, FontStyle.Regular);
            Button_Undo.ButtonColor = Color.Red;
            #endregion
            Scale_Tracker.Value = Convert.ToInt32(MainFunctions.ReadKey(MainFunctions.Rgk.Scale));
            Label_StatusPercentage.Text = MainFunctions.ReadKey(MainFunctions.Rgk.Scale) + '%'; ScaleView.Invalidate();
        }
        #endregion
        private void Control_Scale_VisibleChanged(object sender, EventArgs e)
        { ScaleView.Invalidate(); }
        private void Button_Undo_Load(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
