using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virbot
{
    static class Users
    {
        public static void Bot_NewUser(object sender, UserEventArgs e)
        {
            e.Server.DefaultChannel.SendMessage(e.User.Mention + " Welcome to our community! \n Type " + " !help " + " to get help from Virbot Bestbot ");
        }

    }
}
