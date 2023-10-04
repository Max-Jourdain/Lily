using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;

public class GetSysInfo : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;

    private void Start()
    {
        UpdateSystemInfoText();
    }

    private void UpdateSystemInfoText()
    {
        StringBuilder sysInfo = new StringBuilder();
        sysInfo.AppendLine("System Version: " + SystemInfo.operatingSystem);
        sysInfo.AppendLine("Processor: " + SystemInfo.processorType);
        sysInfo.AppendLine("Graphics: " + SystemInfo.graphicsDeviceName);
        sysInfo.AppendLine("Memory: " + SystemInfo.systemMemorySize + "MB");
        sysInfo.AppendLine("Unity Version: " + Application.unityVersion);

        text.text = sysInfo.ToString();
    }
}
