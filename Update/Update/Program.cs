﻿using System.Diagnostics;
using System.IO;
using System.Net.Mime;

namespace Update
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           KillTask();
           DelOldVersion();
           MakeNewVersion();
           StartNewVer();
        }

        public static void KillTask()
        {
            Process [] proc = Process.GetProcessesByName("ModPackInstaller");
            proc[0].Kill();
        }

        public static void DelOldVersion()
        {
            File.Delete(@"ModPackInstaller.exe");
        }

        public static void MakeNewVersion()
        {
            File.Move(@"ModPackInstaller1.exe", @"ModpackInstaller.exe");
        }

        public static void StartNewVer()
        {
            Process.Start("ModPackInstaller.exe");
            
        }
    }
}