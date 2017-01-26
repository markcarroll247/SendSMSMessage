using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace CA1SendSMSMessage.Models
{
    public static class Logging
    {
        public static void writeToDeugger(string AreaCode, string PhoneNumber, string TextContent)
        {
            Debug.WriteLine("Message sent to " + AreaCode + PhoneNumber + " with the message: " + TextContent);

        }
    }
}