using System.Collections.Generic;
using System.Speech.Synthesis;

namespace WebSocketsWindowsForm
{
    public static class Voicer
    {
        private static SpeechSynthesizer _voice = new SpeechSynthesizer();

        static Voicer()
        {
            _voice.SelectVoice("IVONA 2 Maxim OEM");
        }

        public static void Say(string text)
        {       
            _voice.SpeakAsync(text);
        }
    }
}
