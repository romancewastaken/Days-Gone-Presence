using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace DaysGoneRPC.Handler
{
    public static class Discord
    {
        public static DiscordRpcClient client;

        public static void Start()
        {
            client = new DiscordRpcClient("863866927013298187");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"Days Gone",
                State = $"Exploring Oregon", 
                Assets = new Assets()
                {
                    LargeImageKey = "days_gone",
                    LargeImageText = "Days Gone",
                }
            });
        }

        public static void ShutDown()
        {
            client.Dispose();
        }
    }
}
