using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import static members Console and DateTime classes =>
//We can use static members without classname.
//DateTime.Now.ToShortTimeString() => Now.ToShortTimeString()
using static System.Console;
using static System.DateTime;


namespace SimpleUtilityClass
{
    static class TimeUtilClass
    {
        public static void PrintTime()
        {
            WriteLine(Now.ToShortTimeString());
        }

        public static void PrintDate() => WriteLine(Now.ToShortDateString());
    }
}
