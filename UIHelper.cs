using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chatbot_Interaction_Part_1
{
    internal class UIHelper
    {
        public static void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== CYBERSECURITY BOT ===");
            Console.ResetColor();
        }

        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}
