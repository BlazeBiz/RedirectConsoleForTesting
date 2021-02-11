using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace RedirectConsoleForTesting.Tests
{
    [TestClass]
    public class UIClassTests
    {
        [DataTestMethod]
        [DataRow("Bill", Language.English, "Hello, Bill")]
        [DataRow("Miguel", Language.Spanish, "Hola, Miguel")]
        [DataRow("Pierre", Language.French, "Bonjour, Pierre")]
        public void TestGreeting(string name, Language language, string expectedResult)
        {
            // Arrange - Setup variables and create an instance of the class under test
            string consoleOutput;
            UIClass ui = new UIClass(name, language);

            // Act - call the method under test and save the results
            using (StringWriter sw = new StringWriter())
            {
                // Capture the original console output...can we still write to it if we want to?
                TextWriter originalConsole = Console.Out;

                // redirect the consoleoutput to our StringWriter so we can capture it
                Console.SetOut(sw);

                // Write to the original console and see if it shows in the Test Output panel
                originalConsole.WriteLine("*** Console Out has been re-directed to a string ***");

                // Call method(s) that write to the console.
                ui.GreetUser();

                // Done calling methods...capture the output into a string
                consoleOutput = sw.ToString();
            }
            string expected = expectedResult + Environment.NewLine;
            Assert.AreEqual<string>(expected, consoleOutput);
        }
    }
}
