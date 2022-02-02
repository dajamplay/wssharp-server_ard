using System.Collections.Generic;
using System.Speech.Synthesis;

namespace WebSocketsWindowsForm
{
    public static class Voicer
    {
        private static Dictionary<string, string> _phrases = new Dictionary<string, string>();
        private static SpeechSynthesizer _voice = new SpeechSynthesizer();
        public static void Say(string text)
        {       
            _voice.SpeakAsync(text);
        }
        public static void SayByKey(string key)
        {   
            _voice.SpeakAsync(_phrases[key]);
        }
        public static void Init()
        {
            _voice.SelectVoice("IVONA 2 Maxim OEM");
            InitPhrases();
        }
        private static void AddPhrase(string key, string value)
        {
            _phrases.Add(key.ToLower(), value);
        }
        private static void InitPhrases()
        {
            AddPhrase("start", "Привет кожаным!");
            AddPhrase("wsOnClose", "Кожаный отключился!");
            AddPhrase("wsOnOpen", "Кожаный подключился!");
        }
    }
}
