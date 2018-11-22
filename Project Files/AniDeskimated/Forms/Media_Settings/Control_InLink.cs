/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using AniDeskimated.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Control_InLink : Form
    {
        public Control_InLink()=>InitializeComponent();
        #region Events
        private void Input_box_KeyDown(object sender, KeyEventArgs e){
            if(e.KeyCode == Keys.Enter)
            Link_Try.Button_Part.PerformClick();
        }
        private void Link_Try_Click(object sender, EventArgs e)
        {
            Link_Try.Visible = false;
            input_box.ReadOnly = true;
            if (MainFunctions.ParseLink(input_box.Text) == 0)
            {
                Link_Try.Visible = true;
                input_box.ReadOnly = false;
                message_label.Text = "Something tells me that this address is wrong. Retry?";
            } else if(MainFunctions.ParseLink(input_box.Text) == 2)
            {
                Link_Try.Visible = true;
                input_box.ReadOnly = false;
                message_label.Text = "I am so sorry, but Youtube links aren't supported.";
            }
            else this.Close();
        }
        #region Form
        private void LinkInput_Load(object sender, EventArgs e){
            Link_Try.Button_Part.Font = new Font("Segoe MDL2 Assets", Link_Try.Font.Size, FontStyle.Regular);
            Link_Try.Button_Part.Text = "";
        }
        private void Button_Exit_Click(object sender, EventArgs e) { this.Close(); }
        #endregion
        #endregion
    }
}
