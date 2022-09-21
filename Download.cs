using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project_Scorpion
{
    internal class Download
    {
        public static void Loadcheat()
        {
            WebClient webClient = new WebClient();
            string text = @"C:\\Windows\\IME\\example.exe"; //put your filename here 
            webClient.DownloadFile("", text);//Discord download link here
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Thread.Sleep(1000);
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = @"C:\\Windows\\IME\\example.exe"; //put your filename here 
            myProcess.Start();




        }
        public static void loadclean()
        {
            WebClient webClient = new WebClient();
            string text = @"C:\\Windows\\IME\\example.exe"; //put your filename here 
            webClient.DownloadFile("", text);//Discord download link here
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Thread.Sleep(1000);
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = @"C:\\Windows\\IME\\example.exe"; //put your filename here 
            myProcess.Start();
            /// this is a shit way to download and run files btw 
            /// its good to learn from




        }
    }
}
