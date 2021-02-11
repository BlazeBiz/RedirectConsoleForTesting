using System;

namespace RedirectConsoleForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            UIClass ui = new UIClass("Mike", Language.French);
            ui.GreetUser();
        }
    }
}
