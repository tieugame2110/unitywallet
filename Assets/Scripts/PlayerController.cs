using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f, maxspeed = 3;
    public Rigidbody2D r2;
    // Start is called before the first frame update
    void Start()
    {
        r2.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right) * speed * h);
        if(r2.velocity.x> maxspeed)
        {
            r2.velocity = new Vector2(maxspeed, r2.velocity.y);
        }
        if (r2.velocity.x < -maxspeed)
        {
            r2.velocity = new Vector2(-maxspeed, r2.velocity.y);
        }
    }
}
