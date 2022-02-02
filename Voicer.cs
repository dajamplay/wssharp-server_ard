using System.Collections.Generic;
using System.Speech.Synthesis;

namespace WebSocketsWindowsForm
{
    public static class Voicer
    {
        private static readonly SpeechSynthesizer _voice = new SpeechSynthesizer();

        static Voicer()
        {
            _voice.SelectVoice("IVONA 2 Maxim OEM");
        }

        public static void Say(string text)
        {
            _voice.SpeakAsync(text);
        }

  
        public static void SayFromResources(string key)
        {
            _voice.SpeakAsync(Lang.GetString(key));
        }
    }
}
