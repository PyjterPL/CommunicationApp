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
        public static void WriteLog(string log,bool simulation)
        {
            short iterator = 1;
            string name;
            if (simulation)
            {
                name = "SimulationLog"+iterator.ToString();
            }
            else
            {
                name = "ChaarrLog"+iterator.ToString();
            }
            while (File.Exists(name+".txt"))
            {
                name=name.Trim('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
                iterator++;
                name += iterator.ToString();
            }
            var fileStream = new FileStream(name+".txt",
                FileMode.CreateNew, FileAccess.ReadWrite);
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
