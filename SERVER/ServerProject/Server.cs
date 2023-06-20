using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerProject
{
    internal class Server
    {
        public static int MaxClients { get; private set; }
        public static int Port { get; private set; }

        private static TcpListener? tcpListener;
        
        public static void Start(int _maxClients, int _port)
        {
            MaxClients = _maxClients;
            Port = _port;

            Console.WriteLine("Starting Server...");


            tcpListener = new TcpListener(IPAddress.Any, Port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(TcpConnectCallback), null);

            Console.WriteLine($"Server started on {Port}.");
        }

        public static void TcpConnectCallback(IAsyncResult _result)
        {
            TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(TcpConnectCallback), null);
        }
    }
}
