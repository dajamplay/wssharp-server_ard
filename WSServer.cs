using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocketsWindowsForm
{
    class WSServer
    {
        private WebSocketServer _ws;

        private readonly string _serverConfig;

        private readonly MainForm _mainForm;

        public WSServer(string config, MainForm form)
        {
            _serverConfig = config;
            _mainForm = form;
            _ws = new WebSocketServer(_serverConfig);
            _ws.AddWebSocketService("/ws", () => new WSHandlers(_mainForm));
        }

        public void Start()
        {
            _ws = new WebSocketServer(_serverConfig);
            _ws.AddWebSocketService("/ws", () => new WSHandlers(_mainForm));
            _ws.Start();
            Voicer.SayFromResources("ServerStart");
        }

        public void Stop()
        {
            _ws.Stop(1000, "Server has been stopped...");
            Voicer.SayFromResources("ServerStop");
        }

        public string GetStatus()
        {
            return _ws.IsListening ? "Работает" : "Остановлен";
        }
    }
}
