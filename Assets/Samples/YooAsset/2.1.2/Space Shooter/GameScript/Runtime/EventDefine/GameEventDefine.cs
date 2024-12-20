using UniFramework.Event;

public class GameEventDefine
{
    public class GameIdleToRunEvent : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new GameIdleToRunEvent();
            UniEvent.SendMessage(msg);
        }
    }
    
    public class GameIdleToLoadingEvent : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new GameIdleToLoadingEvent();
            UniEvent.SendMessage(msg);
        }
    }
}