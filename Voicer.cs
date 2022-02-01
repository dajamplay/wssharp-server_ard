using System.Speech.Synthesis;

namespace WebSocketsWindowsForm
{
    public static class Voicer
    {
        public static void Say(string text)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();    
            voice.SpeakAsync(text);
        }
    }
}
