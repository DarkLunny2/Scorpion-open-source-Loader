using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Globalization;
using System.Security.Cryptography;
using project_Scorpion;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var hwid = GetHWID();
            CheckHWID(hwid);

        }

        private static string GetHWID() 
        {
            string location = @"SOFTWARE\Microsoft\Cryptography"; string name = "MachineGuid";

            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null) throw new KeyNotFoundException(string.Format(location));
                    object HWID = rk.GetValue(name);
                    if (HWID == null) throw new IndexOutOfRangeException(string.Format(name));
                    return HWID.ToString();
                }
            }
        }

        static async void CheckHWID(string hwid)
        {
           
            var client = new HttpClient();
            var database = await client.GetAsync("https://pastebin.com/raw/LJMwMgQ7").Result.Content.ReadAsStringAsync();
            if (database.Contains(hwid))
            {
                Console.Title = "Scorpion Open source loader";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("HWID Authorized!");
                Console.Write("\nPress enter");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();
        
                Menu();
            }
            else
            {
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("+");
                Console.ResetColor();
                Console.Write("HWID Unauthorized\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ResetColor();
                Console.Write("HWID: " + hwid + "\n");
                Console.ReadLine();
                Environment.Exit(0);
            }
      
       }
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Write("[1] Load cheat\n");
            Console.Write("[2] Load Cleaner");
            Console.Write("\n>");
            //H4Z3B4 was here
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    Download.Loadcheat();

                    break;

                case "2":
                    Console.Clear();
                    Download.loadclean();

                    break;

               
                    break;


            }
        }











    }
}
