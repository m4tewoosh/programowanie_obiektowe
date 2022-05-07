using System;
using System.Net;
using System.Net.Sockets;

public class ClientSocket : IDisposable
{
    private bool disposed;

    private Socket socket;

    public ClientSocket(string host, int port)
    {
        IPHostEntry entry = Dns.GetHostEntry(host);

        socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

        try
        {
            socket.Connect(entry.AddressList, port);
        }
        catch (SocketException ex)
        {
            socket.Dispose();

            throw ex;
        }
    }

    ~ClientSocket()
    {
        Dispose(false);
    }

    public int Send(byte[] buffer)
    {
        return socket.Send(buffer, SocketFlags.None);
    }

    public int Send(byte[] buffer, int offset, int size)
    {
        return socket.Send(buffer, offset, size, SocketFlags.None);
    }

    public int Receive(byte[] buffer)
    {
        return socket.Receive(buffer, SocketFlags.None);
    }

    public int Receive(byte[] buffer, int offset, int size)
    {
        return socket.Receive(buffer, offset, size, SocketFlags.None);
    }

    public void Close()
    {
        socket.Shutdown(SocketShutdown.Both);
        socket.Close();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
                socket.Dispose();

            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(disposing: true);

        GC.SuppressFinalize(this);
    }
}