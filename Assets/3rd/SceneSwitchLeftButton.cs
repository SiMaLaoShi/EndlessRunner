using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityToolbarExtender;

[InitializeOnLoad]
public class SceneSwitchLeftButton
{
    static SceneSwitchLeftButton()
    {
        ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
        ToolbarExtender.RightToolbarGUI.Add(OnRightToolbarGui);
    }

    private static void OnRightToolbarGui()
    {
        GUILayout.FlexibleSpace();
    }

    static void OnToolbarGUI()
    {
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("boot"))
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Boot.unity");
            EditorApplication.isPaused = false;
            EditorApplication.isPlaying = true;
        }
        GUI.color = GUI.contentColor;
    }

    private static void SelectGameObjectByPath(string path)
    {
        // 获取指定的GameObject
        GameObject targetGameObject = GameObject.Find(path);

        // 将指定的GameObject设为选中状态
        Selection.activeGameObject = targetGameObject;

        // 将指定的GameObject滚动到可见区域
        SceneView.FrameLastActiveSceneViewWithLock();

        EditorGUIUtility.PingObject(targetGameObject);
    }
}