using System;
using System.Collections.Generic;
using System.Text;

namespace Mocks
{
    public class LogAnalyzer
    {
        private IWebService service;

        public LogAnalyzer(IWebService service)
        {
            this.service = service;
        }

        public void Analyze(string fileName)
        {
            if(fileName.Length < 8)
            {
                service.LogError("Filename too short:" + fileName);
            }
        }
    }
}
