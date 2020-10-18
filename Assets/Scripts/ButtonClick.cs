using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 #if !UNITY_EDITOR
             Debug.unityLogger.logEnabled = true;
 #else
             Debug.unityLogger.logEnabled=false;
 #endif

public class ButtonClick : MonoBehaviour
{

    public void Click(){
        Debug.Log("button clicked");
    }

}
