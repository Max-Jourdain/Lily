
using UnityEngine;
using UnityEditor;

public class PositionExample : EditorWindow
{
    Vector2 p1;
    Vector2 p2;
    bool showBtn = true;    
    
    [MenuItem("PR_Issues/Window POS")]
    static void Init()
    {
        GetWindow<PositionExample>("Window POS");
    }
    
    void OnGUI()
    {
        Rect r = position;
        GUILayout.Label("Window Resolution: " + Screen.currentResolution);
        GUILayout.Label("DPI: " + Screen.dpi);

        GUILayout.Space(20);

        GUILayout.Label($"Position: {r.x}x{r.y}");
        GUILayout.Label($"Size: {r.width}x{r.height}");
        GUILayout.Space(20);
        p1 = EditorGUILayout.Vector2Field("Set the position:", p1);
        p2 = EditorGUILayout.Vector2Field("Set the size:", p2);

        if (showBtn)
        {
            if (GUILayout.Button("Set new POS"))
            {
                r.x = p1.x;
                r.y = p1.y;
                r.width = p2.x;
                r.height = p2.y;                
                position = r;
            }
        }
    }
} 