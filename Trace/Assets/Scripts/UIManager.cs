using BaseKit;
using UnityEngine;
using UnityEngine.UI;

class UIManager: BaseObject
{
    [SerializeField]
    private Text textPrefab;
    private LogManager logManager = new LogManager();


    public override void onAwakeBaseObject()
    {
        Debug.Log("UI Manager awake");
    }

    public override void onUpdateBaseObject()
    {
        Debug.Log("UI Manager update");
        textPrefab.text = logManager.getLog();
    }
}
