using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using NLog;

namespace ConcurrentFileTargetTest
{
    internal class Program
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            string processName;
            if (args.Length == 0)
            {
                processName = "0";
                for (int i = 1; i < 5; ++i)
                {
                    Process.Start(Assembly.GetEntryAssembly().Location, i.ToString());
                }
            }
            else
            {
                processName = args[0];
            }

            bool running = true;
            Console.CancelKeyPress += (sender, eventArgs) => running = false; // shutdown on Control-C
            while (running)
            {
                Logger.Debug("{0} - Happily Running Still", processName);
                Thread.Sleep(1000);
            }
        }
    }
}