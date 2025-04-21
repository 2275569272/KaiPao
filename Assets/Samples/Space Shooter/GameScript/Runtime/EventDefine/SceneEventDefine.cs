using UniFramework.Event;

public class SceneEventDefine
{
    public class StartingScene : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new StartingScene();
            UniEvent.SendMessage(msg);
        }
    }

    public class Battle : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new Battle();
            UniEvent.SendMessage(msg);
        }
    }

    public class BattleScene : IEventMessage
    {
        public static void SendEventMessage()
        {
            var msg = new BattleScene();
            UniEvent.SendMessage(msg);
        }
    }
}