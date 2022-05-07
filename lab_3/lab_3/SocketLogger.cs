using System.Text;

namespace lab_3
{
    public class SocketLogger: ILogger
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);

        }

        ~SocketLogger()
        {
            Dispose();
        }

        public void Log(params string[] messages)
        {
            foreach (string message in messages)
            {
                clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }
        }

        public void Dispose()
        {
            clientSocket.Dispose();
        }
    }
}
