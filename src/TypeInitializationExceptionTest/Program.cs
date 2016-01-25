using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Common;

namespace TypeInitializationExceptionTest
{
    class Program
    {
        //this throws a NLogConfigurationException because of bad config. (like invalid XML)
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key");
            Console.ReadLine();


        }
    }
}
