// 
// Copyright (c) 2004-2016 Jaroslaw Kowalski <jaak@jkowalski.net>, Kim Christensen, Julian Verdurmen
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// * Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer. 
// 
// * Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution. 
// 
// * Neither the name of Jaroslaw Kowalski nor the names of its 
//   contributors may be used to endorse or promote products derived from this
//   software without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF 
// THE POSSIBILITY OF SUCH DAMAGE.
// 

#if !SILVERLIGHT && !__IOS__ && !__ANDROID__

using System;
using System.Globalization;
using Xunit.Extensions;

namespace NLog.UnitTests.LayoutRenderers
{
    using NLog.Internal;
    using NLog.Layouts;
    using System.Diagnostics;
    using System.Linq;
    using Xunit;

    public class PerformanceCounterLayoutRendererTests : NLogTestBase
    {

        [Theory]
        //[InlineData("Process", "Working Set - Private", ".")]
        [InlineData("Processor", "% Processor Time", "")]
        public void RenderPerformanceCounter(string categoryName, string counterName, string machine)
        {
            var processorCategory = PerformanceCounterCategory.GetCategories().FirstOrDefault(cat => cat.CategoryName == "Processor");
            var countersInCategory = processorCategory.GetCounters("_Total");

            LogManager.ThrowExceptions = true;
            var processname = ThreadIDHelper.Instance.CurrentProcessBaseName;
            var layoutRaw = string.Format("${{performancecounter:Category={0}:Counter={1}:Instance=_Global }}", categoryName, counterName);
            Layout layout = layoutRaw;

            var logEventInfo = LogEventInfo.Create(LogLevel.Debug, "RenderTicksLayoutRenderer", "test message");
            string actual = layout.Render(logEventInfo);
            layout.Close();


            Assert.NotNull(actual);
            Assert.True(actual.Length > 0);
        }



    }
}
#endif