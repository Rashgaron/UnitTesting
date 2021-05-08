using First;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTest
{
    [TestFixture]
    public class LogAnTest
    {
        [Test]
        public void IsValidFieldName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            Assert.False(result);

        }
    }
}
