using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    [SerializeField]
    Transform grabPoint;

    [SerializeField]
    Transform middleTip;
    [SerializeField]
    Transform thumbTip;
    [SerializeField]
    float minDistance;

    /* void Update()
    {
        if(IsGrabing)
        {
            Debug.Log("Grab");
        }
    }*/

    bool IsGrabing
    {
        get => Vector3.Distance(thumbTip.position, middleTip.position) <= minDistance;
    }
}
