using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NLog.UnitTests
{
    public class GetLoggerExtTest
    {

        [Fact]
        public void GetCurrentClassLoggerExtTest()
        {
            var logger = this.GetCurrentClassLogger();
            Assert.NotNull(logger);
            Assert.Equal("NLog.UnitTests.GetLoggerExtTest", logger.Name);
        }

        //TODO type arg of LogManager.GetCurrentClassLogger is used for different purposes
        //TODO other usage would be nice. But we can't use 'this' is static context.
        readonly ILogger _logger = GetLoggerExt.GetCurrentClassLogger<GetLoggerExtTest>();

        [Fact]
        public void GetCurrentClassLoggerExtStaticTest()
        {

            Assert.NotNull(_logger);
            Assert.Equal("NLog.UnitTests.GetLoggerExtTest", _logger.Name);
        }
    }
}
