using First;
using NUnit.Framework;

namespace TestLogAnalyzer
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            Assert.False(result);

        } 


        //ESTOS TEST SON REEMPLAZADOS POR EL ÚLTIMO

        //[Test]
        
        //public void IsValidLogFileName_GoodExtensionLowerCase_ReturnsTrue()
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();
        //    bool result = analyzer.IsValidLogFileName("filewithgoodExtension.slf");

        //    Assert.True(result);
        //}

        //[Test]

        //public void IsValidLogFileName_GoodExtensionUpperCase_ReturnsTrue()
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName("fileWithGoodExtension.SLF");

        //    Assert.True(result);
        //}

        [TestCase("filewithgoodextension.SLF")]
        [TestCase("fileWithGoodExtension.SLF")]
        [TestCase("filewithlowerGoodExtension.slf")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string fileName)
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(fileName);

            Assert.True(result);
        }

    }
}