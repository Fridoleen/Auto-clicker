using System;
using System.IO;

namespace Auto_clicker
{
    class EventLog
    {
        private const string writePath = @"EventLog_Autoclicker.txt";

        EventLog()
        {          
            using (StreamWriter sw = new StreamWriter(writePath, false))
            {
                sw.WriteLine(DateTime.Now + ": New log file created");
            }
        }

        public static void RecordMessage(string message)
        {
            using (StreamWriter sw = new StreamWriter(writePath, true))
            {
                sw.WriteLine(DateTime.Now + ": " + message);
            }

        }

        public static void ClearLog()
        {
            using (StreamWriter sw = new StreamWriter(writePath, false))
            {
                sw.WriteLine(DateTime.Now + ": Log cleared");
            }
        }

        public static void ShowMessage(string message)
        {

        }

    }
}
