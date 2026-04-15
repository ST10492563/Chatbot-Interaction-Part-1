using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Chatbot_Interaction_Part_1
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            PlayVoiceGreeting();
            DisplayAsciiArt();

            string userName = GetUserName();

            ShowWelcomeMessage(userName);

            StartChat(userName);
        }

        // 🎤 1. Voice Greeting
        static void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\VoiceApp1\\VoiceApp1\\WhatsApp Audio 2026-03-16 at 14.30.50.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine(" An error occured while playing the audio.");
            }
        }

        // 🖼 2. ASCII Art
        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝ ╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║       ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║        ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗    ██║   ██████╔╝███████╗██║  ██║
   ╚═════╝    ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝
     CYBERSECURITY AWARENESS BOT
");

            Console.ResetColor();
        }

        // 👤 3. Get User Name
        static string GetUserName()
        {
            string name;

            do
            {
                Console.Write("\nEnter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name cannot be empty. Try again.");
                    Console.ResetColor();
                }

            } while (string.IsNullOrWhiteSpace(name));

            return name;
        }

        // 💬 Welcome Message
        static void ShowWelcomeMessage(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            TypeText($"\nHello {name}! 👋");
            TypeText("Welcome to the Cybersecurity Awareness Bot.");
            TypeText("Ask me about password safety, phishing, or safe browsing.\n");

            Console.ResetColor();
        }

        // ⌨ Typing Effect
        static void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        // 🤖 4. Chat System
        static void StartChat(string name)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    HandleInvalidInput();
                    continue;
                }

                if (input.Contains("exit"))
                {
                    Console.WriteLine("Goodbye! Stay safe online 👋");
                    break;
                }

                RespondToUser(input);
            }
        }

        // 💡 5. Responses
        static void RespondToUser(string input)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Bot: ");

            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm just code, but I'm here to help you stay safe! 😊");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to educate you about cybersecurity best practices.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask about passwords, phishing, and safe browsing.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with a mix of letters, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Be cautious of suspicious emails and never click unknown links.");
            }
            else if (input.Contains("browsing"))
            {
                Console.WriteLine("Always use secure websites (https) and avoid public Wi-Fi for sensitive tasks.");
            }
            else
            {
                HandleInvalidInput();
            }

            Console.ResetColor();
        }

        // ⚠ 6. Input Validation Response
        static void HandleInvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
            Console.ResetColor();
        }
    }
}
