using AniDeskimated.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniDeskimated.Forms.Controls
{
    public partial class LinkInput : Form
    {
        public LinkInput()=>InitializeComponent();
        #region Events
        private void input_box_KeyDown(object sender, KeyEventArgs e){
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
