using BaseKit;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [Header("Managers")]
    [SerializeField]
    private UIManager UIManager;

    [Header("Objects")]
    [SerializeField]
    private BaseObject[] baseObjects;


    private void Start()
    {
        CallBaseObjectStarts();
    }

    private void Awake()
    {
        CallBaseObjectAwakes();
    }

    private void Update()
    {
        CallBaseObjectUpdates();
    }


    private void CallBaseObjectStarts()
    {
        for(int i = 0; i< baseObjects.Length; i++)
        {
            baseObjects[i].onStartBaseObject();
        }
    }

    private void CallBaseObjectAwakes()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].onAwakeBaseObject();
        }
    }

    private void CallBaseObjectUpdates()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].onUpdateBaseObject();
        }
    }

    private void CallBaseObjectDestroys()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].onDestoryBaseObject();
        }
    }




}
