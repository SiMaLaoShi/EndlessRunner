﻿using UniFramework.Event;

public class SceneEventDefine
{
    public class ChangeToHomeScene : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new ChangeToHomeScene();
            UniEvent.SendMessage(msg);
        }
    }

    public class ChangeToBattleScene : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new ChangeToBattleScene();
            UniEvent.SendMessage(msg);
        }
    }
    
    public class ChangeToMainScene : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new ChangeToMainScene();
            UniEvent.SendMessage(msg);
        }
    }
    
    public class ChangeToStartScene : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new ChangeToStartScene();
            UniEvent.SendMessage(msg);
        }
    }
}