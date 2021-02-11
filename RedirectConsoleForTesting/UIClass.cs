using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedirectConsoleForTesting
{
    public enum Language
    {
        English,
        Spanish,
        French
    }
    public class UIClass
    {
        public string UserName { get; set; }
        public Language Language { get; set; }

        public UIClass(string userName, Language language)
        {
            UserName = userName;
            Language = language;
        }

        public void GreetUser()
        {
            switch (Language)
            {
                case Language.English:
                    Console.WriteLine($"Hello, {UserName}");
                    break;
                case Language.Spanish:
                    Console.WriteLine($"Hola, {UserName}");
                    break;
                case Language.French:
                    Console.WriteLine($"Bonjour, {UserName}");
                    break;
            }
        }
    }
}
