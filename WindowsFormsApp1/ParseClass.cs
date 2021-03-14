using System;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    class ParseClass
    {
        public static bool parsing(String str)
        {
            Regex regex = new Regex("[a-zA-Zа-яА-Я0-9_]");
            Match matcher = regex.Match(str);
            return matcher.Success;
        }
    }
}
