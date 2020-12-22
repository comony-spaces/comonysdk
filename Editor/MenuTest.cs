using UnityEditor;
using UnityEngine;

public class MenuTest : MonoBehaviour
{
    [MenuItem("ComonySDK/Do Something")]
    static void DoSomething()
    {
        Debug.Log("Doing Something...");
    }
}
