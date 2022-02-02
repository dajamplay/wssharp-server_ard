using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;

namespace WebSocketsWindowsForm
{
    internal class WSOnOpenController
    {
        public WSOnOpenController(MainForm mainform, WSHandlers socketContext)
        {
            Voicer.SayByKey("wsOnOpen");
            //mainform.getTextBox().Invoke(new Action(() => mainform.getTextBox().Text = socketContext.Sessions.Count.ToString()));
            //Voicer.Say("Подключился новый пользователь!");

            //foreach (var id in socketContext.Sessions.IDs)
            //{
            //    socketContext.Sessions.SendTo(ID, id);
            //    socketContext.Context.Sess
            //}
        }
    }
}
