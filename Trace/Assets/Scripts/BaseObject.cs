using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour, IUpdatable, IDestorable, IStartable
{

    public void onUpdateBaseObject()
    {
        Debug.Log("base object update");
    }

    public void onFixedUpdateBaseObject()
    {
        Debug.Log("fixed update object");
    }

    public void onDestoryBaseObject()
    {
      
    }

    public void onStartBaseObject()
    {
        Debug.Log("base object start");
    }

    public void onAwakeBaseObject()
    {
        
    }
}
