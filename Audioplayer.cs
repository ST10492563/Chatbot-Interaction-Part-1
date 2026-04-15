using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot_Interaction_Part_1
{
    internal class Audioplayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\VoiceApp1\\VoiceApp1\\WhatsApp Audio 2026-03-16 at 14.30.50.wav");
                player.PlaySync();

            }
            catch
            {
                Console.WriteLine("An error occured while playing the audio.");
            }
        }
    }
}
