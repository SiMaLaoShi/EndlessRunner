using UniFramework.Machine;
using UnityEngine;
using YooAsset;

namespace Game.FsmNode
{
    public class FsmGameLoadingNode : IStateNode
    {
        private StateMachine machine;
        public void OnCreate(StateMachine machine)
        {
            this.machine = machine;
        }

        private AssetHandle themeDataHandle;
        private AssetHandle characterHandle;
        
        public void OnEnter()
        {
            Debug.Log($"FsmGameLoadingNode OnEnter");
            themeDataHandle = YooAssets.LoadAssetAsync<ThemeData>("Assets/Bundles/Themes/Default/themeData.asset");
            characterHandle = YooAssets.LoadAssetAsync<GameObject>("Assets/Bundles/Characters/Cat/character.prefab");
        }

        public void OnUpdate()
        {
            Debug.Log($"FsmGameLoadingNode OnUpdate");
            if (themeDataHandle is {IsDone: true})
            {
                ThemeDatabase.ThemeData = themeDataHandle.GetAssetObject<ThemeData>();
            }
            if (characterHandle is {IsDone: true})
            { 
                CharacterDatabase.Character = characterHandle.GetAssetObject<GameObject>().GetComponent<Character>();
            }

            if (null == ThemeDatabase.ThemeData || null == CharacterDatabase.Character)
            {
                return;
            }
            
            machine.ChangeState<FsmGameRunNode>();
        }

        public void OnExit()
        {
            themeDataHandle.Release();
            characterHandle.Release();
        }
    }
}