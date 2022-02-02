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
            Voicer.SayFromResources("UserConnect");
            //mainform.getTextBox().Invoke(new Action(() => mainform.getTextBox().Text = socketContext.Sessions.Count.ToString()));

            //foreach (var id in socketContext.Sessions.IDs)
            //{
            //    socketContext.Sessions.SendTo(ID, id);
            //    socketContext.Context.Sess
            //}
        }
    }
}
