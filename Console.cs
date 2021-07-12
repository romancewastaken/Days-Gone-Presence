using System;
using System.Diagnostics;
using DaysGoneRPC.Handler; 

namespace DaysGoneRPC
{
    public static class Console
    {
        public static void Main(string[] args)
        {
            StartUp();
        }

        public static void StartUp()
        {
            Discord.Start();
            System.Console.WriteLine("Days gone Rich Presence Version 1.0");
            System.Console.Title = "Days Gone Rich Presence";
            System.Console.WriteLine("");
            System.Console.WriteLine("[1] Settings");
            System.Console.WriteLine("[2] Exit");
            string option = System.Console.ReadLine();
            if (option == "1")
            {
                System.Console.WriteLine("Settings is not finished");
                System.Console.WriteLine("[1] Exit");
                System.Console.ReadLine();
                string option2 = System.Console.ReadLine();
                if (option2 == "1")
                {
                    Environment.Exit(0);
                }
            }
            if (option == "2")
            {
                Discord.ShutDown();
                Environment.Exit(0);
            }
        }
    }
}
