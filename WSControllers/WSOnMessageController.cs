using System;
using WebSocketSharp.Net.WebSockets;
using WebSocketSharp;

namespace WebSocketsWindowsForm
{
    internal class WSOnMessageController
    {
        public WSOnMessageController(MainForm mainform, MessageEventArgs message, WSHandlers socketContext)
        {
            if (message.Data.Length > 0) 
            {
                string[] commands = message.Data.Split('?');
                if (commands[0] == "youtube")
                {
                    Voicer.SayFromResources("YouTubeOpen");
                    mainform.getTextBox().Invoke(new Action(() => mainform.getTextBox().Text = commands[1]));
                }
                else
                {
                    Voicer.SayFromResources("ErrorCommand");
                }
            }
        }
    }
}
