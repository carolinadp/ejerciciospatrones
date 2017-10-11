using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logs
{
    public class Logger
    {
        private static Logger instance = null;
        public static Logger Instance {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
            private set
            {

            }
        }

        /// <summary>
        /// Logs an error or message
        /// </summary>
        /// <param name="level">The log level we want to use.</param>
        /// <param name="message">The message to log.</param>

        public void Log(LogLevel level, string message)
        {
            FileStream stream = null;
            TextReader reader = null;
            TextWriter writer = null;
            try
            {
                stream = File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "log.txt");
                //reader = new StreamReader(stream);
                //reader.ReadToEnd();
                //string logs = reader.ReadToEnd();
                writer = new StreamWriter(stream);
                writer.Write(message);
                writer.Flush();
            }

            catch (Exception ex)
            {

            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (writer != null)
                {
                    writer.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            
        }
    }
}
