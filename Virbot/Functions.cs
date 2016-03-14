using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virbot
{
    class Functions
    {
        private string pw = "Kappa123";
        private string user = "virbot123@gmail.com";
        private string[] cmd = { "1", "2", "3" };
        DiscordClient bot;
        public void Setup()
        {
            try
            {
                bot = new DiscordClient();
                bot.MessageReceived += Bot_MessageReceived;
                bot.UserJoined += Bot_NewUser;
                bot.Connect(user, pw);
                bot.Wait();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) { return; }
            if (e.Message.Text.ToLower().Contains("!help"))
            {
                e.Message.Channel.SendMessage
                    (
                    e.User.Mention + " Needs backup, let's help! \n !commands : Shows you a list of all commands \n !bdo : Shows you all the commands for Black Desert Online"
                    );
            }
            if (e.Message.Text.ToLower().Contains("!gif"))
            {
                e.Channel.SendFile("images/giphy.gif");
            }
            if (e.Message.Text.ToLower() == "!commands")
            {
                foreach (var i in cmd)
                {
                    e.Channel.SendMessage(i);
                }
            }
            if (e.Message.Text.ToLower().Contains("!wiki"))
            {
                e.Channel.SendMessage(e.User.Mention + " http://www.blackdeserttome.com/wiki/BDO_Tome");
            }
            if (e.Message.Text.Contains("Viktor"))
            {
                e.Channel.SendMessage("Viktor is such a lovely person, all hail Viktor.");
            }

        }
        public void Bot_NewUser(object sender, UserEventArgs e)
        {
            e.Server.DefaultChannel.SendMessage(e.User.Mention + " Welcome to our community! \n Type " + " !help " + " to get help from Virbot Bestbot ");
        }
    }
}
