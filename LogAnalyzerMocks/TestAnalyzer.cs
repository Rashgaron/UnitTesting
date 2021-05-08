using Mocks;
using NUnit.Framework;

namespace LogAnalyzerMocks
{
  
    [TestFixture]

    public class TestAnalyzer
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            FakeNewWebService mockService = new FakeNewWebService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            StringAssert.Contains("Filename too short:abc.ext", mockService.LastError);
        }

    }

    [TestFixture]
    public class TestAnalyzer2
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            FakeNewWebService mockService = new FakeNewWebService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            StringAssert.Contains("Filename too short:abc.ext", mockService.LastError);
        }
    }


}