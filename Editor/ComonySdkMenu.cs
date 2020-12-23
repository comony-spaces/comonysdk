using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class ComonySdkMenu : MonoBehaviour
{
    static ComonySdkMenu()
    {
        Debug.Log("Version Check");
        PackageManager.Client.Add("https://github.com/comony-spaces/comonysdk.git");
    }

    [MenuItem("ComonySDK/Upload Window")]
    static void ShowUploadWindow()
    {
        Debug.Log("ShowUploadWindow()");
    }
}
