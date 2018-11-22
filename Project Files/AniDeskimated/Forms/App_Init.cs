/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using AniDeskimated.Classes;
namespace AniDeskimated.Forms
{
    public partial class App_Init : Form
    {
        public App_Init(){InitializeComponent();}
        #region Form Events
        private void StartBackground_Load(object sender, EventArgs e)
        {
            this.Activate();
            ViewFrame.Image = Image.FromFile(MainFunctions.ReadKey("contentPath"));
            Button_Refuse.Button_Part.Text = "Not now";
            Button_NewFile.Button_Part.Text = "Change background";
            Button_Informations.Button_Part.Text = "License";
        }
        private void FirstStart_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {MessageBox.Show("A first-timer, uh? Don't worry, it's going to be easy." + '\n' +
                @"Just click on the big green button that says ""Change my look""." + '\n' +
                "A small menù should appear, from which you can select a MEDIA FILE" + '\n' +
                "(Either a video or a Picture), that can be located on the internet," + '\n' +
                "providing the program an address to reach that file (not implemented)," + '\n' +
                "or a file stored on your computer." + '\n' + "Yes, that's it.", "How does it work?", MessageBoxButtons.OK, MessageBoxIcon.Question);}
        private void Button_Informations_Click(object sender, EventArgs e)
        {
            App_Lcs Frm_License = new App_Lcs(); Frm_License.ShowDialog();
        }
        private void Button_Refuse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region ChangingImage
        private void Button_NewFile_Click(object sender, EventArgs e)
        {
            BackMenuChoose.Show(MousePosition.X - 50 % BackMenuChoose.Width,
                MousePosition.Y - 50 % BackMenuChoose.Height);
        }
        private void BackMenu_Gif_Click(object sender, EventArgs e)
        {
            GetMediaFile.ShowDialog();
        }
        private void GetMediaFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try {
                    if (MainFunctions.File_Ext(GetMediaFile.FileName) == 0)
                    {
                        ViewFrame.Image = Image.FromFile(GetMediaFile.FileName);
                    }
                    else
                    {
                        ViewFrame.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    MainFunctions.ChangeAsset(GetMediaFile.FileName);
                    this.Close();
                }
            catch (Exception Ex)
            {
                Console.Write(Ex.Message);
                MainFunctions.Log("Entered an invalid media file.");
                Graphics ViewFrameG = ViewFrame.CreateGraphics();
                ViewFrameG.DrawString("Try Another Image", new Font("Segoe Ui Black", 12),
                    new SolidBrush(Color.FromArgb(255, 0, 148, 255)), 
                    MainFunctions.String_Centre("Try Another Image", ViewFrameG, ViewFrame.Size, 
                    new Font("Segoe Ui Black", 12)));
            }
        }
        #endregion
        #endregion
    }
}
