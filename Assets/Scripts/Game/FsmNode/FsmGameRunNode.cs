using UniFramework.Machine;
using UnityEngine;
using YooAsset;

namespace Game.FsmNode
{
    public class FsmGameRunNode : IStateNode
    {
        public void OnCreate(StateMachine machine)
        {
            
        }

        private GameState state;
        public void OnEnter()
        {
            var handle = YooAssets.LoadAssetAsync<GameObject>("Assets/Prefabs/UI/UIGameWindow.prefab");
            handle.Completed += assetHandle =>
            {
                var uiRoot = GameObject.Find("/UICamera");
                var gameObject = assetHandle.InstantiateSync(uiRoot.transform);
                state = gameObject.GetComponent<GameState>();
            };
        }

        public void OnUpdate()
        {
            
        }

        public void OnExit()
        {
            
        }
    }
}