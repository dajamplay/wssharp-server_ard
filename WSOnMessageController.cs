using System;
using WebSocketSharp.Net.WebSockets;
using WebSocketSharp;

namespace WebSocketsWindowsForm
{
    internal class WSOnMessageController
    {
        public WSOnMessageController(MainForm mainform, MessageEventArgs message, WSHandlers socketContext)
        {
            string[] commands = message.Data.Split(' ');
            if (commands[0] == "youtube") Voicer.Say("youtube");
            mainform.getTextBox().Invoke(new Action(() => mainform.getTextBox().Text = commands[1]));
        }
    }
}
