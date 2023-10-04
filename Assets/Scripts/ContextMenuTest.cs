using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenuTest : MonoBehaviour
{
    [ContextMenu("Context Menu Test")]
    void Test()
    {
        Debug.Log("Test");
    }
}
