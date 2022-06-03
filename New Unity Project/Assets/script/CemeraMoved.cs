using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CemeraMoved : MonoBehaviour
{
    public Transform myPlayerHead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = myPlayerHead.position;
        transform.rotation = myPlayerHead.rotation;
    }
}
