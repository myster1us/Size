using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;

public class Analytics : MonoBehaviour
{
 
    void Awake()
    {
        FB.Init(FBInitCallBack);
    }
    private void FBInitCallBack()
    {
        if (FB.IsInitialized)
        {
            FB.ActivateApp();
        }
    }
    public void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            if (FB.IsInitialized)
            {
                FB.ActivateApp();
            }
        }
    }



 
    public void LogLevelFailEvent(int level, bool fail, double valToSum)
    {
        var parameters = new Dictionary<string, object>();
        parameters["level"] = level;
        parameters["fail"] = fail;
        FB.LogAppEvent(
            "Level Fail",
            (float)valToSum,
            parameters
        );
    }

    public void LogLevelCompleteEvent(int level, bool complete, double valToSum)
    {
        var parameters = new Dictionary<string, object>();
        parameters["level"] = level;
        parameters["complete"] = complete;
        FB.LogAppEvent(
            "Level Complete",
            (float)valToSum,
            parameters
        );
    }
  

    public void LogLevelStartEvent(int level, bool start, double valToSum)
    {
        var parameters = new Dictionary<string, object>();
        parameters["level"] = level;
        parameters["start"] = start;
        FB.LogAppEvent(
            "Level Start",
            (float)valToSum,
            parameters
        );
    }
}
