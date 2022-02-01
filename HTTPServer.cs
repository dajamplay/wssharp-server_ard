using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace WebSocketsWindowsForm
{
    internal class HTTPServer
    {
        public HTTPServer()
        {
            //Серверный сокет для перехвата подключений
            TcpListener serverSocket = new TcpListener(IPAddress.Any, 5070);
            
            //Сокет клиента
            TcpClient clientSocket = serverSocket.AcceptTcpClient();
        }
    }
}
