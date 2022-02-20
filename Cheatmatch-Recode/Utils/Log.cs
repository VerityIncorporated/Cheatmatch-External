using System;
using System.Drawing;
using static Colorful.Console;

namespace Cheatmatch_Recode.Utils
{
    internal static class Log
    {
        public static void SendLog(string text, Color color)
        {
            WriteLine(" [Cheatmatch] @ " + DateTime.Now + ": " + text, color);
        }
    }
}
