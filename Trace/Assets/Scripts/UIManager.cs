using BaseKit;
using UnityEngine;
using UnityEngine.UI;

class UIManager: BaseObject
{
    [SerializeField]
    private Text textPrefab;
    [SerializeField]
    private Text staticTextPrefab;

    public GameObject logPanel, textObject;

    [SerializeField]
    private LogManager logManager = new LogManager();


    public override void onAwakeBaseObject()
    {
        staticTextPrefab.text = logManager.printLog();
        Debug.Log("UI Manager awake");
    }

    public override void onUpdateBaseObject()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            logManager.sendLog("You pressed space key");

        }

    }

}
