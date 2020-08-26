using BaseKit;
using UnityEngine;
using UnityEngine.UI;

class UIManager: BaseObject
{
    [SerializeField]
    private Text textPrefab;
    [SerializeField]
    private Text staticTextPrefab;
    private LogManager logManager = new LogManager();


    public override void onAwakeBaseObject()
    {
        staticTextPrefab.text = logManager.getLog();
        Debug.Log("UI Manager awake");
    }

    public override void onUpdateBaseObject()
    {
        Debug.Log("UI Manager update");
        textPrefab.text = logManager.getDinamicLog();

    }
}
