using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public float velocity = 1;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;


        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;

        }

        if (Highscore.instance.score == 10)
        {
            speed = 10;
        }
    }
}
