using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class ComonySdkMenu : MonoBehaviour
{
    static ComonySdkMenu()
    {
        Debug.Log("Update");
    }

    [MenuItem("ComonySDK/Upload Window")]
    static void ShowUploadWindow()
    {
        Debug.Log("ShowUploadWindow()");
    }
}
