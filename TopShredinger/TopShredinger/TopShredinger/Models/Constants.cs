using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TopShredinger.Models
{
    public class Constants
    {
        public static bool Isdev = true;

        public static Color BackgroundColor = Color.FromRgb(50, 153, 215);
        public static Color MainTextColor = Color.White;

        public static double LoginIconHeight = 120;

        /// <summary>
        /// Login
        /// </summary>
        public static string LoginUrl = "https://test.com/api/Auth/Login";

        public static string NoInternetText = "No internet, please reconnect.";
    }
}
