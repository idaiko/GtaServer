using RAGE;

namespace Client.PlayerChat
{
    public class PlayerChatLogger : Events.Script
    {
        public PlayerChatLogger()
        {
            Events.OnPlayerChat += OnPlayerChatLogger;
            Events.Add("ServerGlobalMessage", OnGlobalMessage);
        }

        private void OnGlobalMessage(object[] args)
        {
            var message = args[0].ToString();
            Chat.Output(message);
        }

        private void OnPlayerChatLogger(string text, Events.CancelEventArgs cancel)
        {
            Events.CallRemote("ClinetMessagesLog", text);
        }
    }
}
