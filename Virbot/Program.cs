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
        static void Main(string[] args)
        {
            DiscordClient bot = new DiscordClient();
            bot.MessageReceived += Bot_MessageReceived;
            bot.Connect("virbot123@gmail.com", "Kappa123");
            bot.Wait();
        }

        private static void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) { return; }
            if(e.Message.Text == "!help")
            {
                e.Message.Channel.SendMessage
                    (
                    e.User.Mention + " Needs backup, let's help! \n !commands : Shows you a list of all commands \n !bdo : Shows you all the commands for Black Desert Online" 
                    );


            }

        }
    }
}
