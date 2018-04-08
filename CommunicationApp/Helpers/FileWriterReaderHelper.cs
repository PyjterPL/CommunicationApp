using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp.Helpers
{
    internal static class FileWriterReaderHelper
    {
        public static void WriteLog(string log)
        {
            var fileStream = new FileStream("Log.txt",
                FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                var streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(log);
                streamWriter.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
