using Game.FsmNode;
using UniFramework.Event;
using YooAsset;
using UniFramework.Machine;
namespace Game
{
    public class GameLogic : GameAsyncOperation
    {
        private readonly StateMachine machine;
        private readonly EventGroup eventGroup = new EventGroup();
        public GameLogic()
        {
            eventGroup.AddListener<GameEventDefine.GameIdleToRunEvent>(OnHandleEventMessage);
            eventGroup.AddListener<GameEventDefine.GameIdleToLoadingEvent>(OnHandleEventMessage);
            
            machine = new StateMachine(this);
            machine.AddNode<FsmGameIdleNode>();
            machine.AddNode<FsmGameLoadingNode>();
            machine.AddNode<FsmGameRunNode>();
            machine.AddNode<FsmGameOverNode>();
        }

        private void OnHandleEventMessage(IEventMessage obj)
        {
            switch (obj)
            {
                case GameEventDefine.GameIdleToRunEvent:
                    machine.ChangeState<FsmGameRunNode>();
                    break;
                case GameEventDefine.GameIdleToLoadingEvent:
                    machine.ChangeState<FsmGameLoadingNode>();
                    break;
            }
        }

        protected override void OnStart()
        {
            machine.Run<FsmGameIdleNode>();
        }

        protected override void OnUpdate()
        {
            machine.Update();
        }

        protected override void OnAbort()
        {
            
        }
    }
}