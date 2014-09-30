using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    public Vector2 force = new Vector2(100, 100);
    public float minVelocity = 10f;
    public Color collisionColor = new Color(1.0f, 0.6f, 0.6f);

    // Use this for initialization
    void Start()
    {
        rigidbody2D.AddForce(force);
        if (minVelocity > force.x)
        {
            minVelocity = force.x;
        }
        else if (minVelocity > force.y)
        {
            minVelocity = force.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody2D.velocity.magnitude < minVelocity)
        {
            rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x + force.x / 2, rigidbody2D.velocity.y + force.y / 2));
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = collisionColor;
            Invoke("CancelColor", 1.0f);
        }
    }

    void CancelColor()
    {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
    }
    
}
