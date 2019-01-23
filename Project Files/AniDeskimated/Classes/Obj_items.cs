/*AniDeskImated - By Blasted Mind
 * Draw Behind Desktop feature (Win32.cs and highlighted parts of DeskSettings.cs) are 3rd party derivates that are protected by the Code Project Open Licence (http://www.codeproject.com/info/cpol10.aspx).
 * This Program is released under the GNU LGPL v3.0 License
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniDeskimated.Classes
{
    public class Obj_items
    {
        /*#region Effects
        public static List<string> Effects()
        {
            return new List<string>
            {
                "rotate",       
                "hue-rotate",         
                "grayscale",    
                "blur",         
                "brightness",   
                "contrast",     
                "invert",       
                "opacity",      
                "saturate",     
                "sepia",        
            };
        }

        public static List<Tuple<string, int>> Eff_Control(bool search)
        {
            if (search)
                return new List<Tuple<string, int>>
            {
                new Tuple<string, int>(Effects()[0], 0),    // +-360             deg -0 rotate(deg)
                new Tuple<string, int>(Effects()[1], 1),    // +-360             deg -1 ms-ms-filter:x(deg)
                new Tuple<string, int>(Effects()[2], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>(Effects()[3], 3),    // + 1000             px -3 ms-ms-filter:x(px)
                new Tuple<string, int>(Effects()[4], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>(Effects()[5], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>(Effects()[6], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>(Effects()[7], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>(Effects()[8], 4),    // + 100                 -4 ms-ms-filter:x()
                new Tuple<string, int>(Effects()[9], 2),    // + 100               % -2 ms-ms-filter:x(%) 
                new Tuple<string, int>(Effects()[0], 0),    // +-360             deg -0 rotate(deg)
            };
            else
                return new List<Tuple<string, int>>
            {
                new Tuple<string, int>(Effects()[0], 0),              // +-360             deg -0 rotate(deg)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[1], 1),    // +-360             deg -1 ms-ms-filter:x(deg)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[2], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[3], 3),    // + 1000             px -3 ms-ms-filter:x(px)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[4], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[5], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[6], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[7], 2),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, int>("ms-ms-filter:"+Effects()[8], 4),    // + 100                 -4 ms-ms-filter:x()
                new Tuple<string, int>("ms-ms-filter:"+Effects()[9], 2),    // + 100               % -2 ms-ms-filter:x(%) 
            };
        }
        public static List<Tuple<string, string>> Eff_Prefix()
        {
            return new List<Tuple<string, string>>
            {
                new Tuple<string, string>(Effects()[0], " "),              // +-360             deg -0 rotate(deg)
                new Tuple<string, string>(Effects()[1], "ms-ms-filter:"),    // +-360             deg -1 ms-ms-filter:x(deg)
                new Tuple<string, string>(Effects()[2], "ms-ms-filter:"),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, string>(Effects()[3], "ms-ms-filter:"),    // + 1000             px -3 ms-ms-filter:x(px)
                new Tuple<string, string>(Effects()[4], "ms-ms-filter:"),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, string>(Effects()[5], "ms-ms-filter:"),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, string>(Effects()[6], "ms-ms-filter:"),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, string>(Effects()[7], "ms-ms-filter:"),    // + 100               % -2 ms-ms-filter:x(%)
                new Tuple<string, string>(Effects()[8], "ms-ms-filter:"),    // + 100                 -4 ms-ms-filter:x()
                new Tuple<string, string>(Effects()[9], "ms-ms-filter:"),    // + 100               % -2 ms-ms-filter:x(%) 
            };
        }
        public static string GetEffName(string EffCommand)
        {
            try
            {
                return EffCommand.Replace("ms-ms-filter:", null).Split('(')[0];
            }
            catch
            {
                return "error";
            }
        }
        #endregion*/
    }
}
