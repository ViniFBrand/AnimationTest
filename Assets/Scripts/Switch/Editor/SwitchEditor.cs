using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CustomEditor(typeof(Switch))]
public class SwitchEditor : Editor
{
    public override void OnInspectorGUI()
    {
        #region DISCARTED CODE
        //base.OnInspectorGUI();
        //myTarget.switchOn = EditorGUILayout.Toggle("Switch", myTarget.switchOn);
        //myTarget.uiBackground = (Image)EditorGUILayout.ObjectField("Background", myTarget.uiBackground, typeof(Image),true);
        #endregion

        Switch myTarget = (Switch)target;

        //Field to recieve background
        myTarget.uiBackground = (GameObject)EditorGUILayout.ObjectField("Background", myTarget.uiBackground, typeof(GameObject), true);

        //Check to see if Switch is turned on or off
        EditorGUILayout.LabelField("Switch está ligado?", myTarget.TurnSwitch().ToString());

        //Button to turn on Light Mode
        if (GUILayout.Button("ON"))
        {
            myTarget.switchOn = true;
            Debug.Log("Switch Ligado");
        }
        //Button to turn off Light Mode
        if (GUILayout.Button("OFF"))
        {
            myTarget.switchOn = false;
            Debug.Log("Switch Desligado");
        }
        //Message to explain what code does
        EditorGUILayout.HelpBox("Ligue ou Desligue o Light Mode", MessageType.Info);
    }
}
