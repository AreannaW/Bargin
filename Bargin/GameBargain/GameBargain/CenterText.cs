using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GameBargain
{
    public static class CenterText
    {
        static CenterText() { }

        public static void CT(string textToEnter)
        {
            //string textToEnter = "You are alone on a ship...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
        }
    }
}
