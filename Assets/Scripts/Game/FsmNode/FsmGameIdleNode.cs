using UniFramework.Machine;
using UnityEngine;
using YooAsset;
namespace Game.FsmNode
{
    public class FsmGameIdleNode : IStateNode
    {
        public void OnCreate(StateMachine machine)
        {
            
        }

        public void OnEnter()
        {
            Debug.Log("FsmGameIdleNode OnEnter");
            LoadGameData();
            var handle = YooAssets.LoadAssetAsync<GameObject>("Assets/Prefabs/UI/UIMainWindow.prefab");
            handle.Completed += HandleOnCompleted;
        }

        private void LoadGameData()
        {
            PlayerData.Create();
        }

        private GameObject uiMainWindow;
        private void HandleOnCompleted(AssetHandle obj)
        {
            var uiRoot = GameObject.Find("/UICamera");
            uiMainWindow = obj.InstantiateSync(uiRoot.transform);
        }

        public void OnUpdate()
        {
            
        }

        public void OnExit()
        {
            uiMainWindow.SetActive(false);
        }
    }
}