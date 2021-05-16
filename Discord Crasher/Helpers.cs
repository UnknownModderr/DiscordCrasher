using System;
using System.Drawing;
using Console = Colorful.Console;
using System.Collections.Generic;

namespace DiscordCrasher
{
    class Helpers
    {
        public static void writePrefixText(string prefix, string text, bool newLine)
        {
            string prefix_ = "";
            Color color = Color.White;

            switch (prefix)
            {
                case "inf":
                    color = Color.Cyan;
                    prefix_ = "[INF] ";
                    break;

                case "err":
                    color = Color.Red;
                    prefix_ = "[ERR] ";
                    break;

                case "win":
                    color = Color.LightGreen;
                    prefix_ = "[WIN] ";
                    break;

                case "dbg":
                    color = Color.Orange;
                    prefix_ = "[DBG] ";
                    break;

                case "non":
                    color = Color.White;
                    prefix_ = "";
                    break;
            }

            Console.Write(prefix_, color);
            if (newLine)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }
        }

        public static void printLogo()
        {
            Console.ForegroundColor = Color.FromArgb(140, 140, 228);

            foreach (string text in new List<string>  
            {
@"   ___  _                     __  _____             __          ",
@"  / _ \(_)__ _______  _______/ / / ___/______ ____ / /  ___ ____",
@" / // / (_-</ __/ _ \/ __/ _  / / /__/ __/ _ `(_-</ _ \/ -_) __/",
@"/____/_/___/\__/\___/_/  \_,_/  \___/_/  \_,_/___/_//_/\__/_/   ",
@"",
@"+----------------+",
@"| Version: 1.0.0 |",
@"+----------------+",
                "\n",
                "\n"
            })
            {
                Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text.Length / 2) + "}", text));
            }

            Console.ForegroundColor = Color.White;
        }
    }
}
