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
            
            _mainForm.getTextBox().Invoke(new Action(() => _mainForm.getTextBox().Text = Sessions.Count.ToString()));
            Voicer.Say("Подключился новый пользователь!");

            foreach(var id in Sessions.IDs)
            {
                Sessions.SendTo(ID, id);
            }
        }

        protected override void OnMessage(MessageEventArgs message)
        {
            new WSOnMessageController(_mainForm, message, this);        
        }

        protected override void OnClose(CloseEventArgs e)
        {
            _mainForm.getTextBox().Invoke(new Action(() => _mainForm.getTextBox().Text = Sessions.Count.ToString()));
        }
    }
}
