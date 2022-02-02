using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocketsWindowsForm
{
    class WSHandlers : WebSocketBehavior
    {
        private readonly MainForm _mainForm;
        public WSHandlers(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        protected override void OnOpen()
        {
            new WSOnOpenController(_mainForm, this);
        }

        protected override void OnMessage(MessageEventArgs messageEvent)
        {
            new WSOnMessageController(_mainForm, messageEvent, this);        
        }

        protected override void OnClose(CloseEventArgs closeEvent)
        {
            new WSOnCloseController(_mainForm, closeEvent);
        }
    }
}
