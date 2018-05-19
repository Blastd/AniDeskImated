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
    public partial class Control_Volume : UserControl
    {
        public Control_Volume()
        {InitializeComponent();}
        private void Button_Done_Click(object sender, EventArgs e){ MainFunctions.ChangeVolume(Volume_Tracker.Value);this.Visible = false; }
        private void Control_Volume_Load(object sender, EventArgs e)
        { Button_Done.Button_Part.Text = "Done"; Volume_Tracker.Value = Convert.ToInt32(MainFunctions.ReadKey("volumeValue")); Label_StatusPercentage.Text = MainFunctions.ReadKey("volumeValue") + '%'; }
        private void Volume_Tracker_Scroll(object sender, EventArgs e){Label_StatusPercentage.Text = Volume_Tracker.Value.ToString() + '%';}
    }
}
