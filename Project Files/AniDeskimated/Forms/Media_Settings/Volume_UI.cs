using AniDeskimated.Classes;
using System;
using System.Windows.Forms;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Volume_UI : Form
    {
        public Volume_UI(){InitializeComponent();}
        #region Events
        #region Form
        private void Volume_UI_Load(object sender, EventArgs e) { Button_Done.Button_Part.Text = "Done"; Volume_Traker.Value = Convert.ToInt32(MainFunctions.ReadKey("volumeValue")); }
        private void Volume_Traker_ValueChanged(object sender, EventArgs e) { Label_StatusPercentage.Text = Volume_Traker.Value.ToString() + '%'; }
        private void Button_Done_Click(object sender, EventArgs e)
        {
            MainFunctions.ChangeVolume(Volume_Traker.Value);
            this.Close();
        }
        #endregion
        #endregion
    }
}
