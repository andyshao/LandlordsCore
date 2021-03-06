﻿using Model;

namespace Hotfix
{
    [MessageHandler(AppType.Realm)]
    public class PlayerDisconnectHandler : AMHandler<PlayerDisconnect>
    {
        protected override void Run(Session session, PlayerDisconnect message)
        {
            //玩家断开移除在线标记
            Game.Scene.GetComponent<PlayerLoginManagerComponent>().Remove(message.UserID);
            Log.Info($"玩家{ message.UserID}下线");
        }
    }
}
