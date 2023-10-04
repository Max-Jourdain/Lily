using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GetSysInfo : MonoBehaviour
{
    public TMP_Text text;

    void Start()
    {
        GetSystemVersion();
    }

    void GetSystemVersion()
    {
        text.text = "System Version: " + SystemInfo.operatingSystem;
        text.text += "\nProcessor: " + SystemInfo.processorType;
        text.text += "\nGraphics: " + SystemInfo.graphicsDeviceName;
        text.text += "\nMemory: " + SystemInfo.systemMemorySize + "MB";
        text.text += "\nUnity Version: " + Application.unityVersion;
    }
}
