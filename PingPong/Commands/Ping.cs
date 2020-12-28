using CommandSystem;
using System;

namespace PingPong.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Ping : ICommand
    {
        public string Command { get; } = "PING";

        public string[] Aliases { get; } = new string[] { "ping" };

        public string Description { get; } = "A simple test command.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "PONG";

            return true;
        }
    }
}