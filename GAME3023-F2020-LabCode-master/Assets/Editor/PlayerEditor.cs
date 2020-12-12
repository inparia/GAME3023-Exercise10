using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlayerCharacterController))]
public class PlayerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PlayerCharacterController myPlayerCharacterController = (PlayerCharacterController)target;

        EditorGUILayout.LabelField("Speed : ", myPlayerCharacterController.speed.ToString());
    }

}
