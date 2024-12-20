using System;
using UnityEngine;
using UnityEngine.UI;
using YooAsset;

namespace UI.WindowLogic
{
    public class UIStartWindow : MonoBehaviour
    {
        public Button btnStart;

        private void Awake()
        {
            btnStart.onClick.AddListener(OnClickStart);
        }

        private void OnClickStart()
        {
            if (PlayerData.instance.ftueLevel == 0)
            {
                PlayerData.instance.ftueLevel = 1;
                PlayerData.instance.Save();
            }
            SceneEventDefine.ChangeToMainScene.SendEventMessage();
        }
    }
}