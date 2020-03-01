using GTANetworkAPI;
using Server.Messages;

namespace Server.Logger
{
    public class ClientLogger : Script
    {
        [RemoteEvent("ClinetMessagesLog")]
        public void ClientChatLog(Client player, string message)
        {
            NAPI.Util.ConsoleOutput(string.Format(ConsoleMessages.PlayerChatLog, player.Name, message));
        }
    }
}
