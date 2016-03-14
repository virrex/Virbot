using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virbot
{
    class Program
    {
       public static DiscordClient bot;
        static void Main(string[] args)
        {
            bot = new DiscordClient();
            
            bot.MessageReceived += Bot_MessageReceived;
            bot.Connect("virbot123@gmail.com", "Kappa123");
            StartUpInfo();
            bot.Wait();
        }

        private static void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) { return; }
            if (e.Message.Text.ToLower().Contains("!help"))
            {
                e.Message.Channel.SendMessage
                    (
                    e.User.Mention + " Needs backup, let's help! \n !commands : Shows you a list of all commands \n !bdo : Shows you all the commands for Black Desert Online" 
                    );
            }
            if(e.Message.Text.ToLower().Contains("!gif"))
            {
                e.Channel.SendFile("images/giphy.gif");
                Console.WriteLine("Gif sent");
            }
            if (e.Message.Text.ToLower() == "!addgif")
            {

            }
            if (e.Message.Text.ToLower().Contains("!wiki"))
            {
                e.Channel.SendMessage(e.User.Mention + " http://www.blackdeserttome.com/wiki/BDO_Tome");
            }
        }
        private static void StartUpInfo()
        {
            Console.WriteLine("This is a discord black desert online bot");
            Console.WriteLine();
            Console.WriteLine("Currently active in servers: ");
            foreach (var server in bot.Servers)
            {
                Console.WriteLine("- " + server.Name);
            }

        }
    }
}
