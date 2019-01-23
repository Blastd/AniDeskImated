using AniDeskimated.Classes;
using AniDeskimated.Forms.Elements;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AniDeskimated.Forms.Media_Settings
{
    public partial class Control_EffectsDesigner : Form
    {
        public Control_EffectsDesigner() => InitializeComponent();
        private void Control_EffectsDesigner_Load(object sender, EventArgs e)
        {
            /*Random XR = new Random();
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            if (MainFunctions.ParseEffects().Length>0)
            foreach (var X in MainFunctions.ParseEffects())
            {
                MainFunctions.Parse_Single(X,out string ArgExt, out int MaxVal, out int EffId,
                    out bool PosNeg, out int EffArg);
                if (ArgExt.ToString() != "err")
                {
                    var Zc = new Effect_Item();
                    Zc.Size = new Size(Top_container.Width, 125);
                    Zc.Dock = DockStyle.Top;
                    Zc.Name = (alpha.ToCharArray()[XR.Next() % 25] + alpha.ToCharArray()[XR.Next() % 25]).ToString();
                    Zc.EFF_Value.Maximum = MaxVal;
                    if (PosNeg)
                        Zc.EFF_Value.Minimum = -MaxVal;
                    Zc.EFF_Value.Value = EffArg;
                    Zc.Arg_Extension.Text = ArgExt;
                    Zc.Eff_Label.Text = Obj_items.GetEffName(X);
                    this.eff_Container.Controls.Add(Zc);*/
                }
    }
}
