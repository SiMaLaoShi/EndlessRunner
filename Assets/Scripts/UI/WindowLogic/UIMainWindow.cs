using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.WindowLogic
{
    public class UIMainWindow : MonoBehaviour
    {
        public Button btnRun;

        private void Awake()
        {
            btnRun.onClick.AddListener(OnClickRun);
        }

        private void OnClickRun()
        {
            
        }
    }
}