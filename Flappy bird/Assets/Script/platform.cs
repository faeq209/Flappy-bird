using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public GameObject platformp1;
    public Transform platformgen;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        width = platformp1.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<platformgen.position.x)
        {
            transform.position = new Vector3(transform.position.x + width, transform.position.y, transform.position.z);
            Instantiate(platformp1, transform.position, transform.rotation);
        }
        else
        {

        }
    }
}
