using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform targetpos;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = targetpos.position + offset;
        //transform.position = targetpos.position+offset;
        newpos.y = 0;
        newpos.z = -10;
        transform.position = newpos;
    }
}
