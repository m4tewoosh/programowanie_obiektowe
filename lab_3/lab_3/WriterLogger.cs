using System;
using System.IO;

namespace lab_3
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public void Log(params string[] messages) { 
            DateTime time = DateTime.Now;
            time.ToString("yyyy-MM-ddTHH:mm:sszzz");
            writer.Write(time);
            writer.Write(" ");

            foreach (string message in messages)
            {
                writer.Write(message);
                writer.Write(" ");
            }

            writer.WriteLine();
        }

        public void Dispose()
        {
            writer.Dispose();
        }
    }
}
