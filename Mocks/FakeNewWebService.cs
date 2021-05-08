using System;
using System.Collections.Generic;
using System.Text;

namespace Mocks
{
    public class FakeNewWebService : IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
        
    }
}
