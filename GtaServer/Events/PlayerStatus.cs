﻿using GTANetworkAPI;
using Server.Messages;

namespace Server.Events
{
    public class PlayerStatus : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Client player)
        {
            NAPI.Util.ConsoleOutput(string.Format(ConsoleMessages.PlayerConnected, player.Name));
            player.TriggerEvent("ServerGlobalMessage", $"Welcome {player.Name}");
        }

        [ServerEvent(Event.PlayerSpawn)]
        public void OnPlayerSpawn(Client player)
        {
            NAPI.Chat.SendChatMessageToAll("Check message");
            player.TriggerEvent("ServerGlobalMessage", $"Welcome {player.Name}");
        }
    }
}