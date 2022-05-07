using System;
using System.IO;
using System.Text;

namespace lab_3
{
    public class FileLogger : WriterLogger
    {

        private bool disposed;

        protected FileStream stream;

        public FileLogger(string path)
        {
            stream = new FileStream(path, FileMode.Append);

            writer = new StreamWriter(stream, Encoding.UTF8);
        }

        ~FileLogger()
        {
            Dispose();
        }

        public new void Dispose()
        {
            base.Dispose();
            stream.Dispose();
            disposed = true;
        }
    }
}
