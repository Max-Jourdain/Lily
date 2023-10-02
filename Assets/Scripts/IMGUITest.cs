using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUITest : MonoBehaviour
{
    private string stringToEdit = "Test";

    void OnGUI()
    {
        // Label
        GUI.skin.label.fontSize = 36;
        GUI.skin.label.alignment = TextAnchor.MiddleCenter;
        GUI.Label(new Rect(Screen.width / 2 - 300, Screen.height - 300, 600, 80), "IMGUI");

        // Input Field
        GUI.skin.textField.fontSize = 36;
        GUI.skin.textField.alignment = TextAnchor.MiddleCenter;
        stringToEdit = GUI.TextField(new Rect(Screen.width / 2 - 300, Screen.height - 200, 600, 80), stringToEdit, 25);
    }
}
