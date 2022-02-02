using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace WebSocketsWindowsForm
{
    internal class WSOnCloseController
    {
        public WSOnCloseController(MainForm mainform, CloseEventArgs closeEvent)
        {
            Voicer.Say("Кожаный отключился!");
            //_mainForm.getTextBox().Invoke(new Action(() => _mainForm.getTextBox().Text = Sessions.Count.ToString()));
        }
    }
}
