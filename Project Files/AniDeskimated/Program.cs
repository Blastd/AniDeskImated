/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Windows.Forms;
using AniDeskimated.Classes;

namespace AniDeskimated
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            MainFunctions.CheckArgs(args);
            MainFunctions.CheckData();
        }        
    }
}
