using UnityEngine;
using UnityEditor;

public class MissingScriptFinder
{
    [MenuItem("Tools/Find Missing Scripts in Prefabs")]
    static void FindInPrefabs()
    {
        string[] allPrefabs = AssetDatabase.FindAssets("t:Prefab");
        int count = 0;

        foreach (string guid in allPrefabs)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            Component[] components = prefab.GetComponentsInChildren<Component>(true);

            foreach (Component c in components)
            {
                if (c == null)
                {
                    Debug.LogWarning($"Missing script found in prefab: {path}", prefab);
                    count++;
                }
            }
        }

        Debug.Log($"Scan complete. Found {count} missing script references.");
    }
}
