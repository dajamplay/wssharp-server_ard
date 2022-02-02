using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketsWindowsForm
{
    public static class Lang
    {
        private static readonly ResourceManager _resourceManager = new ResourceManager(
            "WebSocketsWindowsForm.Resourses.Strings",
             Assembly.GetExecutingAssembly());

        private static string _language = "ru-RU";

        static Lang()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
        }

        public static string GetString(string text)
        {
            return _resourceManager.GetString(text);
        }

        public static void SetLanguage(string language)
        {
            _language = language;
        }
    }
}
