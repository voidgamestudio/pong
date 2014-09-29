using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    public Vector2 force = new Vector2(100, 100);
    public float minVelocity = 10f;

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
        Debug.Log("Current Veloc: " + rigidbody2D.velocity.magnitude);
        if (rigidbody2D.velocity.magnitude < minVelocity)
        {
            rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x + force.x / 2, rigidbody2D.velocity.y + force.y / 2));
            Debug.Log("Changed Veloc: " + rigidbody2D.velocity.magnitude);
        }
    }
}
