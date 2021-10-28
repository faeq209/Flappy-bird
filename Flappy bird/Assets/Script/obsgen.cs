using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsgen : MonoBehaviour
{
    public Transform genpoint;
    public GameObject obstacle;
    float diff;
    public float mindif,maxdif;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diff = Random.Range(mindif, maxdif);

        if(transform.position.x<genpoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + diff, Random.Range(-7,10), transform.position.z);
            Instantiate(obstacle, transform.position, transform.rotation);
        }
        
    }
}
