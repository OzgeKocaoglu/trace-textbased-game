using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : BaseObject
{
    [Header("Objects")]
    [SerializeField]
    private BaseObject[] baseObjects;

    private void Start()
    {
        CallBaseObjectStarts();
    }


    private void CallBaseObjectStarts()
    {
        for(int i = 0; i< baseObjects.Length; i++)
        {
            baseObjects[i].onStartBaseObject();
        }
    }

}
