// THIS FILE IS A FUCKING MESS BUT IDK HOW TO FIX IT WITHOUT A REWRITE
// REMIND ME IN A MONTH
// FUK IT REWRITE INCOMING

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EditorController : MonoBehaviour
{
      
}

[CustomEditor(typeof(EditorController))]
public class EditorControllerEditor : Editor
{
    public BeatmapSO map;

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        map = (BeatmapSO)EditorGUILayout.ObjectField(map, typeof(BeatmapSO));
    }
}