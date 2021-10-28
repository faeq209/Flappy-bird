using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jump;
    public ui y;

    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        if(Input.anyKeyDown)
        {
            rb.velocity = new Vector2(rb.velocity.x,jump);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="obstacle")
        {
            y.gameover();
           // SceneManager.LoadScene(0);
        }



    }
}
