using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterWalkAnimController))]
public class PlayerWalkEditor : Editor
{
    public override void OnInspectorGUI()
    {
        CharacterWalkAnimController myCharacterWalkAnimController = (CharacterWalkAnimController)target;

        EditorGUILayout.LabelField("Direction : ", myCharacterWalkAnimController.walkDirection.ToString());
    }

}
