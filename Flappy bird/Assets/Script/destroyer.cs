﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    GameObject destroyerob;
    // Start is called before the first frame update
    void Start()
    {
        destroyerob = GameObject.Find("destroyer");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < destroyerob.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
