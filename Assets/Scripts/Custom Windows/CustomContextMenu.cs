using UnityEditor;
using UnityEngine;

public class CustomContextMenu : EditorWindow
{
    [MenuItem("Tests/Custom Context Menu")]
    public static void ShowWindow()
    {
        GetWindow<CustomContextMenu>("Custom Context Menu");
    }

    //draw 
    void OnGUI()
    {
        if (GUILayout.Button("Open Context Menu"))
        {
            GenericMenu menu = new GenericMenu();
            menu.AddItem(new GUIContent("Item 1"), false, () => { Debug.Log("Item 1"); });
            menu.AddItem(new GUIContent("Item 2"), false, () => { Debug.Log("Item 2"); });
            menu.AddItem(new GUIContent("Item 3"), false, () => { Debug.Log("Item 3"); });
            menu.ShowAsContext();

            if (Event.current.type == EventType.ContextClick)
            {
                Event.current.Use();
                Debug.Log("Context Click");
            }
        }
    }
}
