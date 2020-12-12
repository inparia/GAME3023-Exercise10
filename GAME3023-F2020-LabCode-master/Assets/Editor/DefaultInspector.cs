using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class DefaultInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EditorGUILayout.HelpBox("Inventory for the player", MessageType.Info);
    }
}
