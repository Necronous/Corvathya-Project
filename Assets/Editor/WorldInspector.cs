using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using TMPro;

[CustomEditor(typeof(World))]
public class WorldInspector : Editor
{

    bool _dropDown = false;
    Vector2 _scroll;
    GUIStyle _style = new();
    bool _color = false;

    public override void OnInspectorGUI()
    {
        _dropDown = EditorGUILayout.Foldout(_dropDown, "World Variables");
        if (_dropDown)
        {
            if (World.Instance == null)
            {
                EditorGUILayout.LabelField("No Instance running...");
                base.OnInspectorGUI();
                return;
            }
            _scroll = EditorGUILayout.BeginScrollView(_scroll);

            foreach (KeyValuePair<int, object> kvp in WorldVariables.Variables)
            {
                if (_color)
                    _style.normal.textColor = Color.white;
                else
                    _style.normal.textColor = new Color(.7f, .7f, .7f);
                _color = !_color;
                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.LabelField($"({kvp.Value.GetType().Name}) {kvp.Key}", _style);
                EditorGUILayout.LabelField($"{kvp.Value.ToString()}", _style);

                EditorGUILayout.EndHorizontal();
            }
            EditorGUILayout.EndScrollView();
        }
        base.OnInspectorGUI();
    }
}
