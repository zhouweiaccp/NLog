using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog.Config;
using NLog.UnitTests.Common;
using Xunit;

namespace NLog.UnitTests
{
    public class Logger2test : NLogTestBase
    {


        [Fact]
        public void TestLogger2GetCurrentClassLogger()
        {
            {

                var loggingConfiguration = new LoggingConfiguration();
               
                var lastLogEventListTarget = new LastLogEventListTarget() {Name = "t1"};
                loggingConfiguration.AddTarget(lastLogEventListTarget);
                loggingConfiguration.LoggingRules.Add(new LoggingRule("*", LogLevel.Trace, lastLogEventListTarget));
                LogManager.Configuration = loggingConfiguration;
            }

            //TODO won't work with var of "Logger" type :(
            ILogger2 logger = LogManager.GetCurrentClassLogger();

            logger.Trace("message");



            var target = LogManager.Configuration.FindTargetByName<LastLogEventListTarget>("t1");

            Assert.NotNull(target);
            Assert.NotNull(target.LastLogEvent);
            Assert.True(target.LastLogEvent.Properties.ContainsKey("memberName"));
            Assert.True(target.LastLogEvent.Properties.ContainsKey("sourceFilePath"));
            Assert.True(target.LastLogEvent.Properties.ContainsKey("sourceLineNumber"));
            Assert.NotNull(target.LastLogEvent.Properties["memberName"]);
            Assert.NotNull(target.LastLogEvent.Properties["sourceFilePath"]);
            Assert.NotNull(target.LastLogEvent.Properties["sourceLineNumber"]);
            Assert.NotNull(target.LastLogEvent.Properties["sourceLineNumber"] as int?);


            Assert.True(target.LastLogEvent.Properties["memberName"].Equals("TestLogger2GetCurrentClassLogger"));
            Assert.True(target.LastLogEvent.Properties["sourceFilePath"].ToString().EndsWith("Logger2test.cs"));
            Assert.True((target.LastLogEvent.Properties["sourceLineNumber"] as int? ?? -1) > 0);



        }
    }
}